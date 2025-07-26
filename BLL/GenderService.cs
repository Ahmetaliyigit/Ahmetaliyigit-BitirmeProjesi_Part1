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
    public class GenderService
    {
        private readonly GenderDAL gender;
        public GenderService()
        {
            gender = new GenderDAL();
        }

        public async Task<List<Gender>> GetGendersAsync(Expression<Func<Gender, bool>> filter = null)
        {
            return await gender.GetGendersAsync(filter);
        }
    }
}
