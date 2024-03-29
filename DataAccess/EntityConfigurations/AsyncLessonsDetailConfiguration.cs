using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class AsyncLessonsDetailConfiguration
{
    public void Configure(EntityTypeBuilder<AsyncLessonsDetail> builder)
    {
        builder.ToTable("AsyncLessonsDetails").HasKey(a => a.Id);
        
        builder.Property(a => a.AsyncLessonId).HasColumnName("AsyncLessonId").IsRequired();
        builder.Property(a => a.IsLiked).HasColumnName("IsLiked").IsRequired();
        builder.Property(a => a.SubType).HasColumnName("SubType").IsRequired();
        builder.Property(a => a.Category).HasColumnName("Category").IsRequired();
        builder.Property(a => a.Language).HasColumnName("Language").IsRequired();
        builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
        builder.Property(a => a.ProducingCompany).HasColumnName("ProducingCompany").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasOne(b => b.AsyncLessonsOfContent);
        
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}