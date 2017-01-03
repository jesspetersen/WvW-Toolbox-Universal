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

        public RankCalcPage()
        {
            InitializeComponent();
            RankNameSection.IsVisible = false;
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
    }
}