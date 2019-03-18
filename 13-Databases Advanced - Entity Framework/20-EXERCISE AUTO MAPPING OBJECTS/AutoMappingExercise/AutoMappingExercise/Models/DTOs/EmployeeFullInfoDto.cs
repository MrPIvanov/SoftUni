using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMappingExercise.Models.DTOs
{
    public class EmployeeFullInfoDto
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime? Birthday { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"ID: {EmployeeId} - {FirstName} {LastName} - ${Salary:f2}");
            sb.AppendLine($"Birthday: {Birthday.Value.Day:d2}-{Birthday.Value.Month:d2}-{Birthday.Value.Year}");
            sb.AppendLine($"Address: {Address}");

            return sb.ToString().TrimEnd();
        }
    }
}
