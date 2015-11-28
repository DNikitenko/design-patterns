using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template_Method
{
    abstract class ReportBuilder
    {
        protected readonly StringBuilder ReportText = new StringBuilder();

        protected abstract void GenerateIntroduction();

        protected abstract void GenerateHeatingSection();

        protected abstract void GenerateElectricitySection();

        protected abstract void GenerateColdWaterConsumptionReport();

        protected abstract void GenerateConclusion();

        public string GetReport()
        {
            GenerateIntroduction();
            GenerateHeatingSection();
            GenerateElectricitySection();
            GenerateColdWaterConsumptionReport();
            GenerateConclusion();

            return ReportText.ToString();
        }
    }
}
