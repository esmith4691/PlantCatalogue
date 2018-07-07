using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlantCatalogue
{
    internal class Plant
    {
        internal Plant(PlantType type)
        {
            Type = type;
        }

        internal string CommonName { get; }
        internal string LatinName { get; }
        internal PlantType Type { get;}
    }
}