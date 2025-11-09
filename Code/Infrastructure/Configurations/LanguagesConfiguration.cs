using Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LanguagesConfiguration
{
    public void Configure(EntityTypeBuilder<Languages> builder)
    {
        builder.HasKey(u => u.Id);
    }
}