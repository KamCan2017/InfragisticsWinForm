using Common.Interfaces;
using Settings.Views;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Settings
{
    public class Module: IEmbeddedModule
    {
        public string Name { get { return "Settings"; } }

        public UserControl View
        {
            get
            {
                return new SettingsView();
            }
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
