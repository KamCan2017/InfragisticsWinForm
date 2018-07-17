using Suppliers.Logic;
using System;
using System.Windows.Forms;

namespace Suppliers.Views
{
    public partial class SuppliersView : UserControl
    {
        private readonly SuppplierLogic supppliersLogic;

        public SuppliersView()
        {
            InitializeComponent();

            supppliersLogic = new Logic.SuppplierLogic();
        }

        private async void SuppliersView_Load(object sender, EventArgs e)
        {
            ultraGrid1.DataSource = await supppliersLogic.LoadSuppliers();            
        }       
    }
}
