using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Application;
using Contact.Application.Share.Contacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contact.Infrus
{
    public class ContactBootstrapper
    {
        public static void Configure(IServiceCollection serviceCollection,string connection)
        {

            serviceCollection.AddTransient<IContactApplication, ContactApplication>();

            serviceCollection.AddDbContext<ContactContext>(x => x.UseSqlServer(connection));
        }
    }
}
