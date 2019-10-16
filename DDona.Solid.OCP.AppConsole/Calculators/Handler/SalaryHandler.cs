using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.OCP.AppConsole.Calculators.Handler
{
    public class SalaryHandler
    {
        private readonly IEnumerable<IBaseCalculator> _calculators;

        public SalaryHandler(IEnumerable<IBaseCalculator> calculators)
        {
            _calculators = calculators;
        }

        public double CalculateSalary()
        {
            double total = 0;

            foreach (IBaseCalculator baseCalculator in _calculators)
            {
                total += baseCalculator.CalculateSalary();
            }

            return total;
        }
    }
}
