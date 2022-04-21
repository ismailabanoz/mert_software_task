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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        IProductService _productService;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("at");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = _productService.GetAll();

            
        }
    }
}
