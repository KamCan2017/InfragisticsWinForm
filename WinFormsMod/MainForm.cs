using Common.Interfaces;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinTabControl;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsMod
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddModule(IEmbeddedModule module)
        {
            if (module == null)
                return;  
            
            //Add a new tabpage for the module
            var tab = new UltraTab();            
            UltraTabPageControl tabControl = new UltraTabPageControl();
            tab.TabPage = tabControl;
            tab.Text = module.Name;
            tab.Key = module.Name;
            tab.Active = true;


            var pnl = new Panel();
            pnl.Controls.Add(module.View);
            module.View.Dock = DockStyle.Fill;
            tabControl.Controls.Add(pnl);
            pnl.Dock = DockStyle.Fill;

            ultraTabControl1.Tabs.AddRange(new UltraTab[] { tab });
            ultraTabControl1.Controls.Add(tabControl);

            //Add a new button in home page for the module            
            var tile = new UltraTile(module.Name);
            tile.Settings.Appearance.BackColor = Color.Lavender;
            tile.MaximumSize = new Size(300, 200);
            
            var pictureBox = new PictureBox() { Image = module.Logo, SizeMode = PictureBoxSizeMode.CenterImage };
            tile.Control = pictureBox;
            pictureBox.Dock = DockStyle.Fill;
            tile.Control.Dock = DockStyle.Fill;
            tile.Control.Click += (sender, args) =>
            {
                tab.Selected = true;
            };
            ultraTilePanel1.Tiles.Add(tile);           
        }
    }
}
