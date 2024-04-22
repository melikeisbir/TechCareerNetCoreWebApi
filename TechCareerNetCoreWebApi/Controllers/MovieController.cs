using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareerNetCoreWebApi.Data;
using TechCareerNetCoreWebApi.Models;

namespace TechCareerNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        ApplicationDbContext context;

        public MovieController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> FilmleriGetir()
        {
            List<Movie> movieListesi;
            //SqlConnection
            //Command command = new Command("select * from Movie",conn);
            movieListesi = await context.Movie.ToListAsync();

            return movieListesi;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Movie>>> FilmEkle(Movie movie)
        {
            try
            {
                context.Movie.Add(movie);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return Ok();
        }
    }
}
