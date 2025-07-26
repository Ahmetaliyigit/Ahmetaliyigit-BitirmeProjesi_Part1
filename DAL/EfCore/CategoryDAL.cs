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
    public class CategoryDAL
    {
        private readonly DataContext context;

        public CategoryDAL()
        {
            context = new DataContext();
        }

        public async Task<List<Category>> GetCategoriesAsync(Expression<Func<Category,bool>> filter = null)
        {
            var Categorys = context.Categories.AsQueryable();

            if (filter != null)
            {
                Categorys.Where(filter);
            }

            return await Categorys.ToListAsync();
        }
    }
}
