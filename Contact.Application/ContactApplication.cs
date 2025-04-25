using _0_FramWork;
using _0_FreamWork;
using Contact.Application.Share.Contacts;
using Contact.Domain;

namespace Contact.Application
{
    public class ContactApplication : IContactApplication
    {
        private readonly IContactRepository _contactRepository;
        private readonly IFileUploader _fileUploader;
        public ContactApplication(IContactRepository contactRepository, IFileUploader fileUploader)
        {
            _contactRepository = contactRepository;
            _fileUploader = fileUploader;
        }

        public List<ContactViewModel?> GetAll() => _contactRepository.GetAll();
        public OperationResult Create(AddContactModel contactModel)
        {
            var operation = new OperationResult();

            var path = "/Images";
            var picturePath = _fileUploader.Upload(contactModel.Photo, path);

            var contact = new Domain.Contact(contactModel.Name, contactModel.LastName, contactModel.NikeName, contactModel.Email, contactModel.Phone, picturePath, contactModel.Address);
            _contactRepository.Create(contact);
            _contactRepository.SaveChange();
            return operation.Succedded();

        }

        public OperationResult Edit(EditContactModel contactModel)
        {
            var operation = new OperationResult();
            var command = _contactRepository.EditContact(contactModel.Id);
            if (command == null)
                return operation.Failed("Can't Edit Call By Admin"); 

            var path = "/Images";
            var picturePath = _fileUploader.Upload(contactModel.Photo, path);

             command.Edit(contactModel.Id,contactModel.Name, contactModel.LastName, contactModel.NikeName, contactModel.Email, contactModel.Phone, picturePath, contactModel.Address);
            _contactRepository.SaveChange();
            return operation.Succedded();
        }

        public OperationResult Delete(Guid id)
        {
            var operation = new OperationResult();
            var contact = _contactRepository.EditContact(id);
            if (contact == null)
                return operation.Failed("Don't have This Record");

            _contactRepository.Delete(contact);
            _contactRepository.SaveChange();
            return operation.Succedded();
        }

        public EditContactModel? GetById(Guid id) => _contactRepository.GetById(id);
    }
}
