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
    public class ProductService
    {
        private readonly ProductDAL products;

        public ProductService(ProductDAL dal)
        {
            products = dal;
        }

        public async Task<List<Product>> GetallAsync(Expression<Func<Product,bool>> filter=null)
        {
            return await products.GetAllAsync(filter);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await products.UpdateProductAsync(product);
        }
        public async Task AddProductAsync(Product product)
        {
           await products.AddProductAsync(product);
        }
    }
}
