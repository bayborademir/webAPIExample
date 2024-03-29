﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace RentACar.API
{
    public class BuildToken
    {
        public string CreateToken()
        {
            var bytes = Encoding.UTF8.GetBytes("defjelfaedsfghfdsfghfdghjhgfdfghjhgfdfghjhgfdfghjhgfdfghfdsfghfertyrewrwtyjuyhgfdfghfdfg");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(2), signingCredentials: credential);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);
        }
    }
}
