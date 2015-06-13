using Patterns.FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod.TestExamples
{
    class FactoryMethodTest : IPatternTest
    {
        void PrintAggregateFestivalInfo(string festivalName)
        {
            var festival = FestivalFactory.CreateFestival(festivalName);
            Console.Write("Festival description: ");
            Console.WriteLine(festival.GetFestivalInfo());

            var placeToLive = festival.GetPlaceToLive();
            Console.Write("Where you will live: ");
            Console.WriteLine(placeToLive.GetBooking());
        }
        
        public void Run()
        {
            PrintAggregateFestivalInfo("Hellfest");
            Console.WriteLine();
            PrintAggregateFestivalInfo("Tuska");

            Console.ReadLine();

            //OUTPUT:

            //Festival description: The best metal festival in France. See you in Clisson!
            //Where you will live: Ha! We can provide you some place to install your tent, and that's all! :-)

            //Festival description: Tuska - annual metal festival. It is hold in Helsinki, Finland.
            //Where you will live: Hey guys! Here you've got a separate room with two beds and a public bathroom
        }
    }
}
