using GitHubSearchAPI.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GitHubSearchAPI.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("[controller]")]
    public class GithubSearchController : ControllerBase
    {
        private readonly IGithubSearchService _githubSearchService;

        public GithubSearchController(IGithubSearchService githubSearchService)
        {
            _githubSearchService = githubSearchService;
        }

        [HttpGet("api/search")]
        public async Task<IActionResult> SearchRepositories(string query)
        {
            var response = await _githubSearchService.SearchRepositories(query);
            var content = await response.Content.ReadAsStringAsync();
            return Ok(content);
        }
    }
}
