using GitHubSearchAPI.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GitHubSearchAPI.Services
{
    public class GithubSearchService : IGithubSearchService
    {
        private readonly HttpClient _httpClient;

        public GithubSearchService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // Set the default request headers to accept JSON and include a User-Agent header
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            _httpClient.DefaultRequestHeaders.UserAgent.Clear();
            _httpClient.DefaultRequestHeaders.UserAgent.Add(
                new ProductInfoHeaderValue("GitHubSearchAPI", "1.0"));
        }

        public async Task<HttpResponseMessage> SearchRepositories(string query)
        {
            // Send a GET request to the GitHub Search API, passing in the query string
            var response = await _httpClient.GetAsync($"https://api.github.com/search/repositories?q={query}");

            // Return the response message to the caller
            return response;
        }
    }
}