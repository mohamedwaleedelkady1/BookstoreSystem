using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreSystem.Models
{
    [Table("Writers")] // Table name in DB will be "Writers"
    public class Author
    {
        public int Id { get; set; } // PK by convention

        [Required]       // NOT NULL in DB
        [MaxLength(100)] // nvarchar(100) in DB
        public string Name { get; set; }

        public string Country { get; set; } // Nullable (reference type, no annotation = nullable)
    }
}
