using Contact.Application;
using Contact.Application.Share.Contacts;
using Contact.Domain;
using Contact.Infrus.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contact.Infrus.Config
{
    public class ContactBootstrapper
    {
        public static void Configure(IServiceCollection serviceCollection,string connection)
        {
            serviceCollection.AddTransient<IContactRepository, ContactRepository>();
            serviceCollection.AddTransient<IContactApplication, ContactApplication>();


            serviceCollection.AddDbContext<ContactContext>(x => x.UseSqlServer(connection));
        }
    }
}
