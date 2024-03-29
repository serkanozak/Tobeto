using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CourseCategoryConfiguration
{
    public void Configure(EntityTypeBuilder<CourseCategory> builder)
    {
        builder.ToTable("CourseCategories").HasKey(a => a.Id);
        
        builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasMany(b => b.CourseDetails);
        
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}