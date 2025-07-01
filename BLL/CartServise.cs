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
    public class CartServise
    {   
       private readonly CartDal Carts;

       public CartServise()
       {
            Carts = new CartDal();
       }

       public async Task<List<Cart>> GetallAsync(Expression<Func<Cart,bool>> filter= null)
       {
           return await Carts.GetAllAsync(filter);
       }
   
    }
}
