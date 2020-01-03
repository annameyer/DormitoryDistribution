namespace DormitoryDistribution.DB
{
    using System.Data.Entity;

    public partial class DormitoryDistributionContext : DbContext
    {
        public DormitoryDistributionContext()
            : base("name=DormitoryDistribution")
        {
        }

        public virtual DbSet<Hostel> Hostels { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hostel>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Hostel>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Hostel>()
                .Property(e => e.Patronymic)
                .IsFixedLength();

            modelBuilder.Entity<Hostel>()
                .Property(e => e.Group)
                .IsFixedLength();

            modelBuilder.Entity<Hostel>()
                .Property(e => e.Income)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
