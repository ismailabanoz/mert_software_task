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
            _detailOfOrderService = InstanceFactory.GetInstance<IDetailOfOrderService>();
            _shipAddressOfOrderService = InstanceFactory.GetInstance<IShipAddressOfOrderService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _supplierService = InstanceFactory.GetInstance<ISupplierService>();
            _shipperService = InstanceFactory.GetInstance<IShipperService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        IOrderService _orderService;
        IDetailOfOrderService _detailOfOrderService;
        IShipAddressOfOrderService _shipAddressOfOrderService;
        IProductService _productService;
        ICategoryService _categoryService;
        ICustomerService _customerService;
        ISupplierService _supplierService;
        IShipperService _shipperService;
        IEmployeeService _employeeService;
        private void Orders_Load(object sender, EventArgs e)
        {
           var address= _shipAddressOfOrderService.GetAll();
            var orders= _orderService.GetAll();
            var detail= _detailOfOrderService.GetAll();

            dataGridView1.DataSource = _employeeService.GetEmployess();
        }
    }
}
