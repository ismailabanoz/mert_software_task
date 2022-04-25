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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }
        IProductService _productService;
        private void Products_Load(object sender, EventArgs e)
        {
            DgwSettings();
            dataGridView1.DataSource = _productService.GetProducts();
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
