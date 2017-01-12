using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WvW_Toolbox
{
    public class App : Application
    {
        public App()
        {
            //http://www.kymphillpotts.com/common-ui-patterns-in-xamarin-forms-part-2-tabbed-pages/
            // tabbed page 
            var tabContainer = new TabbedPage();
            tabContainer.Children.Add(new pages.ResetTimerPage() { Title = "Next Match" });
            tabContainer.Children.Add(new pages.RankCalcPage() { Title = "Ranks" });
            tabContainer.Children.Add(new pages.MatchMonitorPage() { Title = "Match" });
            tabContainer.Children.Add(new pages.SettingsPage() { Title = "Settings" });

            // The root page of your application
            MainPage = tabContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
