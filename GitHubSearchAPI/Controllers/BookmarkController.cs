using GitHubSearchAPI.Interfaces;
using GitHubSearchAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubSearchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookmarkController : ControllerBase
    {
        private readonly IBookmarkService _bookmarkService;

        public BookmarkController(IBookmarkService bookmarkService)
        {
            _bookmarkService = bookmarkService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bookmark>>> Get()
        {
            var bookmarks = await _bookmarkService.GetBookmarks();
            return Ok(bookmarks);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(Bookmark bookmark)
        {
            var id = await _bookmarkService.CreateBookmark(bookmark);
            return Ok(id);
        }
    }
}
