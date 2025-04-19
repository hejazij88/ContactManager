using Contact.Application.Share.Contacts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IContactApplication _contactApplication;
        public List<ContactViewModel> viewModel { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, List<ContactViewModel> viewModel, IContactApplication contactApplication)
        {
            _logger = logger;
            this.viewModel = viewModel;
            _contactApplication = contactApplication;
        }

        public void OnGet()
        {
            viewModel = _contactApplication.GetAll();
        }
    }
}
