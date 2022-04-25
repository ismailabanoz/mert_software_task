using mert_software_task.Business.Abstract;
using mert_software_task.Business.Concrete;
using mert_software_task.DataAccess.Abstract;
using mert_software_task.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<IOrderService>().To<OrderManager>();
            Bind<IOrderDal>().To<EfOrderDal>();

            Bind<IDetailOfOrderService>().To<DetailOfOrderManager>();
            Bind<IDetailOfOrderDal>().To<EfDetailOfOrderDal>();

            Bind<IShipAddressOfOrderService>().To<ShipAddressOfOrderManager>();
            Bind<IShipAddressOfOrderDal>().To<EfShipAddressOfOrderDal>();

            Bind<IAddressOfCustomerService>().To<AddressOfCustomerManager>();
            Bind<IAddressOfCustomerDal>().To<EfAddressOfCustomerDal>();

            Bind<IAddressOfEmployeeService>().To<AddressOfEmployeeManager>();
            Bind<IAddressOfEmployeeDal>().To<EfAddressOfEmployeeDal>();

            Bind<IAddressOfSupplierService>().To<AdressOfSupplierManager>();
            Bind<IAddressOfSupplierDal>().To<EfAddressOfSupplierDal>();

            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();

            Bind<ICustomerService>().To<CustomerManager>();
            Bind<ICustomerDal>().To<EfCustomerDal>();

            Bind<IEmployeeService>().To<EmployeeManager>();
            Bind<IEmployeeDal>().To<EfEmployeeDal>();

            Bind<IShipperService>().To<ShipperManager>();
            Bind<IShipperDal>().To<EfShipperDal>();

            Bind<ISupplierService>().To<SupplierManager>();
            Bind<ISupplierDal>().To<EfSupplierDal>();

            Bind<ITerritoryIdOfEmployeeService>().To<TerritoryIdOfEmployeeManager>();
            Bind<ITerritoryIdOfEmployeeDal>().To<EfTerritoryIdOfEmployeeDal>();

        }
    }
}
