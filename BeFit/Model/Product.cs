namespace BeFit.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Newtonsoft.Json;
    

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Total_kcal_per_100 { get; set; }

        public double Protein { get; set; }

        public double Fat_Total { get; set; }

        public double? Fat_Saturated { get; set; }

        public double Carbohydrates { get; set; }

        public double? Carbo_Sugar { get; set; }

        public string Tip { get; set; }

        public int Id_Category { get; set; }
        [JsonIgnore]
        public virtual Product_Category Product_Category { get; set; }
    }
}
