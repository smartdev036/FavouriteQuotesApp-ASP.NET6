using System.ComponentModel.DataAnnotations;

namespace FavouriteQuotesApp.Models
{
    public class Quote
    {
        public int Id { get; set; } // Primary Key

        [Required(ErrorMessage = "The Quote text is required.")]
        public string Text { get; set; }

        [Required(ErrorMessage = "The Author name is required.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        public string Description { get; set; }

        [Display(Name = "Quote")]
        public string DisplayText
        {
            get
            {
                if (Text.Length <= 16)
                {
                    return Text;
                }
                return Text.Substring(0, 16) + "...";
            }
        }
    }
}
