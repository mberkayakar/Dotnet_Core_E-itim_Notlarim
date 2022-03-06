using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductServices
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productdal)
        {
            _productDal = productdal;
        }


        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int category)
        {
            return _productDal.GetList(x => x.CategoryId ==category);
        }
    }
}
