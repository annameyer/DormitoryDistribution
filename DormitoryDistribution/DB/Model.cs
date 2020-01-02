namespace DormitoryDistribution.DB
{
    using System.Data.Entity;

    public partial class DormitoryDistributionContext : DbContext
    {
        public DormitoryDistributionContext()
            : base("name=DataBase")
        {         
        }
        public DbSet<Authorization> Authorizations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
