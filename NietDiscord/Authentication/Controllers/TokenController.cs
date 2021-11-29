﻿using Authentication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;

namespace Authentication.Controllers
{
    public class TokenController
    {
        private const string SECRET_KEY = "this is my custom Secret key for authnetication";
        public static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenController.SECRET_KEY));

        public object CreateToken(string username)
        {
            if (username != null)
            {
                return new ObjectResult(GenerateToken(username));
            }
            else
            {
                return new BadRequestResult();
            }
        }

        private object GenerateToken(string email)
        {
            var token = new JwtSecurityToken(
                claims: new Claim[]
                {
                    new Claim("email", email)
                },
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: new SigningCredentials(SIGNING_KEY, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public List<Claim> readOut(string test)
        {
            List<Claim> data = new List<Claim>();

            var token = test;
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);

            foreach (Claim c in jwtSecurityToken.Claims)
            {
                data.Add(c);
            }
            return data;
        }

        public string isExpired(string test)
        {
            //string[] split = test.Split(" ");

            //var token = split[1];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(test);

            if (jwtSecurityToken.ValidFrom > DateTime.Now.AddHours(-3) && jwtSecurityToken.ValidTo < DateTime.Now.AddHours(-1))
            {
                //is valid
                //return split[1];
                return test;
            }
            else
            {
                //is expired
                List<string> temp = new List<string>();
                User u = new User();

                foreach (Claim c in jwtSecurityToken.Claims)
                {
                    if (c.Type == "email")
                    {
                        u.email = c.Value;
                    }
                }
                //Newly generated token when old token was expired
                object newToken = GenerateToken(u.email);
                string jsonToken = newToken.ToString();
                return jsonToken;
            }
        }

        public string nonExistentToken(string email)
        {
            var x = GenerateToken(email);
            return x.ToString();
        }
    }
}
