using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    class SingletonTest : IPatternTest
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter your systolic BP");
                var systolicBpString = Console.ReadLine();

                Console.WriteLine("Enter your diastolic BP");
                var diastolicBpString = Console.ReadLine();

                int systolicBp, diastolicBp;

                if (Int32.TryParse(systolicBpString, out systolicBp) &&
                    Int32.TryParse(diastolicBpString, out diastolicBp))
                {
                    var riskCalculator = RiskCalculator.Instance;
                    var riskPoints = riskCalculator.GetStrokeRiskValue(systolicBp, diastolicBp);

                    Console.WriteLine(String.Format("Your risk is {0} points", riskPoints));
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input");
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}
