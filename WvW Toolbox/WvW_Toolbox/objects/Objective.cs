using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.objects
{
    public class Objective
    {
        public string id { get; set; }
        public string type { get; set; }
        public string owner { get; set; }

        public Objective(string id, string type, string owner)
        {
            this.id = id;
            this.type = type;
            this.owner = owner;
        }

        public Objective(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
    }
}
