using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMappingExercise.Models.DTOs
{
    public class EmployeeInfoDto
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}
