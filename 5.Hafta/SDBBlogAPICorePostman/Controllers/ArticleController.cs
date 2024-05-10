using Microsoft.AspNetCore.Mvc;
using SDBBlogAPICorePostman.DTO;
using SDBBlogAPICorePostman.Models;

namespace SDBBlogAPICorePostman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private static List<Article> articles = new List<Article>
        {
            new Article { Id = 1, Title = "ASP.NET Core ile Web API Geliştirme", 
                Content = "Bu makalede ASP.NET Core ile Web API geliştirmenin temellerini öğreneceksiniz." },
            new Article { Id = 2, Title = "Postman Kullanımı", 
                Content = "Postman ile API testlerini nasıl yapabileceğinizi öğreneceksiniz." }
        };
        private static int index = articles.Count+1;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Article>))]
        public ActionResult<IEnumerable<Article>> GetArticles()
        {
            return Ok(articles);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Article))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [Produces("text/plain", "application/json")]
        public ActionResult<Article> GetArticle(int id)
        {
            var article = articles.Find(a => a.Id == id);
            if (article == null)
            {
                return NotFound("There is no content for this id");
            }
            return Ok(article);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Article))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [Consumes(typeof(ArticleDto), "application/json")]
        public ActionResult<Article> CreateArticle([FromBody] ArticleDto dto)
        {
            if (string.IsNullOrEmpty(dto.Title))
            {
                return BadRequest("Article title cannot be empty");
            }

            var article = new Article
            {
                Id = index++,
                Title = dto.Title,
                Content = dto.Content,

            };

            articles.Add(article);

            return Ok(article);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Article))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [Consumes(typeof(ArticleDto), "application/json")]
        public IActionResult UpdateArticle(int id, [FromBody] ArticleDto dto)
        {
            if (string.IsNullOrEmpty(dto.Title))
            {
                return BadRequest("Article title cannot be empty");
            }

            var existingArticle = articles.Find(a => a.Id == id);
            if (existingArticle == null)
            {
                return NotFound();
            }

            existingArticle.Title = dto.Title;
            existingArticle.Content = dto.Content;

            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Article))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteArticle(int id)
        {
            var article = articles.Find(a => a.Id == id);
            if (article == null)
            {
                return NoContent();
            }

            articles.Remove(article);
            return Ok();
        }
    }
}
