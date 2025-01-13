using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HrApp
{
    public class Candidate: ICloneable
    {
        public readonly int id;
        public string initials;
        public string? phoneNumber;
        public string email;
        public string? previousWorkPlaces;
        public string hardSkills;
        public string softSkills;
        public string jobName;

        public Candidate(SqlDataReader reader)
        {
            this.id = Convert.ToInt32(reader.GetValue(0));
            this.initials = reader.GetString(1).ToString();
            var phoneNumber = reader.IsDBNull(2) ? null : reader.GetString(2);
            if (phoneNumber != null)
            {
                this.phoneNumber = phoneNumber.ToString();
            }

            this.email = reader.GetString(3).ToString();
            var previousWorkPlace = reader.IsDBNull(4) ? null : reader.GetString(4);
            if (previousWorkPlace != null)
            {
                this.previousWorkPlaces = previousWorkPlace.ToString();
            }

            this.hardSkills = reader.GetString(5).ToString();
            this.softSkills = reader.GetString(6).ToString();
            this.jobName = reader.GetString(7).ToString();
        }

        public Candidate(string initials, string? phoneNumber, string email, string? previousWorkPlaces, string hardSkills, string softSkills, string jobName)
        {
            this.id = -1;
            this.initials = initials;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.previousWorkPlaces = previousWorkPlaces;
            this.hardSkills = hardSkills;
            this.softSkills = softSkills;
            this.jobName = jobName;
        }

        public string[] dataGridData()
        {
            var array = new string[4];
            array.Append(this.initials);
            if (this.phoneNumber != null)
            {
                array.Append(this.phoneNumber);
            } else
            {
                array.Append("N/A");
            }

            array.Append(this.email);
            array.Append(this.jobName);

            return array;
        }

        public override bool Equals(object? obj)
        {
            var rhs = obj as Candidate;
            if (rhs == null)
            {
                return false;
            }

            var lhs = this;
            return lhs.email == rhs.email && lhs.initials == rhs.initials && lhs.phoneNumber == rhs.phoneNumber && lhs.jobName == rhs.jobName && lhs.hardSkills == rhs.hardSkills && lhs.softSkills == rhs.softSkills && lhs.previousWorkPlaces == rhs.previousWorkPlaces;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
