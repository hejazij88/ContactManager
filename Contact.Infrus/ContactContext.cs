using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Infrus.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Contact.Infrus
{
    public class ContactContext:DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> option):base(option)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ContactMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
