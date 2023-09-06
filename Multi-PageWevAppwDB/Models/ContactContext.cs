using Microsoft.EntityFrameworkCore;
namespace Multi_PageWevAppwDB.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact>? Contacts { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(

                new Contact
                {
                    ContactID = 1,
                    Name = "Colin Robinson",
                    PhoneNumber = "1234567890",
                    Address = "144 Para St.",
                    Note = "What We Do In the Shadows",
                },

                new Contact
                {
                    ContactID = 2,
                    Name = "Michael Scott",
                    PhoneNumber = "1234567890",
                    Address = "126 Kellum Ct.",
                    Note = "The Office",
                },

                new Contact
                {
                    ContactID = 3,
                    Name = "Detective Jake Peralta",
                    PhoneNumber = "1234567890",
                    Address = "11238 Jousten Ave. Apt. 6E",
                    Note = "Brooklyn 99",
                }

            );
        }

    }
}
