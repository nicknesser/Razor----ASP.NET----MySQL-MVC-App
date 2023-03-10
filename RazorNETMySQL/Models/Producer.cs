using System.ComponentModel.DataAnnotations;

namespace RazorNETMySQL.Models
{
    //This has a one-to-many relationship with movie
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }


    }
}
