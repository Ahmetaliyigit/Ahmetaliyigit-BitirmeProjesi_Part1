using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string  CategoryName { get; set; }

        List<Product> products { get; set; }

    }
}
