using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WvW_Toolbox.pages
{
    //REMEMBER TO CHECK THAT A SERVER HAS BEEN CHOSEN BEFORE RUNNING MATCH HELPER

	public partial class MatchMonitorPage : ContentPage
	{
		public MatchMonitorPage ()
		{
			InitializeComponent ();
		}

        public void Reload_Clicked(object sender, EventArgs e)
        {
            FillData(Global.match);
        }

        public void FillData(objects.Match match)
        {
            try
            {
                RedWorldButton.Text = utilities.WorldSearchHelper.FindWorldById(Convert.ToInt32(match.red.mainWorldID)).name;
                BlueWorldButton.Text = utilities.WorldSearchHelper.FindWorldById(Convert.ToInt32(match.blue.mainWorldID)).name;
                GreenWorldButton.Text = utilities.WorldSearchHelper.FindWorldById(Convert.ToInt32(match.green.mainWorldID)).name;

                RedWorldGlanceText.Text = "POINTS: " + match.red.points + " | KDR: " + Math.Round(Convert.ToDouble(match.red.kills) / Convert.ToDouble(match.red.deaths), 2);
                BlueWorldGlanceText.Text = "POINTS: " + match.blue.points + " | KDR: " + Math.Round(Convert.ToDouble(match.blue.kills) / Convert.ToDouble(match.blue.deaths), 2);
                GreenWorldGlanceText.Text = "POINTS: " + match.green.points + " | KDR: " + Math.Round(Convert.ToDouble(match.green.kills) / Convert.ToDouble(match.green.deaths), 2);

                PreparePage(match);

            }
            catch
            {
                App.Current.MainPage.DisplayAlert("Alert", "Unable to access GW2 server for match data. Please check your internet connection, firewall, and chosen server.", "OK");
            }
        }

        public void PreparePage(objects.Match match)
        {
            if (Application.Current.Properties.ContainsKey("Server"))
            {
                if (match.red.worldIDs.Contains(Application.Current.Properties["Server"]))
                    RedExpand();

                if (match.green.worldIDs.Contains(Application.Current.Properties["Server"]))
                    GreenExpand();

                if (match.blue.worldIDs.Contains(Application.Current.Properties["Server"]))
                    BlueExpand();
            }

            if (RedWorldsLabel.Text == "Worlds in this Team:")
            {
                for (int i = 0; i <match.red.worldIDs.Length; i++)
                {
                    RedWorldsLabel.Text += "\n" + utilities.WorldSearchHelper.FindWorldById(Convert.ToInt32(match.red.worldIDs[i])).name;
                }

                for (int i = 0; i < match.blue.worldIDs.Length; i++)
                {
                    BlueWorldsLabel.Text += "\n" + utilities.WorldSearchHelper.FindWorldById(Convert.ToInt32(match.blue.worldIDs[i])).name;
                }

                for (int i = 0; i < match.green.worldIDs.Length; i++)
                {
                    GreenWorldsLabel.Text += "\n" + utilities.WorldSearchHelper.FindWorldById(Convert.ToInt32(match.green.worldIDs[i])).name;
                }
            }

            
        }

        public void RedExpand()
        {
            if (GreenExpandSection.IsVisible)
                GreenExpandSection.IsVisible = false;

            if (BlueExpandSection.IsVisible)
                BlueExpandSection.IsVisible = false;

            if (RedExpandSection.IsVisible == false)
                RedExpandSection.IsVisible = true;
        }

        public void GreenExpand()
        {
            if (BlueExpandSection.IsVisible)
                BlueExpandSection.IsVisible = false;

            if (RedExpandSection.IsVisible)
                RedExpandSection.IsVisible = false;

            if (GreenExpandSection.IsVisible == false)
                GreenExpandSection.IsVisible = true;
        }

        public void BlueExpand()
        {
            if (RedExpandSection.IsVisible)
                RedExpandSection.IsVisible = false;

            if (GreenExpandSection.IsVisible)
                GreenExpandSection.IsVisible = false;

            if (BlueExpandSection.IsVisible == false)
                BlueExpandSection.IsVisible = true;
        }

        private void RedWorldButton_Clicked(object sender, EventArgs e) { RedExpand(); }

        private void GreenWorldButton_Clicked(object sender, EventArgs e) { GreenExpand(); }

        private void BlueWorldButton_Clicked(object sender, EventArgs e) { BlueExpand(); }

    }
}
