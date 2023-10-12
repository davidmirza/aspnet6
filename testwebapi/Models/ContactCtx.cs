using Microsoft.EntityFrameworkCore;

namespace testwebapi.Models
{
    public class ContactCtx: DbContext
    {
        public ContactCtx(DbContextOptions<ContactCtx> options): base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }

    }
}
