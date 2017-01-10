using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.objects
{
    class World
    {
        string name;
        string id;
        string population;

        public World() { }

        public World(string id, string name, string population)
        {
            this.id = id;
            this.name = name;
            this.population = population;
        }

        public World(int id, string name, string population)
        {
            this.id = Convert.ToString(id);
            this.name = name;
            this.population = population;
        }
    }
}
