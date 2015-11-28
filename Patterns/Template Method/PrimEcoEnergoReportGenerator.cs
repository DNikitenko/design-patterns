using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template_Method
{
    class PrimEcoEnergoReportGenerator : ReportBuilder
    {
        protected override void GenerateIntroduction()
        {
            ReportText.AppendLine("This is a brand new report for some company.");
        }

        protected override void GenerateHeatingSection()
        {
            ReportText.AppendLine("Your heating expenses are too large because of low heat-shielding.");
        }

        protected override void GenerateElectricitySection()
        {
            ReportText.AppendLine("All objects are OK in electricity consumption.");
        }

        protected override void GenerateColdWaterConsumptionReport()
        {
            ReportText.AppendLine("Please install cold water meters.");
        }

        protected override void GenerateConclusion()
        {
            ReportText.AppendLine("We cannot say something useful. End of report.");
        }
    }
}
