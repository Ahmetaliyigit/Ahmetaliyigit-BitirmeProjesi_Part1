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
    public class CartItemServise
    {
        private readonly CartItemDal CartItems;

        public CartItemServise()
        {
            CartItems = new CartItemDal();
        }

        public async Task<List<CartItem>> GetallAsync(Expression<Func<CartItem,bool>> filter = null)
        {
            return await CartItems.GetAllAsync(filter);
        }
    }
}
