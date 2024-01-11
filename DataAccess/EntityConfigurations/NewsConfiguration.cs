using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class NewsConfiguration
{
    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder.ToTable("News").HasKey(a => a.Id);
        
        builder.Property(a => a.AnnouncementsNewsCategoryId).HasColumnName("AnnouncementsNewsCategoryIdId").IsRequired();
        builder.Property(a => a.ProjectId).HasColumnName("ProjectId").IsRequired();
        builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
        builder.Property(a => a.NewsContent).HasColumnName("NewsContent").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasOne(b => b.Project);
        builder.HasOne(b => b.AnnouncementsNewsCategory);
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}