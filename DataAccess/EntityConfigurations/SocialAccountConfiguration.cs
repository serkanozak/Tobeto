using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class SocialAccountConfiguration
{
    public void Configure(EntityTypeBuilder<SocialAccount> builder)
    {
        builder.ToTable("SocialAccounts").HasKey(a => a.Id);
        
        builder.Property(a => a.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
        builder.Property(a => a.AccountUrl).HasColumnName("AccountUrl").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasOne(b => b.User);
        
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}