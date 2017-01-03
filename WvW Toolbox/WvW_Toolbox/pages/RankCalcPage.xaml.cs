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
    }
}
