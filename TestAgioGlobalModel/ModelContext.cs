namespace TestAgioGlobalModel
{
    using System.Data.Entity;
    using Entities;


    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }
        public virtual DbSet<Airports> Airports { get; set; }
    }

}