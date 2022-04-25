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
    public partial class Shippers : Form
    {
        public Shippers()
        {
            InitializeComponent();
            _shipperService = InstanceFactory.GetInstance<IShipperService>();
        }
        IShipperService _shipperService;
        private void Shippers_Load(object sender, EventArgs e)
        {
            DgwSettings();
            dataGridView1.DataSource = _shipperService.GetAll();
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
