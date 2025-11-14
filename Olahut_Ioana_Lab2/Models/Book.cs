using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olahut_Ioana_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        
        [Required(ErrorMessage = "Titlul este obligatoriu.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul trebuie sa aiba intre 3 si 150 de caractere.")] 
        public string Title { get; set; }
        public int? AuthorID { get; set; }  
        public Author? Author { get; set; } 

        [Column(TypeName = "decimal(6, 2)")] [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }   
        public Publisher? Publisher { get; set; }
        [Display(Name = "Categories")]  

        public ICollection<Borrowing>? Borrowings { get; set; } 
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
