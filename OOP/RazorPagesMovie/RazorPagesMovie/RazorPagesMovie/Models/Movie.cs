using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } // Id property is nodig als primary key?
        public string? Title { get; set; } // ? is to make it nullable
        [DataType(DataType.Date)] // specificeerd het type data in de ReleaseDate property
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }


    }
}
