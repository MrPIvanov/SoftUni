using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMappingExercise.Data;
using AutoMappingExercise.Models;
using AutoMappingExercise.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AutoMappingExercise
{
    public class Engine
    {
        public void Run()
        {
            using (var context = new AutoMappingContext())
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Employee, ManagerDto>().ReverseMap();
                    cfg.CreateMap<Employee, EmployeeFullInfoDto>().ReverseMap();

                    cfg.CreateMap<Employee, EmployeeWithBirthdayDto>()
                    .ForMember(x => x.ManagerLastName, opt => opt.MapFrom(src => src.Manager.LastName));
                });

                while (true)
                {
                    var commandArgs = Console.ReadLine().Split();
                    var command = commandArgs[0];
                    var commandParameters = commandArgs.Skip(1).ToArray();

                    switch (command)
                    {
                        case "AddEmployee":
                            var AddEmployeeResult = AddEmployeeCommand(context, commandParameters);
                            Console.WriteLine(AddEmployeeResult);
                            break;

                        case "SetBirthday":
                            var SetBirthdayResult = SetBirthdayCommand(context, commandParameters);
                            Console.WriteLine(SetBirthdayResult);
                            break;

                        case "SetAddress":
                            var SetAddressResult = SetAddressCommand(context, commandParameters);
                            Console.WriteLine(SetAddressResult);
                            break;

                        case "EmployeeInfo":
                            EmployeeInfoDto employee = GetEmployeeInfo(context, commandParameters);
                            PrintEmployeeDto(employee);
                            break;

                        case "EmployeePersonalInfo":
                            EmployeeFullInfoDto employeeFullInfo = GetEmployeeFullInfo(context, commandParameters);
                            Console.WriteLine(employeeFullInfo);
                            break;

                        case "Exit":
                            Environment.Exit(0);
                            break;

                        case "SetManager":
                            var SetManagerResult = SetManagerCommand(context, commandParameters);
                            Console.WriteLine(SetManagerResult);
                            break;

                        case "ManagerInfo":
                            ManagerDto manager = ManagerInfoCommand(context, commandParameters);
                            PrintManager(manager);
                            break;

                        case "ListEmployeesOlderThan":
                            ICollection<EmployeeWithBirthdayDto> employees = ListEmployeesOlderThanCommand(context, commandParameters);
                            foreach (var emp in employees)
                            {
                                PrintEmployeeWithBirthdayDto(emp);
                            }
                            break;
                    }
                }
            }
        }

        private ICollection<EmployeeWithBirthdayDto> ListEmployeesOlderThanCommand(AutoMappingContext context, string[] commandParameters)
        {
            var today = DateTime.Today;

            var employees = context
                                   .Employees
                                   .Where(x => (today.Year - x.Birthday.Value.Year) > int.Parse(commandParameters[0]))
                                   .ProjectTo<EmployeeWithBirthdayDto>()
                                   .ToArray();

            


            if (employees.Count() == 0)
            {
                throw new ArgumentException("No Employees older than this age.");
            }

            return employees;
        }

        private void PrintEmployeeWithBirthdayDto(EmployeeWithBirthdayDto emp)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName} - ${emp.Salary:f2} - Manager: {emp.ManagerLastName ?? "[no manager]"}");
        }

        private ManagerDto ManagerInfoCommand(AutoMappingContext context, string[] commandParameters)
        {
            var manager = context.Employees.Find(int.Parse(commandParameters[0]));

            var managerToReturn = Mapper.Map<ManagerDto>(manager);

            if (managerToReturn == null)
            {
                throw new ArgumentException("No Employee with that Id.");
            }


            return managerToReturn;
        }

        private void PrintManager(ManagerDto manager)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{manager.FirstName} {manager.LastName} | Employees: {manager.Count}");

            foreach (var employee in manager.ManagerEmployees)
            {
                sb.AppendLine($"    - {employee.FirstName} {employee.LastName} - ${employee.Salary:f2}");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private string SetManagerCommand(AutoMappingContext context, string[] commandParameters)
        {
            var employee = context.Employees.Find(int.Parse(commandParameters[0]));
            var manager = context.Employees.Find(int.Parse(commandParameters[1]));

            if (employee == null || manager == null)
            {
                return "Invalid Id.";
            }

            employee.Manager = manager;

            context.SaveChanges();

            return "Manager set succsessfully.";
        }

        private EmployeeFullInfoDto GetEmployeeFullInfo(AutoMappingContext context, string[] commandParameters)
        {
            var employee = context
                                   .Employees
                                   .Find(int.Parse(commandParameters[0]));

            var employeeToReturn = Mapper.Map<EmployeeFullInfoDto>(employee);


            if (employeeToReturn == null)
            {
                throw new ArgumentException("No Employee with that Id.");
            }

            return employeeToReturn;
        }

        private EmployeeInfoDto GetEmployeeInfo(AutoMappingContext context, string[] commandParameters)
        {
            var employee = context
                                   .Employees
                                   .Find(int.Parse(commandParameters[0]));

            Mapper.Initialize(cfg => cfg.CreateMap<Employee, EmployeeInfoDto>().ReverseMap());

            var employeeToReturn = Mapper.Map<EmployeeInfoDto>(employee);


            if (employeeToReturn == null)
            {
                throw new ArgumentException("No Employee with that Id.");
            }

            return employeeToReturn;
        }

        private void PrintEmployeeDto(EmployeeInfoDto employee)
        {
            Console.WriteLine($"ID: {employee.EmployeeId} - {employee.FirstName} {employee.LastName} -  ${employee.Salary:f2}");
        }

        private string SetAddressCommand(AutoMappingContext context, string[] commandParameters)
        {
            var employee = context.Employees.Find(int.Parse(commandParameters[0]));

            if (employee == null)
            {
                return "Employee with that Id dont exist.";
            }

            employee.Address = string.Join(" ", commandParameters.Skip(1));

            context.SaveChanges();

            return "Address set correctly.";
        }

        private string SetBirthdayCommand(AutoMappingContext context, string[] commandParameters)
        {
            var employee = context.Employees.Find(int.Parse(commandParameters[0]));

            if (employee == null)
            {
                return "Employee with that Id dont exist.";
            }

            employee.Birthday = DateTime.ParseExact(commandParameters[1], "dd-MM-yyyy", CultureInfo.InvariantCulture);

            context.SaveChanges();

            return "Birthday set correctly.";
        }

        private string AddEmployeeCommand(AutoMappingContext context, string[] commandParameters)
        {
            var employee = new Employee
            {
                FirstName = commandParameters[0],
                LastName = commandParameters[1],
                Salary = decimal.Parse(commandParameters[2])
            };

            context.Employees.Add(employee);

            context.SaveChanges();

            return "Employee added succsessfully.";
        }
    }
}
