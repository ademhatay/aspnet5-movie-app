using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Film başlığı eklemelisiniz.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Başlık alanı en az 5 karakter en fazla 50 karakter olmalıdır.")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Film açıklaması eklemelisiniz.")]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Players { get; set; }
        [DisplayName("Resim URL")]
        [Required(ErrorMessage = "Film resmi eklemelisiniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Film türü seçmelisiniz.")]
        public int GenreId { get; set; } // 0
    }
}
