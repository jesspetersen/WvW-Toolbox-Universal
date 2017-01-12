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
            if (Global.match != null)
                FillData(Global.match);
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
            }
            catch
            {
                App.Current.MainPage.DisplayAlert("Alert", "Unable to access GW2 server for match data. Please check your internet connection, firewall, and chosen server.", "OK");
            }
        }
	}
}
