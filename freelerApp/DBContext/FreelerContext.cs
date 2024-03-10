using Microsoft.EntityFrameworkCore;

class FreelerContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Freelancer> Freelancers { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        URL rL = new();
        optionsBuilder.UseMySQL(rL.url);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(e =>
        {
            e.HasKey(x => x.Id);
            e.Property(x => x.Name);
            e.Property(x => x.Password);
            e.Property(x => x.client);
            e.Property(x => x.Freelancer);
        });
        modelBuilder.Entity<Client>(c =>
        {
            c.HasKey(x => x.Id);
            c.Property(x => x.TypeOfJob);
            c.Property(x => x.Services);
            c.Property(x => x.Contracts);
            c.Property(x => x.SearchingFor);

        });
        modelBuilder.Entity<Freelancer>(f =>
        {
            f.HasKey(x => x.Id);
            f.Property(x => x.PaidPlan);
            f.Property(x => x.Areas);
            f.Property(x => x.Contracts);
        });
        modelBuilder.Entity<Contract>(c =>
        {
            c.HasKey(x => x.Id);
            c.Property(x => x.Status);
            c.Property(x => x.ServiceStartDate);
            c.Property(x => x.PaymentForm);
            c.Property(x => x.Price);
            c.Property(x => x.ServiceStartDate);
        });
        modelBuilder.Entity<Service>(s =>
        {
            s.HasKey(x => x.Id);
            s.Property(x => x.StartDate);
            s.Property(x => x.Mobile);
            s.Property(x => x.Phone);
            s.Property(x => x.Segment);
            s.Property(x => x.WhatsApp);
        });
    }
}