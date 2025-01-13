using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HrApp;

namespace HrApp
{
    internal class SQLService
    {
        private static SQLService shared;
        private static string connectionString = "Server=localhost;Database=HR;Trusted_Connection=True;";
        private SqlConnection connection;

        public List<User> users = new List<User>();
        public List<Candidate> candidates = new List<Candidate>();
        public List<Vacancy> vacancies = new List<Vacancy>();
        public List<Client> clients = new List<Client>();

        SQLService()
        {
            this.connection = new SqlConnection(connectionString);
            this.connection.Open();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("Не удалось установить соединение с базой данных");
                Environment.Exit(1);
                return;
            }

            this.fetchUsers();
        }

        public static SQLService getShared()
        {
            if (shared == null)
            {
                shared = new SQLService();
            }

            return shared;
        }

        private SqlDataReader selectDataFromCommand(string commandStr)
        {
            var command = new SqlCommand(commandStr, this.connection);
            return command.ExecuteReader();
        }

        public void fetchUsers()
        {
            var query = "SELECT UserID, Username, Password, Salt, FullName, Role FROM Users";
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var user = new User(reader); // Здесь используется ваш конструктор
                    users.Add(user);
                }
            }
        }





        public bool checkIfCandidateExist(string? initialsOptional)
        {
            var initials = "";
            if (initialsOptional != null)
            {
                initials = initialsOptional;
            }

            var reader = this.selectDataFromCommand($"select count(*) from Candidate where Initials=N'{initials}'");
            if (reader.HasRows)
            {
                reader.Read();
                var count = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return count != 0;
            }
            else
            {
                return false;
            }
        }

        public void insertValuesInTableReg(string tableName, string values)
        {
            var command = new SqlCommand($"insert into {tableName} values ({values})", connection);
            command.ExecuteNonQuery();
        }
        

        /*public void insertValuesInTable(string tableName, string values)
        {
            var query = $"INSERT INTO {tableName} VALUES ({values})";
            using (var command = new SqlCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка выполнения запроса: {query}\n{ex.Message}");
                }
            }
        }
        */

        public void insertValuesInTable(string tableName, string columns, string values)
        {
            var query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
            using (var command = new SqlCommand(query, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка выполнения запроса: {query}\n{ex.Message}");
                }
            }
        }




        public int InsertIntoTable(string tableName, Dictionary<string, object> columns)
        {
            // Формирование строки с именами столбцов и параметрами
            var columnNames = string.Join(", ", columns.Keys);
            var parameterNames = string.Join(", ", columns.Keys.Select(key => $"@{key}"));
            var query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames}); SELECT SCOPE_IDENTITY();";

            // Закрываем все открытые DataReader перед выполнением команды
            if (this.connection.State == System.Data.ConnectionState.Open)
            {
                var commandForReaderCheck = new SqlCommand("SELECT @@FETCH_STATUS", this.connection);
                try
                {
                    using (var reader = commandForReaderCheck.ExecuteReader())
                    {
                        if (!reader.IsClosed)
                        {
                            reader.Close();
                        }
                    }
                }
                catch
                {
                    // Если нет активного DataReader, ничего не делаем
                }
            }

            using (var command = new SqlCommand(query, this.connection))
            {
                // Добавление параметров
                foreach (var column in columns)
                {
                    command.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
                }

                try
                {
                    // Выполняем запрос и возвращаем ID последней вставленной строки
                    var result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int lastInsertedId))
                    {
                        // Логируем успешную вставку и возвращаем ID
                        Console.WriteLine($"Успешно добавлена запись в таблицу {tableName} с ID: {lastInsertedId}");
                        return lastInsertedId;
                    }

                    return -1; // Если идентификатор не удалось получить
                }
                catch (Exception ex)
                {
                    // Логируем запрос и ошибку
                    Console.WriteLine($"Ошибка выполнения запроса: {query}\nИсключение: {ex.Message}");
                    throw new Exception($"Ошибка выполнения запроса: {query}\n{ex.Message}");
                }
            }
        }





        /*  public void updateValuesInTable(string tableName, string values, string condition)
          {
              var command = new SqlCommand($"update {tableName} set {values} where {condition}", this.connection);
              command.ExecuteNonQuery();
          }
          */

        public void UpdateTable(string tableName, Dictionary<string, object> columns, string condition)
        {
            var setClauses = string.Join(", ", columns.Select(kvp => $"{kvp.Key}=@{kvp.Key}"));
            var query = $"UPDATE {tableName} SET {setClauses} WHERE {condition}";

            using (var command = new SqlCommand(query, connection))
            {
                foreach (var kvp in columns)
                {
                    command.Parameters.AddWithValue($"@{kvp.Key}", kvp.Value ?? DBNull.Value);
                }

                command.ExecuteNonQuery();
            }
        }


        public void updateValuesInTable(string tableName, Dictionary<string, object> columns, string condition)
        {
            var setClauses = string.Join(", ", columns.Keys.Select(key => $"{key}=@{key}"));
            var query = $"UPDATE {tableName} SET {setClauses} WHERE {condition}";

            using (var command = new SqlCommand(query, this.connection))
            {
                foreach (var column in columns)
                {
                    command.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
                }

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка выполнения запроса: {query}\n{ex.Message}");
                }
            }
        }


        public void fetchCandidates()
        {
            this.candidates = new List<Candidate>();
            var reader = this.selectDataFromCommand("select * from Candidate");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var candidate = new Candidate(reader);
                    this.candidates.Add(candidate);
                }

                reader.Close();
            }
        }

        public List<Interaction> FetchInteractions(int clientId)
        {
            var interactions = new List<Interaction>();
            var reader = selectDataFromCommand($"SELECT * FROM Interactions WHERE ClientID = {clientId}");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    interactions.Add(new Interaction(reader));
                }
            }

            reader.Close();
            return interactions;
        }


        // Метод для добавления новой записи в таблицу Vacancies
        public void insertVacancy(string values)
        {
            var command = new SqlCommand($"INSERT INTO Vacancies (ClientID, Title, Description, Requirements, SalaryRange, Status, StartDate, EndDate) VALUES ({values})", connection);
            command.ExecuteNonQuery();
        }

        // Метод для обновления записи в таблице Vacancies
        public void updateVacancy(string values, string condition)
        {
            var command = new SqlCommand($"UPDATE Vacancies SET {values} WHERE {condition}", this.connection);
            command.ExecuteNonQuery();
        }

        // Метод для получения списка вакансий из таблицы Vacancies
        public void fetchVacancies()
        {
            this.vacancies = new List<Vacancy>();
            var reader = this.selectDataFromCommand("SELECT * FROM Vacancies");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var vacancy = new Vacancy(reader);
                    this.vacancies.Add(vacancy);
                }

                reader.Close();
            }
        }

        public List<Client> fetchClients()
        {
            var clients = new List<Client>();
            var reader = this.selectDataFromCommand("SELECT * FROM Clients");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    clients.Add(new Client(reader));
                }
                reader.Close();
            }

            return clients;
        }

        public List<Client> fetchClient()
        {
            var clients = new List<Client>();
            var reader = this.selectDataFromCommand("SELECT * FROM Clients");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    clients.Add(new Client(reader));
                }
                reader.Close();
            }

            return clients;
        }

        public void DeleteRow(string tableName, string condition)
        {
            var query = $"DELETE FROM {tableName} WHERE {condition}";

            using (var command = new SqlCommand(query, this.connection))
            {
                try
                {
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        Console.WriteLine($"Удаление не выполнено. Условие: {condition}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка удаления строки: {ex.Message}");
                }
            }
        }


    }
}

