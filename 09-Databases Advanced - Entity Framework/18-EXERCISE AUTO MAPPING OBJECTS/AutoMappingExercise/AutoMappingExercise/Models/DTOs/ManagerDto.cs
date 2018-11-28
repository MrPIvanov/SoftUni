using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMappingExercise.Models.DTOs
{
    public class ManagerDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<EmployeeInfoDto> ManagerEmployees { get; set; } = new HashSet<EmployeeInfoDto>();

        public int Count => this.ManagerEmployees.Count;
    }
}
