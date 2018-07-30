using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace proj.Identityserver.Configuration
{
    public class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Subject = "1",
                    Username = "Li",
                    Password = "Password",
                    Claims = new Claim[]
                    {
                        new Claim(Constants.ClaimTypes.Name, "Ayo Dolani"),
                        new Claim(Constants.ClaimTypes.Email, "ay_boston@yahoo.com"),
                        new Claim(Constants.ClaimTypes.PhoneNumber, "07030748324"),
                        new Claim(Constants.ClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(Constants.ClaimTypes.Address, "Alagomeji, yaba, Lagos"),
                        new Claim(Constants.ClaimTypes.BirthDate, "1988-12-25"),
                        new Claim(Constants.ClaimTypes.Role, "Admin"),
                    }
                },
                new InMemoryUser
                {
                    Subject = "2",
                    Username = "Jet",
                    Password = "Password",
                    Claims = new Claim[]
                    {
                        new Claim(Constants.ClaimTypes.Name, "Jet Dane"),
                        new Claim(Constants.ClaimTypes.Email, "dane@yahoo.com"),
                        new Claim(Constants.ClaimTypes.PhoneNumber, "07030748324"),
                        new Claim(Constants.ClaimTypes.EmailVerified, "false", ClaimValueTypes.Boolean),
                        new Claim(Constants.ClaimTypes.Address, "yaba, Lagos"),
                        new Claim(Constants.ClaimTypes.BirthDate, "1900-12-25"),
                        new Claim(Constants.ClaimTypes.Role, "User")
                    }
                }
            };
        }
    }
}