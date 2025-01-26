
using DominoAvancadoComEf.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominoAvancadoComEf.DB
{
    internal sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            // Setup PK
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedNever();

            // Dates
            builder.Property(o => o.StartDate)
                .IsRequired()
                .HasConversion(o => o.ToUniversalTime(),
                               o => DateTime.SpecifyKind(o, DateTimeKind.Utc));

            builder.Property(o => o.EndDate)
                .IsRequired(false);

            // Enums
            builder.Property(o => o.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(o => o.OrderCreationMethod)
                .IsRequired()
                .HasConversion<string>();
        }
    }
}
