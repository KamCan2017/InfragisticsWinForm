using Common.Interfaces;
using Suppliers.Views;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Suppliers
{
    public class Module: IEmbeddedModule
    {
        public string Name { get { return "Suppliers"; } }

        public UserControl View
        {
            get
            {
                return new SuppliersView();
            }
        }

        public Image Logo 
        {
            get
            {
                var path = Path.GetFullPath("Images/suppliers.png");
                return Image.FromFile(path);
            }
        }
    }
}
