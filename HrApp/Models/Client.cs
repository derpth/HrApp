using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HrApp
{
    public class Client : ICloneable
    {
        public int ClientID { get; set; } // Идентификатор клиента
        public string CompanyName { get; set; } // Название компании
        public string ContactPerson { get; set; } // Контактное лицо
        public string Phone { get; set; } // Номер телефона
        public string? Email { get; set; } // Электронная почта (необязательное поле)
        public string? Address { get; set; } // Адрес (необязательное поле)
        public string? Notes { get; set; } // Заметки (необязательное поле)
        public DateTime DateAdded { get; set; } // Дата добавления клиента
        public bool IsActive { get; set; } // Статус клиента (активен/неактивен)

        // Конструктор без параметров
        public Client()
        {
            ClientID = 0; // Значение по умолчанию
            CompanyName = string.Empty;
            ContactPerson = string.Empty;
            Phone = string.Empty;
            Email = null;
            Address = null;
            Notes = null;
            DateAdded = DateTime.Now; // Устанавливается текущая дата
            IsActive = true; // Клиент активен по умолчанию
        }

        // Конструктор с SqlDataReader (для удобного извлечения из базы данных)
        public Client(SqlDataReader reader)
        {
            ClientID = Convert.ToInt32(reader["ClientID"]);
            CompanyName = reader["CompanyName"].ToString()!;
            ContactPerson = reader["ContactPerson"].ToString()!;
            Phone = reader["Phone"].ToString()!;
            Email = reader["Email"] as string; // Используется как nullable
            Address = reader["Address"] as string;
            Notes = reader["Notes"] as string;
            DateAdded = Convert.ToDateTime(reader["DateAdded"]);
            IsActive = Convert.ToBoolean(reader["IsActive"]);
        }

        // Метод для клонирования объекта
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
