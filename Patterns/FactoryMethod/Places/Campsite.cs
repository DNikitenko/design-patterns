using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class Campsite : IPlaceToLive
    {
        public string GetBooking()
        {
            return "Ha! We can provide you some place to install your tent, and that's all! :-)";
        }
    }
}
