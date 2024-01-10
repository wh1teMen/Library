using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя автора")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Имя автора должно быть больше 2х символов")]
        public string Autor { get; set; }
        [Range(1800,2023,ErrorMessage ="Недопустимая дата публикации")]
        public int? Year_of_publication { get; set; }
        [Range(1, 9000, ErrorMessage = "Недопустимое количесвто страниц")]
        public int? Number_of_pages { get; set; }
        public string? Description { get; set; }

    }
}
