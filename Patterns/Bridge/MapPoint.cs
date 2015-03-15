using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    /// <summary>
    /// Provides interface to point location
    /// </summary>
    class MapPoint
    {
        /// <summary>
        /// Map point representation
        /// </summary>
        MapPointRep _body;

        /// <summary>
        /// Point altitude
        /// </summary>
        public double Altitude { get { return _body.Altitude; } }

        /// <summary>
        /// Point latitude
        /// </summary>
        public double Latitude { get { return _body.Latitude; } }

        /// <summary>
        /// Point absolute height
        /// </summary>
        public double Height { get { return _body.Height; } }

        /// <summary>
        /// Creates new instance of MapPoint using given coordinates
        /// </summary>
        /// <param name="altitude"></param>
        /// <param name="latitude"></param>
        /// <param name="height"></param>
        public MapPoint(double altitude, double latitude, double height)
        {
            _body = MapPointRep.GetInstance(altitude, latitude, height);
        }

        /// <summary>
        /// Determines whether body is shared
        /// </summary>
        /// <param name="anotherPoint"></param>
        /// <returns></returns>
        public bool BodyReferenceEquals(MapPoint anotherPoint)
        {
            return ReferenceEquals(this._body, anotherPoint._body);
        }
    }
}