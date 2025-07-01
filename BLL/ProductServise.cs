using DAL.EfCore;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductServise
    {
        private readonly ProductDal products;

        public ProductServise()
        {
            products = new ProductDal();
        }

        public async Task<List<Product>> GetallAsync(Expression<Func<Product,bool>> filter=null)
        {
            return await products.GetAllAsync(filter);
        }
    }
}
