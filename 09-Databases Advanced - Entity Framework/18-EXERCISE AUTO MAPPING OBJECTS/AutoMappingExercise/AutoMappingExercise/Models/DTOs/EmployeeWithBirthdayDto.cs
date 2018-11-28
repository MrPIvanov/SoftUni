using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMappingExercise.Models.DTOs
{
    public class EmployeeWithBirthdayDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public string ManagerLastName { get; set; }

    }
}
