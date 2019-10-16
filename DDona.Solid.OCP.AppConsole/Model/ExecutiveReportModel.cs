using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.OCP.AppConsole.Model
{
    public class ExecutiveReportModel : IReportModel
    {
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
