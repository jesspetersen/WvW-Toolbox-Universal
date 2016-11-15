using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WvW_Toolbox.pages
{
    public partial class ResetTimerPage : ContentPage
    {

        public ResetTimerPage()
        {
            InitializeComponent();
            timerText.Text = utilities.TimerCalculator.GetTimeToReset(false);
        }

        private void localeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (localeSwitch != null)
            {
                if (localeSwitch.IsToggled)
                {
                    localeText.Text = "Europe";
                    timerText.Text = utilities.TimerCalculator.GetTimeToReset(true);
                }
                else
                {
                    localeText.Text = "North America";
                    timerText.Text = utilities.TimerCalculator.GetTimeToReset(false);
                }
            }
        }

        private void reloadButton_Clicked(object sender, EventArgs e)
        {
            if (localeSwitch.IsToggled)
            {
                localeText.Text = "Europe";
                timerText.Text = utilities.TimerCalculator.GetTimeToReset(true);
            }
            else
            {
                localeText.Text = "North America";
                timerText.Text = utilities.TimerCalculator.GetTimeToReset(false);
            }
        }
    }
}
