using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WvW_Toolbox.pages
{
    public partial class SettingsPage : ContentPage
    {
        List<objects.World> worldList;

        public SettingsPage()
        {
            InitializeComponent();
            worldList = utilities.WorldSearchHelper.ListAllWorlds();

            if (worldList != null)
            {
                foreach (objects.World w in worldList)
                {
                    ServerSelectPicker.Items.Add(w.name);
                }
            }

            if (Application.Current.Properties.ContainsKey("Server"))
            {
                foreach (objects.World w in worldList)
                {
                    if (w.id == (string)Application.Current.Properties["Server"])
                        ServerSelectPicker.SelectedIndex = worldList.IndexOf(w);
                }
            }
        }

        public void ServerSelectPicker_SelectionChanged(object sender, EventArgs e)
        {
            Application.Current.Properties["Server"] = worldList[ServerSelectPicker.SelectedIndex].id;

            Application.Current.SavePropertiesAsync();
        }
    }
}
