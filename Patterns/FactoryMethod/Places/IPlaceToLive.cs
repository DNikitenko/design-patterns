using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Represents a location, where tourists can stay at night
    /// </summary>
    interface IPlaceToLive
    {
        /// <summary>
        /// Get string with information about place to stay in
        /// </summary>
        /// <returns></returns>
        string GetBooking();
    }
}
