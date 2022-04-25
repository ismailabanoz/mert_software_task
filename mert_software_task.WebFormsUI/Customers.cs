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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
            ICustomerService _customerService;
        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetCustomers();
            DgwSettings();
        }

        private void DgwSettings()
        {
            var dgwSettings = (Orders)Application.OpenForms["Orders"];
            if (dgwSettings != null)
            {
                dgwSettings.DataGridViewSettings(dataGridView1);
            }
        }
    }
}
