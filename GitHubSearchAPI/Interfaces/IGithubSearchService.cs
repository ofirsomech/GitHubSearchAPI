using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubSearchAPI.Interfaces
{
    public interface IGithubSearchService
    {
        Task<HttpResponseMessage> SearchRepositories(string query);
    }
}
