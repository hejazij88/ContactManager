using Contact.Application.Share.Contacts;

namespace Contact.Domain;

public interface IContactRepository
{
    List<ContactViewModel> GetAll();

    void Create(Contact contact);

    void Update(Contact contact);

    void SaveChange();
}