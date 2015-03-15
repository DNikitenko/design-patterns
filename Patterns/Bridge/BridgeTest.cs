using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    class BridgeTest : IPatternTest
    {
        public void Run()
        {
            MapPoint pointA = new MapPoint(40, 130, 10);
            MapPoint pointB = pointA;
            MapPoint pointC = new MapPoint(40, 130, 10);

            MapPoint pointD = new MapPoint(40, 130, 20);

            Console.WriteLine("pointA shares pointB body: " + pointA.BodyReferenceEquals(pointB));
            Console.WriteLine("pointA shares pointC body: " + pointA.BodyReferenceEquals(pointC));
            Console.WriteLine("pointC shares pointD body: " + pointC.BodyReferenceEquals(pointD));

            Console.ReadLine();

            //OUTPUT:
            //
            //pointA shares pointB body: True
            //pointA shares pointC body: True
            //pointC shares pointD body: False
        }
    }
}
