using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    class ObserverExample : IPatternTest
    {
        public void Run()
        {
            var metalMagazine = new MetalEventNewsmaker();
            var metalFan1 = new MetalFan("Corey");
            var metalFan2 = new MetalFan("Jason");

            metalFan1.Subscribe(metalMagazine);
            metalFan2.Subscribe(metalMagazine);

            var rammsteinOnHellfest2016 = new MetalEvent("Rammstein", new DateTime(2016, 6, 11));
            metalMagazine.TellAboutEvent(rammsteinOnHellfest2016);

            metalFan1.Unsubscribe();

            metalMagazine.StopBroadcasting();

            Console.ReadKey();
        }
    }
}
