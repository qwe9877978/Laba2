using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
    public class Route
    {
        public City TargetCity;
        public int Cost;

        public Route(City targetCity, int cost)
        {
            TargetCity = targetCity;
            Cost = cost;
        }

        public override string ToString()
        {
            return TargetCity.Name + ":" + Cost;
        }
    }
}
