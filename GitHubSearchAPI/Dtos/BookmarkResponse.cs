namespace GitHubSearchAPI.Dtos
{
    public class BookmarkResponse
    {
        public string RepositoryName { get; set; }
        public string OwnerAvatarUrl { get; set; }
        public string HtmlUrl { get; set; }

        public BookmarkResponse(string repositoryName, string ownerAvatarUrl, string htmlUrl)
        {
            RepositoryName = repositoryName;
            OwnerAvatarUrl = ownerAvatarUrl;
            HtmlUrl = htmlUrl;
        }
    }
}
