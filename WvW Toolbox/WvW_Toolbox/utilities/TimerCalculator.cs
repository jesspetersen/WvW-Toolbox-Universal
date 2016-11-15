using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace WvW_Toolbox.utilities
{
    class TimerCalculator
    {
        public static string GetTimeToReset(bool euLocale)
        {
            // NOTE: Monday = 1; Tuesday = 2; Wednesday = 3; Thursday = 4; Friday = 5; Saturday = 6; Sunday = 7
            //Get values
            Instant now = SystemClock.Instance.Now;
            ZonedDateTime nowUTC = now.InUtc();

            int currentDay = nowUTC.DayOfWeek;
            int currentHour = nowUTC.Hour;
            int currentMin = nowUTC.Minute;

            int days = 0;
            int hours = 0;
            int mins = 0;

            if (euLocale)
            {
                //For EU
                //Target time is Friday @ 18.00

                //Calculate Days
                switch (currentDay)
                {
                    case 1:
                        days = 4;
                        break;

                    case 2:
                        days = 3;
                        break;

                    case 3:
                        days = 2;
                        break;

                    case 4:
                        days = 1;
                        break;

                    case 5:
                        if (currentHour >= 18)
                            days = 7;
                        else
                            days = 0;
                        break;

                    case 6:
                        days = 6;
                        break;

                    case 7:
                        days = 5;
                        break;
                }

                //Calculate Hours
                if (currentHour <= 18)
                    hours = 18 - currentHour;
                else
                {
                    hours = 41 - currentHour;
                    days = days - 1;
                }
            }
            else
            {
                //For NA
                //Target time is Saturday @ 02.00

                //Calculate Days
                switch (currentDay)
                {
                    case 1:
                        days = 5;
                        break;

                    case 2:
                        days = 4;
                        break;

                    case 3:
                        days = 3;
                        break;

                    case 4:
                        days = 2;
                        break;

                    case 5:
                        days = 1;
                        break;

                    case 6:
                        if (currentHour >= 2)
                            days = 7;
                        else
                            days = 0;
                        break;

                    case 7:
                        days = 6;
                        break;
                }

                //Calculate Hours
                if (currentHour <= 2)
                    hours = 2 - currentHour;
                else
                {
                    hours = 25 - currentHour;
                    days = days - 1;
                }
            }
            //Calculate Minutes
            mins = 60 - currentMin;
            if (currentMin != 60)
                hours = hours - 1;

            return "" + days + "D " + hours + "H " + mins + "M";
        }
    }
}
