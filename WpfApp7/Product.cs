using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
