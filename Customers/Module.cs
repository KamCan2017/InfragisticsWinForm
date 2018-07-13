using Common.Interfaces;
using Customers.Views;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Customers
{
    public class Module: IEmbeddedModule
    {
        public string Name { get { return "Customers"; } }

        public UserControl View
        {
            get
            {
                return new CustomersView();
            }
        }

        public Image Logo
        {
            get
            {
                var path = Path.GetFullPath("Images/customers.png");
                return Image.FromFile(path);
            }
        }
    }
}
