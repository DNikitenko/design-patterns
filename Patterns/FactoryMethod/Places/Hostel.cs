using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class Hostel : IPlaceToLive
    {
        public string GetBooking()
        {
            return "Hey guys! Here you've got a separate room with two beds and a public bathroom";
        }
    }
}
