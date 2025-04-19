using Contact.Application.Share.Contacts;

namespace Contact.Domain;

public interface IContactRepository
{
    List<ContactViewModel> GetAll();
}