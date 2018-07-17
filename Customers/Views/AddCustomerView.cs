using Common.Dtos;
using Customers.Logic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Customers.Views
{
    public partial class AddCustomerView : Form
    {
        #region Fields
        private CustomerLogic _customerLogic;
        private ErrorProvider errorProvider;
        private CustomerDto _model;

        #endregion

        #region Contructors
        public AddCustomerView()
        {
            InitializeComponent();
            Icon = new Icon("buying.ico");


            errorProvider = new ErrorProvider();
            textBox1.Validating += ControlValidating;
            textBox1.Validated += ControlValidated;
            comboBox1.Validating += ControlValidating;
            comboBox1.Validated += ControlValidated;

            Load += AddCustomerView_Load;
        }      

        public AddCustomerView(CustomerLogic customerLogic):this()
        {
            _customerLogic = customerLogic;
            _model = _customerLogic.Mapper.Create();

        }

        #endregion

        #region methods
        private void SetError(Control ctrl, string msg)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider.SetError(ctrl as Control, msg);
        }

        private void FillModel()
        {
            _model.Name = textBox1.Text;
            _model.Age = (int)numericUpDown1.Value;
            _model.Continent = (string)comboBox1.SelectedItem;
        }

        #endregion

        #region Events

        private void AddCustomerView_Load(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void ControlValidated(object sender, EventArgs e)
        {
            SetError(sender as Control, "");
            FillModel();
            saveButton.Enabled = _customerLogic.IsModelValid(_model);
        }

        private void ControlValidating(object sender, CancelEventArgs args)
        {
            string errorMsg;
            var ctrl = sender as Control;
            if (!_customerLogic.ValidCustomerTextInput(ctrl.Text, out errorMsg))
            {
                args.Cancel = true;
                SetError(ctrl, errorMsg);
                saveButton.Enabled = false;
            }
        }
        
        private async void save_Click(object sender, EventArgs e)
        {
            if (!_customerLogic.IsModelValid(_model))
            {
                MessageBox.Show("Invalid Inputs", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                await _customerLogic.SaveCustomer(_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);               
            }
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            CausesValidation = false;  
            Close();
        }

        #endregion
    }
}
