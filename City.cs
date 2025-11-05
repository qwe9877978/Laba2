using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
    public class City
    {
        public string Name;
        public Route[] Routes;
        public int RouteCount;

        public City()
        {
            Name = string.Empty;
            Routes = new Route[10];
            RouteCount = 0;
        }

        public City(string name) : this()
        {
            Name = name;
        }

        public City(string name, Route[] routes) : this(name)
        {
            if (routes != null)
            {
                for (int i = 0; i < routes.Length && RouteCount < Routes.Length; i++)
                {
                    Routes[RouteCount] = routes[i];
                    RouteCount++;
                }
            }
        }

        public void AddRoute(City targetCity, int cost)
        {
            if (RouteCount < Routes.Length)
            {
                Routes[RouteCount] = new Route(targetCity, cost);
                RouteCount++;
            }
        }

        public override string ToString()
        {
            if (RouteCount == 0)
            {
                return Name + ": нет путей";
            }

            string result = Name + ": ";
            for (int i = 0; i < RouteCount; i++)
            {
                result += Routes[i].ToString();
                if (i < RouteCount - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }
    }
}
