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
    public class CategoryService
    {
        private readonly CategoryDAL category;

        public CategoryService()
        {
            category = new CategoryDAL();
        }

        public async Task<List<Category>> GetCategoriesAsync(Expression<Func<Category, bool>> filter = null)
        {
            return await category.GetCategoriesAsync(filter);
        }
    }
}
