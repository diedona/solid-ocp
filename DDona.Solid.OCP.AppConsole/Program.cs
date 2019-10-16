using DDona.Solid.OCP.AppConsole.Calculators;
using DDona.Solid.OCP.AppConsole.Calculators.Handler;
using DDona.Solid.OCP.AppConsole.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DDona.Solid.OCP.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IBaseCalculator> calculators = new List<IBaseCalculator>()
            {
                new SeniorDeveloperCalculator(new DeveloperReportModel {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDeveloperCalculator(new DeveloperReportModel {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDeveloperCalculator(new DeveloperReportModel {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 }),
                new CTOCalculator(new ExecutiveReportModel() { Name = "CTO", Bonus = 3500, HourlyRate = 50, WorkingHours = 200})
            };

            var calculator = new SalaryHandler(calculators);
            Console.WriteLine($"Sum of all the salaries is {calculator.CalculateSalary()} dollars");
        }
    }
}
