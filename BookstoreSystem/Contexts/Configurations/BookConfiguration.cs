using BookstoreSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreSystem.Contexts.Configurations
{
    // One configuration class per entity (clean Fluent API approach)
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(b => b.Price)
                   .IsRequired()
                   .HasColumnType("decimal(8,2)");

            builder.Property(b => b.PublishedDate)
                   .IsRequired(false); // Explicitly optional
        }
    }
}
