using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace mert_software_task.WebFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
        public static Orders orders = null;
        public static Products products = null;
        public static Categories categories = null;
        public static Customers customers = null;
        public static Suppliers suppliers = null;
        public static Shippers shippers = null;
        public static Employess employess = null;
        public static Orders Orders
        {
            get
            {
                if (orders == null)
                    orders = new Orders();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return orders;
            }

        }
        public static Products Products
        {
            get
            {
                if (products == null)
                    products = new Products();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return products;
            }

        }
        public static Categories Categories
        {
            get
            {
                if (categories == null)
                    categories = new Categories();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return categories;
            }

        }
        public static Customers Customers
        {
            get
            {
                if (customers == null)
                    customers = new Customers();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return customers;
            }

        }
        public static Suppliers Suppliers
        {
            get
            {
                if (suppliers == null)
                    suppliers = new Suppliers();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return suppliers;
            }

        }
        public static Shippers Shippers
        {
            get
            {
                if (shippers == null)
                    shippers = new Shippers();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return shippers;
            }

        }
        public static Employess Employess
        {
            get
            {
                if (employess == null)
                    employess = new Employess();
                else
                {
                    MessageBox.Show("Orders are already open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return employess;
            }

        }
    }
}
