using System;
using System.Data.SqlClient;
namespace HrApp
{
    public class Interaction : ICloneable
    {
        public readonly int InteractionID;
        public int ClientID;
        public DateTime InteractionDate;
        public string Details;

        // Конструктор для чтения из SqlDataReader
        public Interaction(SqlDataReader reader)
        {
            this.InteractionID = Convert.ToInt32(reader["InteractionID"]);
            this.ClientID = Convert.ToInt32(reader["ClientID"]);
            this.InteractionDate = Convert.ToDateTime(reader["InteractionDate"]);
            this.Details = reader["Details"].ToString();
        }

        // Конструктор для создания новой записи взаимодействия
        public Interaction(int clientID, DateTime interactionDate, string details)
        {
            this.InteractionID = -1; // Новый ID назначается базой данных
            this.ClientID = clientID;
            this.InteractionDate = interactionDate;
            this.Details = details;
        }

        // Метод для подготовки данных для DataGridView
        public string[] DataGridData()
        {
            return new string[]
            {
                this.ClientID.ToString(),
                this.InteractionDate.ToString("yyyy-MM-dd"),
                this.Details
            };
        }

        // Переопределение метода Equals для сравнения объектов
        public override bool Equals(object? obj)
        {
            var other = obj as Interaction;
            if (other == null)
            {
                return false;
            }

            return this.ClientID == other.ClientID &&
                   this.InteractionDate == other.InteractionDate &&
                   this.Details == other.Details;
        }

        // Реализация метода клонирования
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
