using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.utilities
{
    class RankNameSearchHelper
    {
        public static int[] SearchRank(string colour, string title)
        {
            //10000 is indicitive of an infinite number

            int upperBound = 0, lowerBound = 0;


            if (title == "Invader")
            {
                if (colour == "(none)")
                {
                    lowerBound = 1;
                    upperBound = 4;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 150;
                    upperBound = 179;
                }
                if (colour == "Silver")
                {
                    lowerBound = 620;
                    upperBound = 669;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1395;
                    upperBound = 1469;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 2545;
                    upperBound = 2644;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4095;
                    upperBound = 4244;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 6445;
                    upperBound = 6694;
                }
            }

            if (title == "Assaulter")
            {
                if (colour == "(none)")
                {
                    lowerBound = 5;
                    upperBound = 9;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 180;
                    upperBound = 209;
                }
                if (colour == "Silver")
                {
                    lowerBound = 670;
                    upperBound = 719;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1470;
                    upperBound = 1544;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 2645;
                    upperBound = 2744;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4245;
                    upperBound = 4394;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 6695;
                    upperBound = 6944;
                }
            }

            if (title == "Raider")
            {
                if (colour == "(none)")
                {
                    lowerBound = 10;
                    upperBound = 14;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 210;
                    upperBound = 239;
                }
                if (colour == "Silver")
                {
                    lowerBound = 720;
                    upperBound = 769;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1545;
                    upperBound = 1619;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 2745;
                    upperBound = 2844;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4395;
                    upperBound = 4544;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 6945;
                    upperBound = 7194;
                }
            }

            if (title == "Recruit")
            {
                if (colour == "(none)")
                {
                    lowerBound = 15;
                    upperBound = 19;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 240;
                    upperBound = 269;
                }
                if (colour == "Silver")
                {
                    lowerBound = 770;
                    upperBound = 819;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1620;
                    upperBound = 1694;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 2845;
                    upperBound = 2944;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4545;
                    upperBound = 4694;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 7195;
                    upperBound = 7444;
                }
            }

            if (title == "Scout")
            {
                if (colour == "(none)")
                {
                    lowerBound = 20;
                    upperBound = 29;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 270;
                    upperBound = 299;
                }
                if (colour == "Silver")
                {
                    lowerBound = 820;
                    upperBound = 869;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1695;
                    upperBound = 1769;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 2945;
                    upperBound = 3044;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4695;
                    upperBound = 4844;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 7445;
                    upperBound = 7694;
                }
            }

            if (title == "Soldier")
            {
                if (colour == "(none)")
                {
                    lowerBound = 30;
                    upperBound = 39;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 300;
                    upperBound = 329;
                }
                if (colour == "Silver")
                {
                    lowerBound = 870;
                    upperBound = 919;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1770;
                    upperBound = 1844;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3045;
                    upperBound = 3144;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4845;
                    upperBound = 4994;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 7695;
                    upperBound = 7944;
                }
            }

            if (title == "Squire")
            {
                if (colour == "(none)")
                {
                    lowerBound = 40;
                    upperBound = 49;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 330;
                    upperBound = 359;
                }
                if (colour == "Silver")
                {
                    lowerBound = 920;
                    upperBound = 969;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1845;
                    upperBound = 1919;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3145;
                    upperBound = 3244;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 4995;
                    upperBound = 5144;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 7945;
                    upperBound = 8914;
                }
            }

            if (title == "Footman")
            {
                if (colour == "(none)")
                {
                    lowerBound = 50;
                    upperBound = 59;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 360;
                    upperBound = 389;
                }
                if (colour == "Silver")
                {
                    lowerBound = 970;
                    upperBound = 1019;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1920;
                    upperBound = 1994;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3245;
                    upperBound = 3344;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 5145;
                    upperBound = 5294;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 8915;
                    upperBound = 8444;
                }
            }

            if (title == "Knight")
            {
                if (colour == "(none)")
                {
                    lowerBound = 60;
                    upperBound = 69;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 390;
                    upperBound = 419;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1020;
                    upperBound = 1069;
                }
                if (colour == "Gold")
                {
                    lowerBound = 1995;
                    upperBound = 2069;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3345;
                    upperBound = 3444;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 5295;
                    upperBound = 5444;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 8445;
                    upperBound = 8694;
                }
            }

            if (title == "Major")
            {
                if (colour == "(none)")
                {
                    lowerBound = 70;
                    upperBound = 79;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 420;
                    upperBound = 449;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1070;
                    upperBound = 1119;
                }
                if (colour == "Gold")
                {
                    lowerBound = 2070;
                    upperBound = 2144;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3445;
                    upperBound = 3544;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 5445;
                    upperBound = 5594;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 8695;
                    upperBound = 8944;
                }
            }

            if (title == "Colonel")
            {
                if (colour == "(none)")
                {
                    lowerBound = 80;
                    upperBound = 89;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 450;
                    upperBound = 479;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1120;
                    upperBound = 1169;
                }
                if (colour == "Gold")
                {
                    lowerBound = 2145;
                    upperBound = 2219;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3545;
                    upperBound = 3644;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 5595;
                    upperBound = 5744;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 8945;
                    upperBound = 9194;
                }
            }

            if (title == "General")
            {
                if (colour == "(none)")
                {
                    lowerBound = 90;
                    upperBound = 99;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 480;
                    upperBound = 509;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1170;
                    upperBound = 1219;
                }
                if (colour == "Gold")
                {
                    lowerBound = 2220;
                    upperBound = 2294;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3645;
                    upperBound = 3744;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 5745;
                    upperBound = 5894;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 9195;
                    upperBound = 9444;
                }
            }

            if (title == "Veteran")
            {
                if (colour == "(none)")
                {
                    lowerBound = 100;
                    upperBound = 109;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 510;
                    upperBound = 539;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1220;
                    upperBound = 1269;
                }
                if (colour == "Gold")
                {
                    lowerBound = 2295;
                    upperBound = 2369;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3745;
                    upperBound = 3844;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 5895;
                    upperBound = 6044;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 9445;
                    upperBound = 9694;
                }
            }

            if (title == "Champion")
            {
                if (colour == "(none)")
                {
                    lowerBound = 110;
                    upperBound = 119;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 540;
                    upperBound = 569;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1270;
                    upperBound = 1319;
                }
                if (colour == "Gold")
                {
                    lowerBound = 2370;
                    upperBound = 2444;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3845;
                    upperBound = 3944;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 6045;
                    upperBound = 6194;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 9695;
                    upperBound = 9944;
                }
            }

            if (title == "Legend")
            {
                if (colour == "(none)")
                {
                    lowerBound = 120;
                    upperBound = 149;
                }
                if (colour == "Bronze")
                {
                    lowerBound = 570;
                    upperBound = 619;
                }
                if (colour == "Silver")
                {
                    lowerBound = 1320;
                    upperBound = 1394;
                }
                if (colour == "Gold")
                {
                    lowerBound = 2445;
                    upperBound = 2544;
                }
                if (colour == "Platinum")
                {
                    lowerBound = 3945;
                    upperBound = 4094;
                }
                if (colour == "Mithril")
                {
                    lowerBound = 6195;
                    upperBound = 6444;
                }
                if (colour == "Diamond")
                {
                    lowerBound = 9945;
                    upperBound = 10000;
                }
            }

            return new int[] { lowerBound, upperBound };
        }
    }
}
