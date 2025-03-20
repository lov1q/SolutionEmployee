using System;

namespace SolutionEmployeeClassLib
{
    public class Employee
    {
        public string Name;
        public string Lastname;
        public DateTime Birthday;
        public DateTime StartYear;
        public decimal Salary;
        public Education EmployeeEducation;
        public CurrentPosition EmployeePosition;
        public enum Education { HighSchool, Bachelor, Master, PhD }

        public enum CurrentPosition { Intern, Junior, Middle, Senior, Lead }

        public Employee(string name, string lastname, DateTime birthday, DateTime startyear, decimal salary, Employee.Education education, Employee.CurrentPosition position)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Birthday = birthday;
            this.StartYear = startyear;
            this.Salary = salary;
            this.EmployeeEducation = education;
            this.EmployeePosition = position;
        }

        public int CheckAge()
        {
            int retirenmentAge = 65;
            int currentYear = DateTime.Now.Year;
            int age = currentYear - Birthday.Year;
            return retirenmentAge - age;
        }

        public int AgeOnWork()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - StartYear.Year;
        }

        public decimal Bonus()
        {
            decimal bonusForSalary = 10;
            return Salary * (bonusForSalary / 100);
        }

        
    }
}
