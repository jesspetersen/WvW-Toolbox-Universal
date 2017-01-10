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
        }
    }
}
