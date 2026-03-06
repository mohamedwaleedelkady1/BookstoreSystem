// Q1: "Id" becomes a Primary Key by convention — EF Core automatically treats any property named "Id" as a PK.
// Q2: "Country" is string? (nullable) so it allows nulls. "Price" is decimal (value type) so it's NOT NULL.

using System;

namespace BookstoreSystem.Models
{
    public class Book
    {
        public int Id { get; set; }                  // PK by convention
        public string Title { get; set; }            // Configured via Fluent API
        public decimal Price { get; set; }           // NOT NULL (value type)
        public DateTime? PublishedDate { get; set; } // Optional (nullable)
    }
}
