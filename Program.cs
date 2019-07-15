using System;

namespace List_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Deep = new Employee()
            {
                EmployeeName = "Deep Patel",
                EmployeeTitle = "Full Stack Developer",
                StartDate = "11/11/19"
            };
            Employee Janki = new Employee()
            {
                EmployeeName = "Janki Patel",
                EmployeeTitle = "CEO",
                StartDate = "11/11/19"
            };
            Employee Dan = new Employee()
            {
                EmployeeName = "Dan Strom",
                EmployeeTitle = "Full Stack Developer",
                StartDate = "11/11/19"
            };
            Employee Britney = new Employee()
            {
                EmployeeName = "Britney Strom",
                EmployeeTitle = "CEO",
                StartDate = "11/11/19"
            };
            Employee Joey = new Employee()
            {
                EmployeeName = "Joey Driscoll",
                EmployeeTitle = "Full Stack Developer",
                StartDate = "11/11/19"
            };
            Employee Jenna = new Employee()
            {
                EmployeeName = "Jenna Driscoll",
                EmployeeTitle = "CEO",
                StartDate = "11/11/19"
            };



            Company DeepAndCO = new Company()
            {
                CompanyName = "PDS co.",
            };

            DeepAndCO.HireEmployee(Deep);
            DeepAndCO.HireEmployee(Janki);
            DeepAndCO.HireEmployee(Dan);
            DeepAndCO.HireEmployee(Britney);
            DeepAndCO.HireEmployee(Joey);
            DeepAndCO.HireEmployee(Jenna);

            foreach (Employee employee in DeepAndCO.EmployeeList)
            {
                Console.WriteLine($"{employee.EmployeeName} works at {employee.CompanyName} as {employee.EmployeeTitle} joining/starting data is {employee.StartDate}");
            }
        }

    }
}