using System.ComponentModel.DataAnnotations;

namespace Olahut_Ioana_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Name")]  
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}