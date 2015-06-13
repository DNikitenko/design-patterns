using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class Hellfest : IFestival
    {
        public string GetFestivalInfo()
        {
            return "The best metal festival in France. See you in Clisson!";
        }

        public IPlaceToLive GetPlaceToLive()
        {
            return new Campsite();
        }
    }
}
