using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class StudentConfiguration
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students").HasKey(a => a.Id);
        
        builder.Property(a => a.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasOne(b => b.User);
        builder.HasMany(b => b.Surveys);
        builder.HasMany(b => b.CourseExams);
        
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}