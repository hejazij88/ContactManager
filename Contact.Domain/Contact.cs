namespace Contact.Domain;

public class Contact
{
    public Guid Id { get;private set; }
    public string Name { get;private set; }
    public string LastName { get;private set; }
    public string NikeName { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string Photo { get;private set; }
    public string Address { get;private set; }

    public Contact(string name, string lastName, string nikeName, string email, string phone, string photo, string address)
    {
        Name = name;
        LastName = lastName;
        NikeName = nikeName;
        Email = email;
        Phone = phone;
        Photo = photo;
        Address = address;
    }

    public void Edit(Guid id,string name, string lastName, string nikeName, string email, string phone, string photo, string address)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        NikeName = nikeName;
        Email = email;
        Phone = phone;
        Photo = photo;
        Address = address;
    }
}