using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ForeignLanguageConfiguration
{
    public void Configure(EntityTypeBuilder<ForeignLanguage> builder)
    {
        builder.ToTable("ForeignLanguages").HasKey(a => a.Id);
        
        builder.Property(a => a.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
        builder.Property(a => a.LanguageLevel).HasColumnName("LanguageLevel").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasOne(b => b.User);
        
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}