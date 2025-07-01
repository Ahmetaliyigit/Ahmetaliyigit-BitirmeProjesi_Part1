using DAL.Context;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EfCore
{
    public class ProductDal
    {
        private readonly DataContext db;

        public ProductDal()
        {
            db = new DataContext();
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product,bool>> filter=null)
        {
            var products = db.Products.Include(i => i.Color).AsQueryable();

            if (filter != null)
            {
                products = products.Where(filter);
            }

             return await products.ToListAsync();
        }

    }
}


