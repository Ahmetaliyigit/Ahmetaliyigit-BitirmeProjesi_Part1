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
    public class GenderDAL
    {
        private readonly DataContext context;

        public GenderDAL()
        {
            context = new DataContext();
        }

        public async Task<List<Gender>> GetGendersAsync(Expression<Func<Gender,bool>> filter = null)
        {
            var Genders = context.Genders.AsQueryable();

            if (filter != null)
            {
                Genders.Where(filter);
            }

            return await Genders.ToListAsync();
        }
    }
}
