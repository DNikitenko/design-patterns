using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class Tuska : IFestival
    {
        public string GetFestivalInfo()
        {
            return "Tuska - annual metal festival. It is hold in Helsinki, Finland.";
        }

        public IPlaceToLive GetPlaceToLive()
        {
            return new Hostel();
        }
    }
}
