using System.ComponentModel.DataAnnotations;

namespace RazorNETMySQL.Models
{
    //This class has a one-to-many relationship with Movies
    public class Cinema
    {
        [Key]

        public int CinemaId { get; set; }

        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
