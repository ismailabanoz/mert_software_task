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
        public class Order : IEntity
        {
            public int id { get; set; }
            public string customerId { get; set; }
            public int employeeId { get; set; }
            public DateTime? orderDate { get; set; }
            public DateTime? requiredDate { get; set; }
            public string shippedDate { get; set; }
            public int shipVia { get; set; }
            public float freight { get; set; }
            public string shipName { get; set; }
            public ShipAddressOfOrder shipAddress { get; set; }
            public List<DetailsfOrder> details { get; set; }

        }
        public class ShipAddressOfOrder : IEntity
        {
            public string street { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string postalCode { get; set; }
            public string country { get; set; }
        }
        public class DetailsfOrder : IEntity
        {
            public int productId { get; set; }
            public decimal unitPrice { get; set; }
            public int quantity { get; set; }
            public float discount { get; set; }
        }
        public MainMenu()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _detailOfOrderService = InstanceFactory.GetInstance<IDetailOfOrderService>();
            _shipAddressOfOrderService = InstanceFactory.GetInstance<IShipAddressOfOrderService>();
        }

        IProductService _productService;
        IOrderService _orderService;
        IDetailOfOrderService _detailOfOrderService;
        IShipAddressOfOrderService _shipAddressOfOrderService;

       

        private void MainMenu_Load(object sender, EventArgs e)
        {
            List<Order> getOrders = SaveOrders();

            MessageBox.Show(getOrders.Count.ToString());



            string url = "https://northwind.vercel.app/api/products";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returnData = new StreamReader(response.GetResponseStream());
            string getData = returnData.ReadToEnd();

            List<Product> getProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(getData);

           
            MessageBox.Show(getProducts.Count.ToString());
        }
        public class Product : IEntity
        {
            public int id { get; set; }
            public int supplierId { get; set; }
            public int categoryId { get; set; }
            public string quantityPerUnit { get; set; }
            public decimal unitPrice { get; set; }
            public int unitsInStock { get; set; }
            public int unitsOnOrder { get; set; }
            public int reorderLevel { get; set; }
            public bool discontinued { get; set; }
            public string Name { get; set; }
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
    }
}
