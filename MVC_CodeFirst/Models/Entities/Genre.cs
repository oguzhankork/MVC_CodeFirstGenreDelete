using MVC_CodeFirst.Models.Abstracts;

namespace MVC_CodeFirst.Models.Entities
{
    public class Genre:BaseClass
    {
        
        public string Name { get; set; }


        public static List<MovieGenre> MovieGenres { get; set; }

    }
}
