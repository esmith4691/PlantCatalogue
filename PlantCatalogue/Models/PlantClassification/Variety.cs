using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlantCatalogue
{
    internal class Variety
    {
        internal Plant Plant { get; }
        internal string Name { get; }
        internal string Description { get; }
        internal TimePeriod SowingIndoors { get; }
        internal TimePeriod SowingOutdoors { get; }
        internal TimePeriod PlantingOutdoors { get; }
        internal TimePeriod Harvesting { get; }
    }
}