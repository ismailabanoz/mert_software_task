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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        ICategoryService _categoryService;
        private void Categories_Load(object sender, EventArgs e)
        {
            DgwSettings();
            dataGridView1.DataSource = _categoryService.GetAll();
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
