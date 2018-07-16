using Common.Interfaces;
using Infragistics.Win.UltraWinTabControl;
using System.Drawing;
using System.Windows.Forms;
using WinFormsMod.Logic;

namespace WinFormsMod
{
    public partial class MainForm : Form
    {

        private MainFormLogic _formLogic;

        public MainForm()
        {
            InitializeComponent();
            Icon = new Icon("buying.ico");

            _formLogic = new MainFormLogic();

            ultraTabControl1.SelectedTabChanged += UltraTabControl1_SelectedTabChanged;
        }

        private void UltraTabControl1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
        {
            _formLogic.ChangeCaptionOfSelectedTab(e);
        }

        public void AddModule(IEmbeddedModule module)
        {
            _formLogic.AddModule(module, this);            
        }
    }
}
