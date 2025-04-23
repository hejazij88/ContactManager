using Contact.Application.Share.Contacts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IContactApplication _contactApplication;
        public List<ContactViewModel?> contactList;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IContactApplication contactApplication)
        {
            _contactApplication = contactApplication;
            _logger = logger;
        }

        public void OnGet()
        {
            contactList = _contactApplication.GetAll();
        }
        public void OnPost()
        {
        }
    }
}
