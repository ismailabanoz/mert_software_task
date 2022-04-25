using mert_software_task.Api.Concrete.Models;
using mert_software_task.Business.Abstract;
using mert_software_task.Business.DependencyResolvers.Ninject;
using mert_software_task.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mert_software_task.WebFormsUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _detailOfOrderService = InstanceFactory.GetInstance<IDetailOfOrderService>();
            _shipAddressOfOrderService = InstanceFactory.GetInstance<IShipAddressOfOrderService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _addressOfCustomerService = InstanceFactory.GetInstance<IAddressOfCustomerService>();
            _supplierService = InstanceFactory.GetInstance<ISupplierService>();
            _addressOfSupplierService = InstanceFactory.GetInstance<IAddressOfSupplierService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _shipperService = InstanceFactory.GetInstance<IShipperService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _addressOfEmployeeService = InstanceFactory.GetInstance<IAddressOfEmployeeService>();
            _territoryIdOfEmployeeService = InstanceFactory.GetInstance<ITerritoryIdOfEmployeeService>();
        }

        IProductService _productService;
        IOrderService _orderService;
        IDetailOfOrderService _detailOfOrderService;
        IShipAddressOfOrderService _shipAddressOfOrderService;
        ICustomerService _customerService;
        IAddressOfCustomerService _addressOfCustomerService;
        ISupplierService _supplierService;
        IAddressOfSupplierService _addressOfSupplierService;
        ICategoryService _categoryService;
        IShipperService _shipperService;
        IEmployeeService _employeeService;
        IAddressOfEmployeeService _addressOfEmployeeService;
        ITerritoryIdOfEmployeeService _territoryIdOfEmployeeService;



        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private List<Employee> SaveEmloyess()
        {
            string url = "https://northwind.vercel.app/api/employess";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Employee> getEmployess = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(getData);

            foreach (var employee in getEmployess)
            {
                _addressOfEmployeeService.Add(new Entities.Concrete.AddressOfEmployee
                {
                    EmployeeId = employee.id,
                    Street = employee.address.street,
                    City = employee.address.city,
                    Region = employee.address.region,
                    PostalCode = employee.address.postalCode,
                    Country = employee.address.country,
                    Phone = employee.address.phone
                });

                _employeeService.Add(new Entities.Concrete.Employee
                {
                    EmployeeId = employee.id,
                    LastName = employee.lastName,
                    FirstName = employee.firstName,
                    Title = employee.title,
                    TitleOfCourtesy = employee.titleOfCourtesy,
                    BirthDate = employee.birthDate,
                    HireDate = employee.hireDate,
                    Notes = employee.notes,
                    ReportsTo = employee.reportsTo
                });
                foreach (var territory in employee.territoryIds)
                {
                    _territoryIdOfEmployeeService.Add(new Entities.Concrete.TerritoryIdOfEmployee
                    {
                        EmployeeId = employee.id,
                        Territory = territory
                    });
                }
            }

            return getEmployess;
        }

        private List<Supplier> SaveSuppliers()
        {
            string url = "https://northwind.vercel.app/api/suppliers";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Supplier> getSuppliers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Supplier>>(getData);

            foreach (var supplier in getSuppliers)
            {
                _addressOfSupplierService.Add(new Entities.Concrete.AddressOfSupplier
                {
                    SupplierId = supplier.id,
                    Street = supplier.address.street,
                    City = supplier.address.city,
                    Region = supplier.address.region,
                    PostalCode = supplier.address.postalCode,
                    Country = supplier.address.country,
                    Phone = supplier.address.phone
                });

                _supplierService.Add(new Entities.Concrete.Supplier
                {
                    SupplierId = supplier.id,
                    CompanyName = supplier.companyName,
                    ContactName = supplier.contactName,
                    ContactTitle = supplier.contactTitle
                });
            }

            return getSuppliers;
        }

        private List<Product> SaveProducts()
        {
            string url = "https://northwind.vercel.app/api/products";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Product> getProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(getData);

            foreach (var product in getProducts)
            {
                _productService.Add(new Entities.Concrete.Product
                {
                    ProductId = product.id,
                    SupplierId = product.supplierId,
                    CategoryId = product.categoryId,
                    QuantityPerUnit = product.quantityPerUnit,
                    UnitPrice = product.unitPrice,
                    UnitsInStock = product.unitsInStock,
                    UnitsOnOrder = product.unitsOnOrder,
                    ReorderLevel = product.reorderLevel,
                    Discontinued = product.discontinued,
                    Name = product.name
                });
            }

            return getProducts;
        }

        private void SaveCategories()
        {
            string url = "https://northwind.vercel.app/api/categories";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Category> getCategories = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Category>>(getData);

            foreach (var category in getCategories)
            {
                _categoryService.Add(new Entities.Concrete.Category
                {
                    CategoryId = category.id,
                    Description = category.description,
                    Name = category.name
                });
            }
        }

        private void SaveShippers()
        {
            string url = "https://northwind.vercel.app/api/shippers";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Shipper> getShippers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Shipper>>(getData);

            foreach (var shipper in getShippers)
            {
                _shipperService.Add(new Entities.Concrete.Shipper
                {
                    ShipperId = Convert.ToInt32(shipper.id),
                    CompanyName = shipper.companyName,
                    Phone = shipper.phone
                });
            }
        }

        private List<Customer> SaveCustomers()
        {
            string url = "https://northwind.vercel.app/api/customers";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Customer> getCustomers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Customer>>(getData);

            foreach (var customer in getCustomers)
            {
                _addressOfCustomerService.Add(new Entities.Concrete.AddressOfCustomer
                {
                    CustomerId = customer.id,
                    Street = customer.address.street,
                    City = customer.address.city,
                    Region = customer.address.region,
                    PostalCode = customer.address.postalCode,
                    Country = customer.address.country,
                    Phone = customer.address.phone

                });

                _customerService.Add(new Entities.Concrete.Customer
                {
                    CustomerId = customer.id,
                    CompanyName = customer.companyName,
                    ContactName = customer.contactName,
                    ContactTitle = customer.contactTitle
                });
            }

            return getCustomers;
        }

        private List<Order> SaveOrders()
        {
            string url = "https://northwind.vercel.app/api/orders";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Order> getOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(getData);

            foreach (var order in getOrders)
            {
                _shipAddressOfOrderService.Add(new Entities.Concrete.ShipAddressOfOrder
                {
                    OrderId = Convert.ToInt32(order.id),
                    City = order.shipAddress.city,
                    Country = order.shipAddress.country,
                    PostalCode = order.shipAddress.postalCode,
                    Region = order.shipAddress.region,
                    Street = order.shipAddress.street

                });
                foreach (var detail in order.details)
                {
                    _detailOfOrderService.Add(new Entities.Concrete.DetailOfOrder
                    {
                        ProductId = Convert.ToInt32(detail.productId),
                        OrderId = Convert.ToInt32(order.id),
                        UnitPrice = Convert.ToDecimal(detail.unitPrice),
                        Quantity = Convert.ToInt32(detail.quantity),
                        Discount = (float)Convert.ToDouble(detail.discount)
                    });
                }
                DateTime? shippedDate2 = null;
                if (order.shippedDate.ToString() == "NULL")
                {
                    shippedDate2 = new DateTime(1900, 1, 1);
                }
                else
                {
                    shippedDate2 = order.requiredDate;
                }
                _orderService.Add(new Entities.Concrete.Order
                {
                    OrderId=order.id,
                    CustomerId = order.customerId,
                    EmployeeId = Convert.ToInt32(order.employeeId),
                    OrderDate = Convert.ToDateTime(order.orderDate),
                    RequiredDate = Convert.ToDateTime(order.requiredDate),
                    ShippedDate = Convert.ToDateTime(shippedDate2),
                    ShipVia = Convert.ToInt32(order.shipVia),
                    Freight = (float)Convert.ToDouble(order.freight),
                    ShipName = order.shipName

                });
            }

            return getOrders;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenOrders();
        }

        private static void OpenOrders()
        {
            Orders orders = Program.Orders;
            orders.Show();
        }
        private static void OpenProducts()
        {
            Products products = Program.Products;
            products.Show();
        }
        private static void OpenCategories()
        {
            Categories categories = Program.Categories;
            categories.Show();
        }
        private static void OpenCustomers()
        {
            Customers customers = Program.Customers;
            customers.Show();
        }
        private static void OpenSuppliers()
        {
            Suppliers suppliers = Program.Suppliers;
            suppliers.Show();
        }
        private static void OpenShippers()
        {
            Shippers shippers = Program.Shippers;
            shippers.Show();
        }
        private static void OpenEmployess()
        {
            Employess employess = Program.Employess;
            employess.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenProducts();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenCategories();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenCustomers();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenSuppliers();
        }

        private void btnShippers_Click(object sender, EventArgs e)
        {
            OpenShippers();
        }

        private void btnEmployess_Click(object sender, EventArgs e)
        {
            OpenEmployess();
        }

        private void btnPullAndSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("This process may take some time.", "Information");
                List<Order> getOrders = SaveOrders();
                List<Customer> getCustomers = SaveCustomers();
                SaveShippers();
                SaveCategories();
                List<Product> getProducts = SaveProducts();
                List<Supplier> getSuppliers = SaveSuppliers();
                List<Employee> getEmployess = SaveEmloyess();
                MessageBox.Show("Data transferred to database successfully", "Information");
            }
            catch
            {

            }
            
        }
    }
}
