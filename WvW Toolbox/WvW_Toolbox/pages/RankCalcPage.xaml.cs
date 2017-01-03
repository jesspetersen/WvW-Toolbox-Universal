using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WvW_Toolbox.pages
{
    public partial class RankCalcPage : ContentPage
    {
        //REMEMBER IF STATEMENT TO PREVENT LETTER VALUES GETTING THROUGH TO RANKNUMBERSEARCHHELPER
        string[] colours = new string[] { "(none)", "Bronze", "Silver", "Gold", "Platinum", "Mithril", "Diamond" };
        string[] titles = new string[] { "Invader", "Assaulter", "Raider", "Recruit", "Scout", "Soldier", "Squire", "Footman", "Knight", "Major", "Colonel", "General", "Veteran", "Champion", "Legend" };

        public RankCalcPage()
        {
            //Set up UI
            InitializeComponent();
            RankNameSection.IsVisible = false;

            //Set up Picker content

            foreach (string s in colours)
            {
                RankNameSearchColour.Items.Add(s);
            }
            RankNameSearchColour.SelectedIndex = 0;

            foreach (string s in titles)
            {
                RankNameSearchTitle.Items.Add(s);
            }
            RankNameSearchTitle.SelectedIndex = 0;

        }

        private void RankNumberButton_Clicked(object sender, EventArgs e)
        {
            if (RankNameSection.IsVisible)
                RankNameSection.IsVisible = false;

            if (!RankNumberSection.IsVisible)
                RankNumberSection.IsVisible = true;

            if (RankNameButton.BackgroundColor == Color.Red)
                RankNameButton.BackgroundColor = Color.Gray;

            if (RankNumberButton.BackgroundColor != Color.Red)
                RankNumberButton.BackgroundColor = Color.Red;
        }

        private void RankNameButton_Clicked(object sender, EventArgs e)
        {
            if (RankNumberSection.IsVisible)
                RankNumberSection.IsVisible = false;

            if (!RankNameSection.IsVisible)
                RankNameSection.IsVisible = true;

            if (RankNumberButton.BackgroundColor == Color.Red)
                RankNumberButton.BackgroundColor = Color.Gray;

            if (RankNameButton.BackgroundColor != Color.Red)
                RankNameButton.BackgroundColor = Color.Red;
        }

        private void RankNumberSearchButton_Clicked(object sender, EventArgs e)
        {
            string input = RankNumberEntry.Text;
            int rank;
            if (input != null && Int32.TryParse(input, out rank))
            {
                string[] rankInfo = utilities.RankNumberSearchHelper.SearchRank(rank);
                RankNumberSearchRankInfo.Text = "Current rank is " + rankInfo[0] + " " + rankInfo[1] + "\nNext title is " + rankInfo[2] + " in " + rankInfo[3] + "\nNext colour is " + rankInfo[4] + " in " + rankInfo[5];
            }
            else
            {
                DisplayAlert("Problem!", "Please enter a valid rank number", "OK");
            }
        }

        private void RankNameSearchButton_Clicked(object sender, EventArgs e)
        {
            string colour = colours[RankNameSearchColour.SelectedIndex];
            string title = titles[RankNameSearchTitle.SelectedIndex];

            int[] rankConstraints = utilities.RankNameSearchHelper.SearchRank(colour, title);
            RankNameSearchRankInfo.Text = "The selected rank has a level of between " + rankConstraints[0] + " and " + rankConstraints[1];
        }
    }
}