using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod.Factories
{
    class FestivalFactory
    {
        public static IFestival CreateFestival(string festivalName)
        {
            switch (festivalName)
            {
                case "Hellfest": return new Hellfest();
                case "Tuska": return new Tuska();

                default: throw new NotImplementedException("Sorry, this festival is not available yet");
            }
        }
    }
}
