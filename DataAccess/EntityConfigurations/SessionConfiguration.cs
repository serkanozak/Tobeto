using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class SessionConfiguration
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.ToTable("Sessions").HasKey(a => a.Id);
        
        builder.Property(a => a.InstructorId).HasColumnName("InstructorId").IsRequired();
        builder.Property(a => a.LiveContentId).HasColumnName("LiveContentId").IsRequired();
        builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
        builder.Property(a => a.ImageUrl).HasColumnName("ImageUrl").IsRequired();
        builder.Property(a => a.StartDate).HasColumnName("StartDate").IsRequired();
        builder.Property(a => a.EndDate).HasColumnName("EndDate").IsRequired();
        builder.Property(a => a.RecordUrl).HasColumnName("RecordUrl").IsRequired();
        builder.Property(a => a.SessionLinkUrl).HasColumnName("SessionLinkUrl").IsRequired();
        
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        
        builder.HasOne(b => b.Instructor);
        builder.HasOne(b => b.LiveContent);
        
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}