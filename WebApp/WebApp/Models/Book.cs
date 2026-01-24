using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Book
    {
        [Required(ErrorMessage ="Book id is required")]
        public int BId {  get; set; }
        [Required(ErrorMessage ="Title is required")]
        [Display(Name = "Book Name")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Author name is required")]
        [Display(Name = "Author Name")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        public int Price { get; set; }
    }
}
