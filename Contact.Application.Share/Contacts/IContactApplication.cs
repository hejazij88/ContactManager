
using _0_FreamWork;

namespace Contact.Application.Share.Contacts;

public interface IContactApplication
{
    List<ContactViewModel?> GetAll();
    OperationResult Create(AddContactModel contactModel);
    OperationResult Edit(EditContactModel contactModel);

    EditContactModel? GetById(Guid id);


}