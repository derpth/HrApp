using System;
using System.Data.SqlClient;

namespace HrApp
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string FullName { get; set; } // Свойство fullName
        public Role Role { get; set; } // Свойство role

        // Конструктор для чтения из SqlDataReader
        public User(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["UserID"]);
            this.Username = reader["Username"].ToString() ?? string.Empty;
            this.PasswordHash = reader["Password"].ToString() ?? string.Empty;
            this.Salt = reader["Salt"]?.ToString() ?? string.Empty;
            this.FullName = reader["FullName"]?.ToString() ?? string.Empty; // Полное имя

            // Преобразование роли
            var roleString = reader["Role"].ToString()?.ToLower();
            this.Role = roleString switch
            {
                "admin" => Role.Admin,
                "user" => Role.User,
                _ => Role.None
            };
        }

        // Конструктор для создания нового пользователя
        public User(string username, string passwordHash, string salt, string fullName, Role role)
        {
            this.Id = -1; // Для новых пользователей
            this.Username = username;
            this.PasswordHash = passwordHash;
            this.Salt = salt;
            this.FullName = fullName;
            this.Role = role;
        }
    }
}
