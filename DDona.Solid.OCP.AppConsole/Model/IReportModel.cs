using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.OCP.AppConsole.Model
{
    public interface IReportModel
    {
        double WorkingHours { get; set; }
        double HourlyRate { get; set; }
    }
}
