using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Application.Share.Contacts;
using Contact.Domain;

namespace Contact.Infrus.Repository
{
    public class ContactRepository:IContactRepository
    {
        private readonly ContactContext _context;

        public ContactRepository(ContactContext context)
        {
            _context = context;
        }

        public List<ContactViewModel> GetAll() => _context.Contacts.Select(c => new ContactViewModel{Id= c.Id,Name= c.Name,LastName= c.LastName,Phone= c.Phone,Picture= c.Photo }).ToList();
        public void Create(Domain.Contact contact)
        {
            _context.Contacts.Add(contact);
        }

        public void Update(Domain.Contact contact)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
