using GitHubSearchAPI.Interfaces;
using GitHubSearchAPI.Services;

public static class ServiceConfiguration
{
    public static void Configure(IServiceCollection services)
    {
        services.AddSingleton<IAuthService, AuthService>();
        services.AddHttpClient<IGithubSearchService, GithubSearchService>();
        services.AddSingleton<IJwtService, JwtService>();
    }
}