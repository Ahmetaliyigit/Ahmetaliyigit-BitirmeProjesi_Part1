using DAL.Context;
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
    public class ColorService
    {
        private readonly ColorDAL color;

        public ColorService(ColorDAL dAL)
        {
            color = dAL;
        }

        public async Task<List<Color>> GetColorsAsync(Expression<Func<Color, bool>> filter = null)
        {
            return await color.GetColorsAsync(filter);
        }
    }
}
