using BeFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Classes
{
    public class Product_Mass
    {
        public Product Product { get; set; }
        public double Mass { get; set; }

        public Product_Mass(Product product, double mass)
        {
            Product = product;
            Mass = mass;
        }
        public Product_Mass() { }
    }
}
