namespace DormitoryDistribution.DB
{
    using System.Data.Entity;

    public partial class DormitoryDistributionContext : DbContext
    {
        public DormitoryDistributionContext()
            : base("name=DormitoryDistribution")
        {
        }

        public virtual DbSet<Authorization> Authorizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
