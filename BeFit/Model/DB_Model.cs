namespace BeFit.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_Model : DbContext
    {
        public DB_Model()
            : base("name=DB_Model")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_Category> Product_Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Product_Category)
                .HasForeignKey(e => e.Id_Category)
                .WillCascadeOnDelete(false);
        }
    }
}
