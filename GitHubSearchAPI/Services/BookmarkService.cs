using GitHubSearchAPI.Interfaces;
using GitHubSearchAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BookmarkService : IBookmarkService
{
    private readonly List<Bookmark> _bookmarks;

    public BookmarkService()
    {
        _bookmarks = new List<Bookmark>();
    }

    public async Task<List<Bookmark>> GetBookmarks()
    {
        return await Task.FromResult(_bookmarks);
    }

    public async Task<Bookmark> GetBookmark(int id)
    {
        return await Task.FromResult(_bookmarks.FirstOrDefault(x => x.Id == id));
    }

    public async Task<int> CreateBookmark(Bookmark bookmark)
    {
        bookmark.Id = _bookmarks.Count + 1;
        _bookmarks.Add(bookmark);
        return await Task.FromResult(bookmark.Id);
    }

    public async Task UpdateBookmark(int id, Bookmark bookmark)
    {
        var existingBookmark = await GetBookmark(id);
        if (existingBookmark != null)
        {
            existingBookmark.Name = bookmark.Name;
            existingBookmark.Url = bookmark.Url;
        }
    }

    public async Task DeleteBookmark(int id)
    {
        var existingBookmark = await GetBookmark(id);
        if (existingBookmark != null)
        {
            _bookmarks.Remove(existingBookmark);
        }
    }
}