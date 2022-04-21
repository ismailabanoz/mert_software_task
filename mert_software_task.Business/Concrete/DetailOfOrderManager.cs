using mert_software_task.Business.Abstract;
using mert_software_task.DataAccess.Abstract;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Concrete
{
    public class DetailOfOrderManager : IDetailOfOrderService
    {
        IDetailOfOrderDal _DetailOfOrderDal;
        public DetailOfOrderManager(IDetailOfOrderDal detailOfOrderDal)
        {
            _DetailOfOrderDal = detailOfOrderDal;
        }
        public void Add(DetailOfOrder detailOfOrder)
        {
            _DetailOfOrderDal.Add(detailOfOrder);
        }

        public void Delete(DetailOfOrder detailOfOrder)
        {
            _DetailOfOrderDal.Delete(detailOfOrder);
        }

        public List<DetailOfOrder> GetAll()
        {
            return _DetailOfOrderDal.GetAll();
        }

        public void Update(DetailOfOrder detailOfOrder)
        {
            _DetailOfOrderDal.Update(detailOfOrder);
        }
        public List<DetailOfOrder> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _DetailOfOrderDal.GetAll().Where(p => p.ProductId.ToString().Contains(keyToLower)).ToList();
        }
    }
}
