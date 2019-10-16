using System;
using System.Collections.Generic;
using System.Text;
using DDona.Solid.OCP.AppConsole.Model;

namespace DDona.Solid.OCP.AppConsole.Calculators
{
    public class SeniorDeveloperCalculator : BaseCalculator<DeveloperReportModel>
    {
        public SeniorDeveloperCalculator(DeveloperReportModel developerReportModel) : base(developerReportModel)
        {
        }

        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            // lets say... 10% bonus
            double salaryWithBonus = (baseSalary * 1.1);
            return salaryWithBonus;
        }
    }
}
