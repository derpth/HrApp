using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace HrApp
{
    public class Vacancy : ICloneable
    {
        public readonly int Id;                // VacancyID
        public string Title;                   // Title
        public int ClientID;                   // ClientID
        public string? Description;            // Description
        public string? Requirements;           // Requirements
        public string? SalaryRange;            // SalaryRange
        public string Status;                  // Status
        public string StartDate;            // StartDate
        public string EndDate;              // EndDate

        // Конструктор, заполняющий поля из SqlDataReader
        public Vacancy(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["VacancyID"]);
            this.Title = reader["Title"].ToString();
            this.ClientID = Convert.ToInt32(reader["ClientID"]);
            this.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader["Description"].ToString();
            this.Requirements = reader.IsDBNull(reader.GetOrdinal("Requirements")) ? null : reader["Requirements"].ToString();
            this.SalaryRange = reader.IsDBNull(reader.GetOrdinal("SalaryRange")) ? null : reader["SalaryRange"].ToString();
            this.Status = reader["Status"].ToString();
            this.StartDate = reader["StartDate"].ToString();
            this.EndDate = reader["EndDate"].ToString();

        }

        // Конструктор, заполняющий поля вручную
        public Vacancy(string title, int clientId, string? description, string? requirements, string? salaryRange, string status, string startDate, string endDate)
        {
            this.Id = -1; // ID устанавливается базой данных
            this.Title = title;
            this.ClientID = clientId;
            this.Description = description;
            this.Requirements = requirements;
            this.SalaryRange = salaryRange;
            this.Status = status;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        // Метод для получения данных для DataGridView
        public string[] DataGridData()
        {
            return new string[]
            {
                this.Title,
                this.ClientID.ToString(),
                this.Description ?? "N/A",
                this.Requirements ?? "N/A",
                this.SalaryRange ?? "N/A",
                this.Status,
                this.StartDate,
                this.EndDate,
            };
        }

        // Сравнение объектов
        public override bool Equals(object? obj)
        {
            var rhs = obj as Vacancy;
            if (rhs == null)
            {
                return false;
            }

            return this.Title == rhs.Title &&
                   this.ClientID == rhs.ClientID &&
                   this.Description == rhs.Description &&
                   this.Requirements == rhs.Requirements &&
                   this.SalaryRange == rhs.SalaryRange &&
                   this.Status == rhs.Status &&
                   this.StartDate == rhs.StartDate &&
                   this.EndDate == rhs.EndDate;
        }

        // Метод клонирования объекта
        public object Clone()
        {
            return new Vacancy
            {
                Id = this.Id,
                Title = string.Copy(this.Title),
                ClientID = this.ClientID,
                Description = this.Description != null ? string.Copy(this.Description) : null,
                Requirements = this.Requirements != null ? string.Copy(this.Requirements) : null,
                SalaryRange = this.SalaryRange != null ? string.Copy(this.SalaryRange) : null,
                Status = string.Copy(this.Status),
                StartDate = string.Copy(this.StartDate),
                EndDate = string.Copy(this.EndDate)
            };
        }

    }
}
*/


namespace HrApp
{
    public class Vacancy : ICloneable
    {
        public int Id { get; private set; }       // VacancyID
        public string Title { get; set; }         // Title
        public int ClientID { get; set; }         // ClientID
        public string? Description { get; set; }  // Description
        public string? Requirements { get; set; } // Requirements
        public string? SalaryRange { get; set; }  // SalaryRange
        public string Status { get; set; }        // Status
        public string StartDate { get; set; }     // StartDate
        public string EndDate { get; set; }       // EndDate

        // Конструктор по умолчанию
        public Vacancy()
        {
            this.Id = -1;
            this.Title = string.Empty;
            this.ClientID = 0;
            this.Description = null;
            this.Requirements = null;
            this.SalaryRange = null;
            this.Status = "Открыта";
            this.StartDate = string.Empty;
            this.EndDate = string.Empty;
        }

        // Конструктор, заполняющий поля из SqlDataReader
        public Vacancy(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["VacancyID"]);
            this.Title = reader["Title"].ToString() ?? string.Empty;
            this.ClientID = Convert.ToInt32(reader["ClientID"]);
            this.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader["Description"].ToString();
            this.Requirements = reader.IsDBNull(reader.GetOrdinal("Requirements")) ? null : reader["Requirements"].ToString();
            this.SalaryRange = reader.IsDBNull(reader.GetOrdinal("SalaryRange")) ? null : reader["SalaryRange"].ToString();
            this.Status = reader["Status"].ToString() ?? "Открыта";
            this.StartDate = reader["StartDate"].ToString() ?? string.Empty;
            this.EndDate = reader["EndDate"].ToString() ?? string.Empty;
        }

        // Конструктор, заполняющий поля вручную
        public Vacancy(string title, int clientId, string? description, string? requirements, string? salaryRange, string status, string startDate, string endDate)
        {
            this.Id = -1; // ID устанавливается базой данных
            this.Title = title;
            this.ClientID = clientId;
            this.Description = description;
            this.Requirements = requirements;
            this.SalaryRange = salaryRange;
            this.Status = status;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        // Метод для получения данных для DataGridView
        public string[] DataGridData()
        {
            return new string[]
            {
                this.Title,
                this.ClientID.ToString(),
                this.Description ?? "N/A",
                this.Requirements ?? "N/A",
                this.SalaryRange ?? "N/A",
                this.Status,
                this.StartDate,
                this.EndDate,
            };
        }

        // Сравнение объектов
        public override bool Equals(object? obj)
        {
            var rhs = obj as Vacancy;
            if (rhs == null)
            {
                return false;
            }

            return this.Title == rhs.Title &&
                   this.ClientID == rhs.ClientID &&
                   this.Description == rhs.Description &&
                   this.Requirements == rhs.Requirements &&
                   this.SalaryRange == rhs.SalaryRange &&
                   this.Status == rhs.Status &&
                   this.StartDate == rhs.StartDate &&
                   this.EndDate == rhs.EndDate;
        }

        // Метод клонирования объекта
        public object Clone()
        {
            return new Vacancy
            {
                Id = this.Id,
                Title = this.Title,
                ClientID = this.ClientID,
                Description = this.Description,
                Requirements = this.Requirements,
                SalaryRange = this.SalaryRange,
                Status = this.Status,
                StartDate = this.StartDate,
                EndDate = this.EndDate
            };
        }
    }
}
