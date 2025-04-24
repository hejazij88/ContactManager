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
    }
}
