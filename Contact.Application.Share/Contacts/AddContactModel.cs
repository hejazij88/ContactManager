using Microsoft.AspNetCore.Http;

namespace Contact.Application.Share.Contacts;

public class AddContactModel
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public string NikeName { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public IFormFile Photo { get; private set; }
    public string Address { get; private set; }
}