using Contact.Application.Share.Contacts;
using Contact.Domain;

namespace Contact.Application
{
    public class ContactApplication:IContactApplication
    {
        private readonly IContactRepository _contactRepository;

        public ContactApplication(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<ContactViewModel?> GetAll() => _contactRepository.GetAll();
    }
}
