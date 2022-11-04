using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PE_Ex2.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required!")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Title is required!")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Publisher is required!")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        [DataType(DataType.Currency, ErrorMessage = "Price is not valid!")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }
    }
}
