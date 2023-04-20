using GitHubSearchAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubSearchAPI.Interfaces
{
    public interface IBookmarkService
    {
        Task<List<Bookmark>> GetBookmarks();
        Task<Bookmark> GetBookmark(int id);
        Task<int> CreateBookmark(Bookmark bookmark);
        Task UpdateBookmark(int id, Bookmark bookmark);
        Task DeleteBookmark(int id);
    }
}
