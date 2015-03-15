using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    /// <summary>
    /// Represents point location. This class should be placed in another assembly or nested inside MapPoint class
    /// to avoid direct access from clients
    /// </summary>
    class MapPointRep
    {
        /// <summary>
        /// Constructor. It's a private one, so you cannot create MapPointRep instance with new() syntax
        /// </summary>
        /// <param name="altitude"></param>
        /// <param name="latitude"></param>
        /// <param name="height"></param>
        MapPointRep(double altitude, double latitude, double height)
        {
            Altitude = altitude;
            Latitude = latitude;
            Height = height;
        }

        /// <summary>
        /// Altitude
        /// </summary>
        internal double Altitude { get; private set; }

        /// <summary>
        /// Longitude
        /// </summary>
        internal double Latitude { get; private set; }

        /// <summary>
        /// Height
        /// </summary>
        internal double Height { get; private set; }

        /// <summary>
        /// List of distinct instances
        /// </summary>
        static List<MapPointRep> _instances = new List<MapPointRep>();

        /// <summary>
        /// Get existing MapPointRep instance or create a new one
        /// </summary>
        /// <param name="altitude"></param>
        /// <param name="latitude"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static internal MapPointRep GetInstance(double altitude, double latitude, double height)
        {
            var instance = _instances.FirstOrDefault(point =>
                    point.Altitude == altitude &&
                    point.Latitude == latitude &&
                    point.Height == height);

            if (instance == null)
            {
                instance = new MapPointRep(altitude, latitude, height);
                _instances.Add(instance);
            }

            return instance;
        }
    }
}
