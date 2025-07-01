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
    public class CartItemDal
    {
        private readonly DataContext db;
        public CartItemDal()
        {
            db = new DataContext();
        }

        public async Task<List<CartItem>> GetAllAsync(Expression<Func<CartItem,bool>> filter=null)
        {
            var cartitems = db.CartItems.Include(i => i.Product).AsQueryable();

            if (filter != null)
            {
                cartitems = cartitems.Where(filter);
            }
            return await cartitems.ToListAsync();
        }
    }
}
