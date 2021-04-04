using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Classes
{
    public class Meal
    {
        public string MealName { get; set; }
        public List<Product_Mass> Products { get; set; }

        public void AddProductMass(Product_Mass product)
        {
            Products.Add(product);
        }
        public void RemoveProductMass(Product_Mass product)
        {
            Products.Remove(product);
        }
        public Meal(string mealname)
        {
            Products = new List<Product_Mass>();
            MealName = mealname;
        }

    }
}
