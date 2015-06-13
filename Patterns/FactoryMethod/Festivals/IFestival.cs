using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Represents musical festival
    /// </summary>
    interface IFestival
    {
        /// <summary>
        /// Get a string with short festival information
        /// </summary>
        /// <returns></returns>
        string GetFestivalInfo();

        /// <summary>
        /// Get object describes a place to live during a festival
        /// </summary>
        /// <returns></returns>
        IPlaceToLive GetPlaceToLive();
    }
}
