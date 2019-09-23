using Contacts.DomainModel.Persons;
using Contacts.DomainModel.PhBook;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Contacts.DAL
{
    public class ContextDB : DbContext
    {
        private readonly IConfiguration configuration;

        public ContextDB(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Person> people { get; set; }
        public DbSet<PhoneBook> phoneBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasKey(c => c.Id);
            modelBuilder.Entity<PhoneBook>().HasKey(c => c.Id);

            //modelBuilder.Entity<PhoneBook>().HasOne(c => c.person).WithMany(D => D.phoneBooks).HasForeignKey(F => F.PersonId);
            modelBuilder.Entity<Person>().HasMany(C => C.phoneBooks).WithOne(D => D.person).HasForeignKey(f => f.PersonId);

        }


    }
}
