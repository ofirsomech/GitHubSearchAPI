﻿using GitHubSearchAPI.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GitHubSearchAPI.Services
{
    public class JwtService : IJwtService
    {
        private readonly string _secretKey;
        private readonly int _expirationInYears;

        public JwtService(IConfiguration configuration)
        {
            _secretKey = configuration["Jwt:Key"];
            _expirationInYears = 1;
        }

        public string GenerateToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddYears(_expirationInYears),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
