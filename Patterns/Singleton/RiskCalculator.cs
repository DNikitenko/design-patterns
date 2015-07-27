using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    /// <summary>
    /// Allows you to calculate health risks
    /// </summary>
    class RiskCalculator
    {
        /// <summary>
        /// Hiding constructor to avoid direct class instance creation
        /// </summary>
        private RiskCalculator(){}

        /// <summary>
        /// Lazy initializer of singleton object
        /// </summary>
        static Lazy<RiskCalculator> _lazyInstance = new Lazy<RiskCalculator>(() => new RiskCalculator());

        /// <summary>
        /// Get RiskCalculator object instance
        /// </summary>
        public static RiskCalculator Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }

        /// <summary>
        /// Calculates stroke risk based on your blood pressure
        /// </summary>
        /// <param name="systolicBp"></param>
        /// <param name="diastolicBp"></param>
        /// <returns></returns>
        public double GetStrokeRiskValue(double systolicBp, double diastolicBp)
        {
            //Fake risk, of course :)
            return systolicBp + diastolicBp;
        }
    }
}
