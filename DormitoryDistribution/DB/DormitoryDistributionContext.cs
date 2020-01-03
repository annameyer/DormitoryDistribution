namespace DormitoryDistribution.DB
{
    using System.Data.Entity;

    public partial class DormitoryDistributionContext : DbContext
    {
        public DormitoryDistributionContext()
            : base("name=DormitoryDistribution")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
