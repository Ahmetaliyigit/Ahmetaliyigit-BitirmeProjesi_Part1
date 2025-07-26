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
    public class ColorDAL
    {
        private readonly DataContext context;

        public ColorDAL()
        {
            context = new DataContext();
        }

        public async Task<List<Color>> GetColorsAsync(Expression<Func<Color, bool>> filter = null)
        {
            var colors = context.Colors.AsQueryable();

            if (filter != null)
            {
                colors = colors.Where(filter);
            }

            return await colors.ToListAsync();
        }
    }
}
