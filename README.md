### GitHub Search API
This is a .NET Core 7 web API for searching GitHub repositories.

### Installation
To use this API, you'll need to have .NET Core 7 installed on your machine. You can download it here.

- Clone this repository: git clone https://github.com/yourusername/GitHubSearchAPI.git
- Navigate to the project directory: cd GitHubSearchAPI
- Build the project: dotnet build
- Run the project: dotnet run

### Usage
#### Authentication
To use the API, you need to authenticate first. Send a POST request to /Auth/login with the following JSON in the request body:
{
  "username": "root",
  "password": "123456"
}
If the authentication is successful, the response will include a JSON Web Token (JWT) that you can use to access the other endpoints.

#### Search Repositories
To search for repositories on GitHub, send a GET request to /GithubSearch/api/search with the following header:
Authorization: Bearer <your-JWT-token>
And the following query parameter: query=<your-query>
For example, to search for repositories that contain the word "python", send a GET request to /GithubSearch/api/search?query=python.

If the search is successful, the response will include the content of the search result.


