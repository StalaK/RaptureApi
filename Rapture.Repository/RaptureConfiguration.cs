using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rapture.Common.Models;

namespace Rapture.Repository
{
    internal class RaptureConfiguration : IEntityTypeConfiguration<RaptureModel>
    {
        public void Configure(EntityTypeBuilder<RaptureModel> builder)
        {
            builder.ToTable("Raptures");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("INTEGER");

            builder.Property(p => p.RaptureStartDate)
                .IsRequired(true)
                .HasColumnType("TEXT")
                .HasColumnName("StartDate");

            builder.Property(p => p.RaptureEndDate)
                .IsRequired(true)
                .HasColumnType("TEXT")
                .HasColumnName("EndDate");

            builder.Property(p => p.Predictor)
                .IsRequired(true)
                .HasColumnType("TEXT")
                .HasColumnName("Predictor");

            builder.Property(p => p.Details)
                .IsRequired(true)
                .HasColumnType("TEXT")
                .HasColumnName("Details");

            builder.Property(p => p.WhoGotRaptured)
                .IsRequired(false)
                .HasColumnType("TEXT")
                .HasColumnName("WhoGotRaptured")
                .HasDefaultValue(string.Empty);

            builder.Property(p => p.MonthOnly)
                .IsRequired(true)
                .HasDefaultValue(false)
                .HasColumnName("MonthOnly")
                .HasColumnType("INTEGER");

            builder.Property(p => p.YearOnly)
                .IsRequired(true)
                .HasDefaultValue(false)
                .HasColumnName("YearOnly")
                .HasColumnType("INTEGER");
        }
    }
}
