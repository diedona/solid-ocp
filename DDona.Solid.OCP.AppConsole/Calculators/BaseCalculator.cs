using DDona.Solid.OCP.AppConsole.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.OCP.AppConsole.Calculators
{
    public abstract class BaseCalculator<T> : IBaseCalculator where T: IReportModel
    {
        protected T ReportModel { get; private set; }

        public BaseCalculator(T reportModel)
        {
            this.ReportModel = reportModel;
        }

        public virtual double CalculateSalary()
        {
            return (this.ReportModel.HourlyRate * this.ReportModel.WorkingHours);
        }
    }
}
