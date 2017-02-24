﻿using Android.Util;
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
                for (int i = 0; i < match.red.worldIDs.Length; i++)
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

            int[] objectiveCount = utilities.ObjectiveSorter.SortObjectivesForCount();

            RedCastlesLabel.Text = "" + objectiveCount[0];
            RedKeepsLabel.Text = "" + objectiveCount[1];
            RedTowersLabel.Text = "" + objectiveCount[2];
            RedCampsLabel.Text = "" + objectiveCount[3];

            GreenCastlesLabel.Text = "" + objectiveCount[4];
            GreenKeepsLabel.Text = "" + objectiveCount[5];
            GreenTowersLabel.Text = "" + objectiveCount[6];
            GreenCampsLabel.Text = "" + objectiveCount[7];

            BlueCastlesLabel.Text = "" + objectiveCount[8];
            BlueKeepsLabel.Text = "" + objectiveCount[9];
            BlueTowersLabel.Text = "" + objectiveCount[10];
            BlueCampsLabel.Text = "" + objectiveCount[11];

            int RedCastlesIterator = 0;
            int RedKeepsIterator = 0;
            int RedTowersIterator = 0;
            int RedCampsIterator = 0;

            int GreenCastlesIterator = 0;
            int GreenKeepsIterator = 0;
            int GreenTowersIterator = 0;
            int GreenCampsIterator = 0;

            int BlueCastlesIterator = 0;
            int BlueKeepsIterator = 0;
            int BlueTowersIterator = 0;
            int BlueCampsIterator = 0;

            for (int i = 0; i < objectiveCount[0]; i++)
                RedCastlesGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[1]; i++)
                RedKeepsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[2]; i++)
                RedTowersGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[3]; i++)
                RedCampsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });

            for (int i = 0; i < objectiveCount[4]; i++)
                GreenCastlesGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[5]; i++)
                GreenKeepsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[6]; i++)
                GreenTowersGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[7]; i++)
                GreenCampsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });

            for (int i = 0; i < objectiveCount[8]; i++)
                BlueCastlesGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[9]; i++)
                BlueKeepsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[10]; i++)
                BlueTowersGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            for (int i = 0; i < objectiveCount[11]; i++)
                BlueCampsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });

            //This line is the problem!!!
            utilities.ObjectiveSorter.SortObjectivesByMap();

            foreach (objects.Objective o in Global.allObjectives)
            {
                if (o.owner == "Red")
                {
                    if (o.type == "Castle")
                    {
                        RedCastlesGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, RedCastlesIterator);
                        RedCastlesGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, RedCastlesIterator);
                        RedCastlesIterator++;
                    }
                    else if (o.type == "Keep")
                    {
                        RedKeepsGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, RedKeepsIterator);
                        RedKeepsGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, RedKeepsIterator);
                        RedKeepsIterator++;
                    }
                    else if (o.type == "Tower")
                    {
                        RedTowersGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, RedTowersIterator);
                        RedTowersGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, RedTowersIterator);
                        RedTowersIterator++;
                    }
                    else if (o.type == "Camp")
                    {
                        RedCampsGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, RedCampsIterator);
                        RedCampsGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, RedCampsIterator);
                        RedCampsIterator++;
                    }
                }

                if (o.owner == "Green")
                {
                    if (o.type == "Castle")
                    {
                        GreenCastlesGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, GreenCastlesIterator);
                        GreenCastlesGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, GreenCastlesIterator);
                        GreenCastlesIterator++;
                    }
                    else if (o.type == "Keep")
                    {
                        GreenKeepsGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, GreenKeepsIterator);
                        GreenKeepsGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, GreenKeepsIterator);
                        GreenKeepsIterator++;
                    }
                    else if (o.type == "Tower")
                    {
                        GreenTowersGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, GreenTowersIterator);
                        GreenTowersGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, GreenTowersIterator);
                        GreenTowersIterator++;
                    }
                    else if (o.type == "Camp")
                    {
                        GreenCampsGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, GreenCampsIterator);
                        GreenCampsGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, GreenCampsIterator);
                        GreenCampsIterator++;
                    }
                }

                if (o.owner == "Blue")
                {
                    if (o.type == "Castle")
                    {
                        BlueCastlesGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, BlueCastlesIterator);
                        BlueCastlesGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, BlueCastlesIterator);
                        BlueCastlesIterator++;
                    }
                    else if (o.type == "Keep")
                    {
                        BlueKeepsGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, BlueKeepsIterator);
                        BlueKeepsGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, BlueKeepsIterator);
                        BlueKeepsIterator++;
                    }
                    else if (o.type == "Tower")
                    {
                        BlueTowersGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, BlueTowersIterator);
                        BlueTowersGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, BlueTowersIterator);
                        BlueTowersIterator++;
                    }
                    else if (o.type == "Camp")
                    {
                        BlueCampsGrid.Children.Add(new Label { Text = o.map, TextColor = Color.FromHex(o.mapColour), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, BlueCampsIterator);
                        BlueCampsGrid.Children.Add(new Label { Text = o.name, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, BlueCampsIterator);
                        BlueCampsIterator++;
                    }
                }
            }
        }

        public void RedExpand()
        {
            if (RedExpandSection.IsVisible == false)
            {
                if (GreenExpandSection.IsVisible)
                    GreenExpandSection.IsVisible = false;

                if (BlueExpandSection.IsVisible)
                    BlueExpandSection.IsVisible = false;

                RedExpandSection.IsVisible = true;
            }
            else
                RedExpandSection.IsVisible = false;
        }

        public void GreenExpand()
        {
            if (GreenExpandSection.IsVisible == false)
            {
                if (BlueExpandSection.IsVisible)
                    BlueExpandSection.IsVisible = false;

                if (RedExpandSection.IsVisible)
                    RedExpandSection.IsVisible = false;

                GreenExpandSection.IsVisible = true;
            }
            else
                GreenExpandSection.IsVisible = false;

        }

        public void BlueExpand()
        {
            if (BlueExpandSection.IsVisible == false)
            {
                if (RedExpandSection.IsVisible)
                    RedExpandSection.IsVisible = false;

                if (GreenExpandSection.IsVisible)
                    GreenExpandSection.IsVisible = false;

                if (BlueExpandSection.IsVisible == false)
                    BlueExpandSection.IsVisible = true;
            }
            else
                BlueExpandSection.IsVisible = false;

        }

        public void RedCastleExpand()
        {
            if (!RedCastlesDetail.IsVisible)
                RedCastlesDetail.IsVisible = true;
            else
                RedCastlesDetail.IsVisible = false;
        }

        public void RedKeepExpand()
        {
            if (!RedKeepsDetail.IsVisible)
                RedKeepsDetail.IsVisible = true;
            else
                RedKeepsDetail.IsVisible = false;
        }

        public void RedTowerExpand()
        {
            if (!RedTowersDetail.IsVisible)
                RedTowersDetail.IsVisible = true;
            else
                RedTowersDetail.IsVisible = false;
        }

        public void RedCampExpand()
        {
            if (!RedCampsDetail.IsVisible)
                RedCampsDetail.IsVisible = true;
            else
                RedCampsDetail.IsVisible = false;
        }

        public void GreenCastleExpand()
        {
            if (!GreenCastlesDetail.IsVisible)
                GreenCastlesDetail.IsVisible = true;
            else
                GreenCastlesDetail.IsVisible = false;
        }

        public void GreenKeepExpand()
        {
            if (!GreenKeepsDetail.IsVisible)
                GreenKeepsDetail.IsVisible = true;
            else
                GreenKeepsDetail.IsVisible = false;
        }

        public void GreenTowerExpand()
        {
            if (!GreenTowersDetail.IsVisible)
                GreenTowersDetail.IsVisible = true;
            else
                GreenTowersDetail.IsVisible = false;
        }

        public void GreenCampExpand()
        {
            if (!GreenCampsDetail.IsVisible)
                GreenCampsDetail.IsVisible = true;
            else
                GreenCampsDetail.IsVisible = false;
        }

        public void BlueCastleExpand()
        {
            if (!BlueCastlesDetail.IsVisible)
                BlueCastlesDetail.IsVisible = true;
            else
                BlueCastlesDetail.IsVisible = false;
        }

        public void BlueKeepExpand()
        {
            if (!BlueKeepsDetail.IsVisible)
                BlueKeepsDetail.IsVisible = true;
            else
                BlueKeepsDetail.IsVisible = false;
        }

        public void BlueTowerExpand()
        {
            if (!BlueTowersDetail.IsVisible)
                BlueTowersDetail.IsVisible = true;
            else
                BlueTowersDetail.IsVisible = false;
        }

        public void BlueCampExpand()
        {
            if (!BlueCampsDetail.IsVisible)
                BlueCampsDetail.IsVisible = true;
            else
                BlueCampsDetail.IsVisible = false;
        }

        private void RedWorldButton_Clicked(object sender, EventArgs e) { RedExpand(); }

        private void GreenWorldButton_Clicked(object sender, EventArgs e) { GreenExpand(); }

        private void BlueWorldButton_Clicked(object sender, EventArgs e) { BlueExpand(); }

        private void RedCastle_Clicked(object sender, EventArgs e) { RedCastleExpand(); }

        private void RedKeep_Clicked(object sender, EventArgs e) { RedKeepExpand(); }

        private void RedTower_Clicked(object sender, EventArgs e) { RedTowerExpand(); }

        private void RedCamp_Clicked(object sender, EventArgs e) { RedCampExpand(); }

        private void GreenCastle_Clicked(object sender, EventArgs e) { GreenCastleExpand(); }

        private void GreenKeep_Clicked(object sender, EventArgs e) { GreenKeepExpand(); }

        private void GreenTower_Clicked(object sender, EventArgs e) { GreenTowerExpand(); }

        private void GreenCamp_Clicked(object sender, EventArgs e) { GreenCampExpand(); }

        private void BlueCastle_Clicked(object sender, EventArgs e) { BlueCastleExpand(); }

        private void BlueKeep_Clicked(object sender, EventArgs e) { BlueKeepExpand(); }

        private void BlueTower_Clicked(object sender, EventArgs e) { BlueTowerExpand(); }

        private void BlueCamp_Clicked(object sender, EventArgs e) { BlueCampExpand(); }
    }
}
