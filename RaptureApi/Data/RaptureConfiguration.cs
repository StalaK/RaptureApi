using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaptureApi.Models;

namespace RaptureApi.Data
{
    public class RaptureConfiguration : IEntityTypeConfiguration<Rapture>
    {
        public void Configure(EntityTypeBuilder<Rapture> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(p => p.RaptureStartDate)
                .IsRequired(true)
                .HasColumnType("datetime")
                .HasColumnName("StartDate");

            builder.Property(p => p.RaptureEndDate)
                .IsRequired(true)
                .HasColumnType("datetime")
                .HasColumnName("EndDate");

            builder.Property(p => p.Predictor)
                .IsRequired(true)
                .HasColumnType("nvarchar(500)")
                .HasColumnName("Predictor");

            builder.Property(p => p.Details)
                .IsRequired(true)
                .HasColumnType("nvarchar(max)")
                .HasColumnName("Details");

            builder.Property(p => p.WhoGotRaptured)
                .IsRequired(false)
                .HasColumnType("nvarchar(500)")
                .HasColumnName("WhoGotRaptured")
                .HasDefaultValue(string.Empty);

            builder.Property(p => p.MonthOnly)
                .IsRequired(true)
                .HasDefaultValue(false)
                .HasColumnName("MonthOnly")
                .HasColumnType("bit");

            builder.Property(p => p.YearOnly)
                .IsRequired(true)
                .HasDefaultValue(false)
                .HasColumnName("YearOnly")
                .HasColumnType("bit");
        }
    }
}
