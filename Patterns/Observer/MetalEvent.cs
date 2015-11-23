using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    /// <summary>
    /// Fucking metal tuska
    /// </summary>
    class MetalEvent
    {
        /// <summary>
        /// Band name
        /// </summary>
        public string Band { get; set; }

        /// <summary>
        /// Date of event
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// New metal event
        /// </summary>
        /// <param name="band"></param>
        /// <param name="date"></param>
        public MetalEvent(string band, DateTime date)
        {
            Band = band;
            Date = date;
        }
    }
}
