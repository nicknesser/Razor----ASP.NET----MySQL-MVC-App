using System.ComponentModel.DataAnnotations;

namespace RazorNETMySQL.Models
{
    //This has a one-to-many relationship with Actors_Movies
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }


    }
}
