using mert_software_task.Business.Abstract;
using mert_software_task.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mert_software_task.WebFormsUI
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        IOrderService _orderService;
        ICustomerService _customerService;
        private void Orders_Load(object sender, EventArgs e)
        {
            DataGridViewSettings(dgwOrders);
            dgwOrders.DataSource = _orderService.GetOrders();
            LoadCustomers();


        }
        public void DataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.RowHeadersVisible = false;
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ClearSelection();
        }
        private void LoadCustomers()
        {
            cbxCustomerAdd.DataSource = _customerService.GetAll();
            cbxCustomerAdd.DisplayMember = "CompanyName";
            cbxCustomerAdd.ValueMember = "CustomerId";
            cbxCustomerAdd.SelectedIndex = -1;
            cbxCustomerAdd.Text = "Select Customer..";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                var getLastOrderId = _orderService.GetAll().OrderByDescending(p => p.OrderId).FirstOrDefault();

                _orderService.Add(new Entities.Concrete.Order
                {
                    OrderId = Convert.ToInt32(getLastOrderId.OrderId) + 1,
                    CustomerId = cbxCustomerAdd.SelectedValue.ToString(),
                    EmployeeId = Convert.ToInt32(tbxEmployeeAdd.Text),
                    OrderDate = Convert.ToDateTime(dtpOrderDateAdd.Value),
                    RequiredDate = Convert.ToDateTime(dtpRequiredDateAdd.Value),
                    ShippedDate = Convert.ToDateTime(dtpShippedDateAdd.Value),
                    ShipVia = Convert.ToInt32(tbxShipViaAdd.Text),
                    Freight = Convert.ToDouble(tbxFreightAdd.Text),
                    ShipName = tbxShipNameAdd.Text
                });
                dgwOrders.DataSource = _orderService.GetOrders();
                MessageBox.Show("Registration Successful", "Information");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgwOrders.SelectedRows.Count > 0 && Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value) > -1)
            {

                _orderService.Delete(new Entities.Concrete.Order
                {
                    Id = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value)
                });
                dgwOrders.DataSource = _orderService.GetOrders();
                MessageBox.Show("Deleted", "Information");
            }
            else
            {
                MessageBox.Show("Select the record to delete.", "Information");
            }

        }

        private void dgwOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int getId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value);
            string getCustomerId = dgwOrders.CurrentRow.Cells[2].Value.ToString();
            var getOrder= _orderService.GetAll().Where(p => p.Id == getId).FirstOrDefault();

            var getCustomer = _customerService.GetAll().Where(p => p.CustomerId == getCustomerId).FirstOrDefault();

            cbxCustomerUpdate.DataSource= _customerService.GetAll();
            cbxCustomerUpdate.DisplayMember = "CompanyName";
            cbxCustomerUpdate.ValueMember = "CustomerId";
            cbxCustomerUpdate.SelectedIndex = 0;
            cbxCustomerUpdate.Text = getCustomer.CompanyName.ToString();

            tbxEmployeeUpdate.Text = getOrder.EmployeeId.ToString();
            dtpOrderDateUpdate.Value = Convert.ToDateTime(getOrder.OrderDate);
            dtpRequiredDateUpdate.Value = Convert.ToDateTime(getOrder.RequiredDate);
            dtpShippedDateUpdate.Value = Convert.ToDateTime(getOrder.ShippedDate);
            tbxShipViaUpdate.Text = getOrder.ShipVia.ToString();
            tbxFreightUpdate.Text = getOrder.Freight.ToString();
            tbxShipNameUpdate.Text = getOrder.ShipName.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                _orderService.Update(new Entities.Concrete.Order
                {
                    Id= Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value),
                    OrderId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[1].Value),
                    CustomerId = cbxCustomerUpdate.SelectedValue.ToString(),
                    EmployeeId = Convert.ToInt32(tbxEmployeeUpdate.Text),
                    OrderDate = Convert.ToDateTime(dtpOrderDateUpdate.Value),
                    RequiredDate = Convert.ToDateTime(dtpRequiredDateUpdate.Value),
                    ShippedDate = Convert.ToDateTime(dtpShippedDateUpdate.Value),
                    ShipVia = Convert.ToInt32(tbxShipViaUpdate.Text),
                    Freight = Convert.ToDouble(tbxFreightUpdate.Text),
                    ShipName = tbxShipNameUpdate.Text
                });
                dgwOrders.DataSource = _orderService.GetOrders();
                MessageBox.Show("Update Successful", "Information");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
