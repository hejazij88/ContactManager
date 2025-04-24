using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Contact.Application.Share.Contacts;

public class AddContactModel
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string LastName { get; set; }
    public string NikeName { get; set; }
    public string Email { get; set; }
    [Required]
    public string Phone { get; set; }
    public IFormFile Photo { get; set; }
    public string Address { get; set; }
}