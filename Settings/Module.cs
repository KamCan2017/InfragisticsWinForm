using Common.Interfaces;
using Settings.Views;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Settings
{
    public class Module: IEmbeddedModule
    {
        public Module()
        {
            View = new SettingsView();
        }

        public string Name { get { return "Settings"; } }

        public UserControl View
        {
            get;

            private set;
        }

        public Image Logo 
        {
            get
            {
                var path = Path.GetFullPath("Images/settings.png");
                return Image.FromFile(path);
            }
        }
    }
}
