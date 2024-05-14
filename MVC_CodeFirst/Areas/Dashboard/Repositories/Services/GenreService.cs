using MVC_CodeFirst.Areas.Dashboard.Repositories.Abstracts;
using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Areas.Dashboard.Repositories.Services
{
    public class GenreService : IGenreService
    {
        MovieProjectContext _movieProjectContext= new MovieProjectContext();
        public void  DeleteGenre(int id)
        {
           Genre deletedGenre=_movieProjectContext.Genres.Find(id); 
            _movieProjectContext.Genres.Remove(deletedGenre);
            _movieProjectContext.SaveChanges();
            
        }
    }
}
