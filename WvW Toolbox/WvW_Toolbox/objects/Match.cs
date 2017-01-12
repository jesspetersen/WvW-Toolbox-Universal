using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.objects
{
    public class Match
    {
        Team red;
        Team blue;
        Team green;

        public Match(Team red, Team blue, Team green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }
    }
}
