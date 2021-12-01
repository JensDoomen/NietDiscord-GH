using System;
using Xunit;
using Authentication.Controllers;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Authentication.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NietDiscordTest
{
    public class AuthenticationTest
    {
        private AuthenticationController Initialize([CallerMemberName] string callerName = "")
        {
            var options = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "InMemoryProductDb_" + callerName).Options;
            var context = new DataContext(options);
            SeedProductInMemoryDatabaseWithData(context);
            return new AuthenticationController(context);
        }
        private TokenController InitializeToken([CallerMemberName] string callerName = "")
        {
            var options = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "InMemoryProductDb_" + callerName).Options;
            var context = new DataContext(options);
            SeedProductInMemoryDatabaseWithData(context);
            return new TokenController();
        }


        private void SeedProductInMemoryDatabaseWithData(DataContext context)
        {
            var Users = new List<User>
            {
                new User { userId = 1, name = "Henk", email = "Henk@test.nl", password = "SpaRood23" },
                new User { userId = 2, name = "Pieter", email = "Pieter@test.nl", password = "DikkeBeer58"},
                new User { userId = 3, name = "Gertje", email = "Gertje@test.nl", password = "Jonkerd"},
                new User { userId = 4, name = null, password = null, },
            };
            if (!context.Users.Any())
            {
                context.Users.AddRange(Users);
            }
            context.SaveChanges();
        }
        [Fact]
        private void LoginNoUser_shouldnotloginuser()
        {
            
        }

        [Fact]
        private void LoginUser_shouldloginuser()
        {
            var controller = Initialize();
            var usermodel = Users.Elementat(2);
            var result = controller.login(Authorization, usermodel);
            Assert.IsType<CreatedResult>(result);
        }

        [Fact]
        private void LoginNoToken_shouldnotloginuser()
        {
            var controller = Initialize();
            var usermodel = new User();

            var result = controller.loginNoToken("Henk@test.nl", "SpaRood");
            Assert.IsType<CreatedResult>(result);
        }

        [Fact]
        private void RegisterNull_shouldnotregisteruser()
        {

        }


        [Fact]
        private void Register_shouldregisteruser()
        {

        }

        [Fact]
        private void GetUser_shouldgetuser()
        {

        }

        [Fact]
        private void CreateTokenNull_shouldnotcreatetoken()
        {

        }

        [Fact]
        private void CreateToken_shouldcreatetoken()
        {

        }

        [Fact]
        private void GenerateToken_shouldgenereatetoken()
        {

        }

        [Fact]
        private void ReadOut_shouldreadouttoken()
        {

        }

        [Fact]
        private void isExpired_shouldcreatenewtoken()
        {

        }

        [Fact]
        private void NonexistentToken_shouldgeneratenewtoken()
        {
            var controller = InitializeToken();
           
            var result = controller.nonExistentToken("Henk@test.nl");
            Assert.IsType<CreatedResult>(result);
        }


    }
}
