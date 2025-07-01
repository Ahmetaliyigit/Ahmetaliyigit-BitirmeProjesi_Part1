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
    public class CartDal
    {
        private readonly DataContext db;
        public CartDal()
        {
            db = new DataContext();
        }

        public async Task<List<Cart>> GetAllAsync(Expression<Func<Cart,bool>> filter=null)
        {
            var carts = db.Carts.Include(i => i.User).AsQueryable();

            if (filter != null)
            {
                carts = carts.Where(filter);
            }
            return await carts.ToListAsync();
        }
    }
}
