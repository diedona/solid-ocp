using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.OCP.AppConsole.Model
{
    public class DeveloperReportModel : IReportModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public double WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
