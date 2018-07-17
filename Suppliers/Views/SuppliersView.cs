using Common.Dtos;
using Suppliers.Logic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suppliers.Views
{
    public partial class SuppliersView : UserControl
    {
        private readonly SuppplierLogic _supppliersLogic;

        public SuppliersView()
        {
            InitializeComponent();

            _supppliersLogic = new SuppplierLogic();
        }

        private async Task LoadData()
        {
            ultraGrid1.DataSource = await _supppliersLogic.LoadSuppliers();
        }

        private async void SuppliersView_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void reloadButton_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow == null)
                return;

            var dto = ultraGrid1.ActiveRow.ListObject as SupplierDto;
            if (ultraGrid1.ActiveRow.Delete(true))
            {
                await _supppliersLogic.DeleteSupplier(dto);
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var dto = _supppliersLogic.Mapper.Create();
            dto.Name = "Dummy_Name";
            dto.Place = "Dummy_Place";
            dto.Employees = 1100;

            var obj = await _supppliersLogic.SaveSupplier(dto);
            var source = ultraGrid1.DataSource as List<SupplierDto>;
            source.Add(obj);
            ultraGrid1.Rows.Refresh(Infragistics.Win.UltraWinGrid.RefreshRow.ReloadData);
        }
    }
}
