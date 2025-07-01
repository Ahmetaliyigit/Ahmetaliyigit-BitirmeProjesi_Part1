using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cart
    {
        public int Id { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CratedTime { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Product> Products  { get; set; }

    }
}
