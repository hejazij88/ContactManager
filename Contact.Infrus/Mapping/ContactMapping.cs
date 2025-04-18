using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Infrus.Mapping;

public class ContactMapping:IEntityTypeConfiguration<Domain.Contact>
{
    public void Configure(EntityTypeBuilder<Domain.Contact> builder)
    {
        builder.ToTable("Contact");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired();
        builder.Property(c => c.LastName).IsRequired();
        builder.Property(c => c.Phone).IsRequired();


    }
}