using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionEmployeeClassLib;
using System;
using static SolutionEmployeeClassLib.Employee;

namespace SolutionEmployeeUnitTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void CheckAgeZeroAgeShowsError()
        {
            Employee employee1 = new Employee("Иван", "Иванов", new DateTime(1990, 5, 20), new DateTime(2015, 5, 20), 75000, Education.Bachelor, CurrentPosition.Middle);
            int actual = employee1.CheckAge();
            Assert.AreEqual(45, actual);
        }
    }
}
