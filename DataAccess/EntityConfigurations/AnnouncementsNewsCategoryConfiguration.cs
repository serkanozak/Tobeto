using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class AnnouncementsNewsCategoryConfiguration
{
    public void Configure(EntityTypeBuilder<AnnouncementsNewsCategory> builder)
    {
        builder.ToTable("AnnouncementsNewsCategories").HasKey(a => a.Id);
        
        builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate"); 
        
        builder.HasMany(s => s.Announcements);
        builder.HasMany(s => s.News);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }

}