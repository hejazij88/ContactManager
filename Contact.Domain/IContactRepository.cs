using Contact.Application.Share.Contacts;

namespace Contact.Domain;

public interface IContactRepository
{
    List<ContactViewModel> GetAll();

    void Create(Contact contact);

    void Delete(Contact contact);

    EditContactModel GetById(Guid id);

    Contact? EditContact(Guid id);

    void SaveChange();
}