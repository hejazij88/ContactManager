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

        public void Delete(Domain.Contact contact) => _context.Contacts.Remove(contact);

        public EditContactModel? GetById(Guid id) => _context.Contacts.Select(c => new EditContactModel
        {
            Id = c.Id, Phone = c.Phone, Address = c.Address, Email = c.Email, LastName = c.LastName, Name = c.Name,
            NikeName = c.NikeName
        }).FirstOrDefault(c => c.Id == id);

        public Domain.Contact? EditContact(Guid id)
        {
            return _context.Contacts.FirstOrDefault(contact => contact.Id == id);
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
