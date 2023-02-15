namespace RazorNETMySQL.Models
{
    //This has a many-to-one relationship with Movie and Actor
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }

    }
}
