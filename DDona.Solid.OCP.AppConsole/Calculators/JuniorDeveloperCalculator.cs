using System;
using System.Collections.Generic;
using System.Text;
using DDona.Solid.OCP.AppConsole.Model;

namespace DDona.Solid.OCP.AppConsole.Calculators
{
    public class JuniorDeveloperCalculator : BaseCalculator<DeveloperReportModel>
    {
        public JuniorDeveloperCalculator(DeveloperReportModel developerReportModel) : base(developerReportModel)
        {
        }
    }
}
