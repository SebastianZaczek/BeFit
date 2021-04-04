using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Classes
{
    public class Day_Meals
    {
        public DateTime Date { get; set; }
        public List<Meal> Meals { get; set; }
        public double CaloricDemand { get; set; }
        public double FatDemand { get; set; }
        public double CarboDemand { get; set; }
        public double ProteinDemand { get; set; }
        [JsonConstructor]
        public Day_Meals(double Calories, double Fat, double Carbo, double Protein)
        {
            Meals = new List<Meal>();
            Date = DateTime.Today;
            CaloricDemand = Calories;
            FatDemand = Fat;
            CarboDemand = Carbo;
            ProteinDemand = Protein;

        }
        
        public Day_Meals(DateTime date) //dla testow
        {
            Date = date;
        }
    }
}
