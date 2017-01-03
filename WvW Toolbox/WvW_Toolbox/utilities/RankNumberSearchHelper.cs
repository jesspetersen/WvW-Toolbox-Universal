using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.utilities
{
    class RankNumberSearchHelper
    {

        public static string[] SearchRank(int rank)
        {
            int rankInt = rank;
            string currentColour, currentTitle = "", nextTitleNum = "", nextTitleName = "", nextRankNum = "", nextRankName = "";

            if (rankInt >= 1 && rankInt < 150)
                currentColour = "";
            else if (rankInt >= 150 && rankInt < 620)
                currentColour = "Bronze";
            else if (rankInt >= 620 && rankInt < 1395)
                currentColour = "Silver";
            else if (rankInt >= 1395 && rankInt < 2545)
                currentColour = "Gold";
            else if (rankInt >= 2545 && rankInt < 4095)
                currentColour = "Platinum";
            else if (rankInt >= 4095 && rankInt < 6445)
                currentColour = "Mithril";
            else
                currentColour = "Diamond";

            if (rankInt >= 1 && rankInt < 5 ^ rankInt >= 150 && rankInt < 180 ^ rankInt >= 620 && rankInt < 670 ^ rankInt >= 1395 && rankInt < 1470 ^ rankInt >= 2545 && rankInt < 2645 ^ rankInt >= 4095 && rankInt < 4245 ^ rankInt >= 6445 && rankInt < 6695)
            {
                currentTitle = "Invader";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(5 - rankInt);
                    nextTitleName = "Assaulter";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(180 - rankInt);
                    nextTitleName = "Bronze Assaulter";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(670 - rankInt);
                    nextTitleName = "Silver Assaulter";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1470 - rankInt);
                    nextTitleName = "Gold Assaulter";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(2645 - rankInt);
                    nextTitleName = "Platinum Assaulter";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(4245 - rankInt);
                    nextTitleName = "Mithril Assaulter";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(6695 - rankInt);
                    nextTitleName = "Diamond Assaulter.";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 5 && rankInt < 10 ^ rankInt >= 180 && rankInt < 210 ^ rankInt >= 670 && rankInt < 720 ^ rankInt >= 1470 && rankInt < 1545 ^ rankInt >= 2645 && rankInt < 2745 ^ rankInt >= 4245 && rankInt < 4395 ^ rankInt >= 6695 && rankInt < 6945)
            {
                currentTitle = "Assaulter";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(10 - rankInt);
                    nextTitleName = "Raider.";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(210 - rankInt);
                    nextTitleName = "Bronze Raider.";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(720 - rankInt);
                    nextTitleName = "Silver Raider";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1545 - rankInt);
                    nextTitleName = "Gold Raider";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(2745 - rankInt);
                    nextTitleName = "Platinum Raider";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(4395 - rankInt);
                    nextTitleName = "Mithril Raider";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(6945 - rankInt);
                    nextTitleName = "Diamond Raider";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 10 && rankInt < 15 ^ rankInt >= 210 && rankInt < 240 ^ rankInt >= 720 && rankInt < 770 ^ rankInt >= 1545 && rankInt < 1620 ^ rankInt >= 2745 && rankInt < 2845 ^ rankInt >= 4395 && rankInt < 4545 ^ rankInt >= 6945 && rankInt < 7195)
            {
                currentTitle = "Raider";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(15 - rankInt);
                    nextTitleName = "Recruit";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(240 - rankInt);
                    nextTitleName = "Bronze Recruit";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(770 - rankInt);
                    nextTitleName = "Silver Recruit";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1620 - rankInt);
                    nextTitleName = "Gold Recruit";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(2845 - rankInt);
                    nextTitleName = "Platinum Recruit";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(4545 - rankInt);
                    nextTitleName = "Mithril Recruit";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(7195 - rankInt);
                    nextTitleName = "Diamond Recruit";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 15 && rankInt < 20 ^ rankInt >= 240 && rankInt < 270 ^ rankInt >= 770 && rankInt < 820 ^ rankInt >= 1620 && rankInt < 1695 ^ rankInt >= 2845 && rankInt < 2945 ^ rankInt >= 4545 && rankInt < 4695 ^ rankInt >= 7195 && rankInt < 7445)
            {
                currentTitle = "Recruit";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(20 - rankInt);
                    nextTitleName = "Scout";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(270 - rankInt);
                    nextTitleName = "Bronze Scout";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(820 - rankInt);
                    nextTitleName = "Silver Scout";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1695 - rankInt);
                    nextTitleName = "Gold Scout";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(2945 - rankInt);
                    nextTitleName = "Platinum Scout";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(4695 - rankInt);
                    nextTitleName = "Mithril Scout";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(7445 - rankInt);
                    nextTitleName = "Diamond Scout";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 20 && rankInt < 30 ^ rankInt >= 270 && rankInt < 300 ^ rankInt >= 820 && rankInt < 870 ^ rankInt >= 1695 && rankInt < 1770 ^ rankInt >= 2945 && rankInt < 3045 ^ rankInt >= 4695 && rankInt < 4845 ^ rankInt >= 7445 && rankInt < 7695)
            {
                currentTitle = "Scout";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(30 - rankInt);
                    nextTitleName = "Soldier";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(300 - rankInt);
                    nextTitleName = "Bronze Soldier";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(870 - rankInt);
                    nextTitleName = "Silver Soldier";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1770 - rankInt);
                    nextTitleName = "Gold Soldier";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3045 - rankInt);
                    nextTitleName = "Platinum Soldier";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(4845 - rankInt);
                    nextTitleName = "Mithril Soldier";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(7695 - rankInt);
                    nextTitleName = "Diamond Soldier";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 30 && rankInt < 40 ^ rankInt >= 300 && rankInt < 330 ^ rankInt >= 870 && rankInt < 920 ^ rankInt >= 1770 && rankInt < 1845 ^ rankInt >= 3045 && rankInt < 3145 ^ rankInt >= 4845 && rankInt < 4995 ^ rankInt >= 7695 && rankInt < 7945)
            {
                currentTitle = "Soldier";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(40 - rankInt);
                    nextTitleName = "Squire";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(330 - rankInt);
                    nextTitleName = "Bronze Squire";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(920 - rankInt);
                    nextTitleName = "Silver Squire";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1845 - rankInt);
                    nextTitleName = "Gold Squire";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3145 - rankInt);
                    nextTitleName = "Platinum Squire";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(4995 - rankInt);
                    nextTitleName = "Mithril Squire";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(7945 - rankInt);
                    nextTitleName = "Diamond Squire";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 40 && rankInt < 50 ^ rankInt >= 330 && rankInt < 360 ^ rankInt >= 920 && rankInt < 970 ^ rankInt >= 1845 && rankInt < 1920 ^ rankInt >= 3145 && rankInt < 3245 ^ rankInt >= 4995 && rankInt < 5145 ^ rankInt >= 7945 && rankInt < 8195)
            {
                currentTitle = "Squire";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(50 - rankInt);
                    nextTitleName = "Footman";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(360 - rankInt);
                    nextTitleName = "Bronze Footman";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(970 - rankInt);
                    nextTitleName = "Silver Footman";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1920 - rankInt);
                    nextTitleName = "Gold Footman";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3245 - rankInt);
                    nextTitleName = "Platinum Footman";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(5145 - rankInt);
                    nextTitleName = "Mithril Footman";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(8195 - rankInt);
                    nextTitleName = "Diamond Footman";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 50 && rankInt < 60 ^ rankInt >= 360 && rankInt < 390 ^ rankInt >= 970 && rankInt < 1020 ^ rankInt >= 1920 && rankInt < 1995 ^ rankInt >= 3245 && rankInt < 3345 ^ rankInt >= 5145 && rankInt < 5295 ^ rankInt >= 8195 && rankInt < 8445)
            {
                currentTitle = "Footman";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(60 - rankInt);
                    nextTitleName = "Knight";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(390 - rankInt);
                    nextTitleName = "Bronze Knight";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1020 - rankInt);
                    nextTitleName = "Silver Knight";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(1995 - rankInt);
                    nextTitleName = "Gold Knight";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3345 - rankInt);
                    nextTitleName = "Platinum Knight";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(5295 - rankInt);
                    nextTitleName = "Mithril Knight";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(8445 - rankInt);
                    nextTitleName = "Diamond Knight";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 60 && rankInt < 70 ^ rankInt >= 390 && rankInt < 420 ^ rankInt >= 1020 && rankInt < 1070 ^ rankInt >= 1995 && rankInt < 2070 ^ rankInt >= 3345 && rankInt < 3445 ^ rankInt >= 5295 && rankInt < 5445 ^ rankInt > 8445 && rankInt < 8695)
            {
                currentTitle = "Knight";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(70 - rankInt);
                    nextTitleName = "Major";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(420 - rankInt);
                    nextTitleName = "Bronze Major";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1070 - rankInt);
                    nextTitleName = "Silver Major";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2070 - rankInt);
                    nextTitleName = "Gold major";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3445 - rankInt);
                    nextTitleName = "Platinum Major";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(5445 - rankInt);
                    nextTitleName = "Mithril Major";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(8695 - rankInt);
                    nextTitleName = "Diamond Major";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 70 && rankInt < 80 ^ rankInt >= 420 && rankInt < 450 ^ rankInt >= 1070 && rankInt < 1120 ^ rankInt >= 2070 && rankInt < 2145 ^ rankInt >= 3445 && rankInt < 3545 ^ rankInt >= 5445 && rankInt < 5595 ^ rankInt >= 8695 && rankInt < 8945)
            {
                currentTitle = "Major";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(80 - rankInt);
                    nextTitleName = "Colonel";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(450 - rankInt);
                    nextTitleName = "Bronze Colonel";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1120 - rankInt);
                    nextTitleName = "Silver Colonel";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2145 - rankInt);
                    nextTitleName = "Gold Colonel";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3545 - rankInt);
                    nextTitleName = "Platinum Colonel";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(5595 - rankInt);
                    nextTitleName = "Mithril Colonel";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(8945 - rankInt);
                    nextTitleName = "Diamond Colonel";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 80 && rankInt < 90 ^ rankInt >= 450 && rankInt < 480 ^ rankInt >= 1120 && rankInt < 1170 ^ rankInt >= 2145 && rankInt < 2220 ^ rankInt >= 3545 && rankInt < 3645 ^ rankInt >= 5595 && rankInt < 5745 ^ rankInt >= 8945 && rankInt < 9195)
            {
                currentTitle = "Colonel";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(90 - rankInt);
                    nextTitleName = "General";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(480 - rankInt);
                    nextTitleName = "Bronze General";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1170 - rankInt);
                    nextTitleName = "Silver General";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2220 - rankInt);
                    nextTitleName = "Gold General";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3645 - rankInt);
                    nextTitleName = "Platinum General";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(5745 - rankInt);
                    nextTitleName = "Mithril General";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(9195 - rankInt);
                    nextTitleName = "Diamond General";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 90 && rankInt < 100 ^ rankInt >= 480 && rankInt < 510 ^ rankInt >= 1170 && rankInt < 1220 ^ rankInt >= 2220 && rankInt < 2295 ^ rankInt >= 3645 && rankInt < 3745 ^ rankInt >= 5745 && rankInt < 5895 ^ rankInt >= 9195 && rankInt < 9445)
            {
                currentTitle = "General";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(100 - rankInt);
                    nextTitleName = "Veteran";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(510 - rankInt);
                    nextTitleName = "Bronze Veteran";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1220 - rankInt);
                    nextTitleName = "Silver Veteran";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2295 - rankInt);
                    nextTitleName = "Gold Veteran";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3745 - rankInt);
                    nextTitleName = "Platinum Veteran";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(5895 - rankInt);
                    nextTitleName = "Mithril Veteran";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(9445 - rankInt);
                    nextTitleName = "Diamond Veteran";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 100 && rankInt < 110 ^ rankInt >= 510 && rankInt < 540 ^ rankInt >= 1220 && rankInt < 1270 ^ rankInt >= 2295 && rankInt < 2370 ^ rankInt >= 3745 && rankInt < 3845 ^ rankInt >= 5895 && rankInt < 6045 ^ rankInt >= 9445 && rankInt < 9695)
            {
                currentTitle = "Veteran";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(110 - rankInt);
                    nextTitleName = "Champion";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(540 - rankInt);
                    nextTitleName = "Bronze Champion";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1270 - rankInt);
                    nextTitleName = "Silver Champion";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2370 - rankInt);
                    nextTitleName = "Gold Champion";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3845 - rankInt);
                    nextTitleName = "Platinum Champion";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(6045 - rankInt);
                    nextTitleName = "Mithril Champion";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = Convert.ToString(9695 - rankInt);
                    nextTitleName = "Diamond Champion";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 110 && rankInt < 120 ^ rankInt >= 540 && rankInt < 570 ^ rankInt >= 1270 && rankInt < 1320 ^ rankInt >= 2370 && rankInt < 2445 ^ rankInt >= 3845 && rankInt < 3945 ^ rankInt >= 6045 && rankInt < 6195 ^ rankInt >= 9695 && rankInt < 9445)
            {
                currentTitle = "Champion";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(120 - rankInt);
                    nextTitleName = "Legend";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(570 - rankInt);
                    nextTitleName = "Bronze Legend";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1320 - rankInt);
                    nextTitleName = "Silver Legend";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2445 - rankInt);
                    nextTitleName = "Gold Legend";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(3945 - rankInt);
                    nextTitleName = "Platinum Legend";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(6195 - rankInt);
                    nextTitleName = "Mithril Legend";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = "0";
                    nextTitleName = "Diamond Legend";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }
            else if (rankInt >= 120 && rankInt < 150 ^ rankInt >= 570 && rankInt < 620 ^ rankInt >= 1320 && rankInt < 1395 ^ rankInt >= 2445 && rankInt < 2545 ^ rankInt >= 3945 && rankInt < 4095 ^ rankInt >= 6195 && rankInt < 6445 ^ rankInt >= 9445)
            {
                currentTitle = "Legend";
                if (currentColour == "")
                {
                    nextTitleNum = Convert.ToString(150 - rankInt);
                    nextTitleName = "Bronze Invader";
                    nextRankNum = Convert.ToString(150 - rankInt);
                    nextRankName = "Bronze";
                }
                if (currentColour == "Bronze")
                {
                    nextTitleNum = Convert.ToString(620 - rankInt);
                    nextTitleName = "Silver Invader";
                    nextRankNum = Convert.ToString(620 - rankInt);
                    nextRankName = "Silver";
                }
                if (currentColour == "Silver")
                {
                    nextTitleNum = Convert.ToString(1395 - rankInt);
                    nextTitleName = "Gold Invader";
                    nextRankNum = Convert.ToString(1395 - rankInt);
                    nextRankName = "Gold";
                }
                if (currentColour == "Gold")
                {
                    nextTitleNum = Convert.ToString(2545 - rankInt);
                    nextTitleName = "Platinum Invader";
                    nextRankNum = Convert.ToString(2545 - rankInt);
                    nextRankName = "Platinum";
                }
                if (currentColour == "Platinum")
                {
                    nextTitleNum = Convert.ToString(4095 - rankInt);
                    nextTitleName = "Mithril Invader";
                    nextRankNum = Convert.ToString(4095 - rankInt);
                    nextRankName = "Mithril";
                }
                if (currentColour == "Mithril")
                {
                    nextTitleNum = Convert.ToString(6445 - rankInt);
                    nextTitleName = "Diamond Invader";
                    nextRankNum = Convert.ToString(6445 - rankInt);
                    nextRankName = "Diamond";
                }
                if (currentColour == "Diamond")
                {
                    nextTitleNum = "0";
                    nextTitleName = "(no more titles)";
                    nextRankNum = "0";
                    nextRankName = "(no more colours)";
                }
            }

            return new string[] { currentColour, currentTitle, nextTitleName, nextTitleNum, nextRankName, nextRankNum };
        }
    }
}
