using IdentityServer3.Core.Configuration;
using Microsoft.Owin;
using Owin;
using Pro.IdentityServer.Configuration;
using proj.Identityserver;
using proj.Identityserver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(StartUp))]

namespace proj.Identityserver
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            var factory = new IdentityServerServiceFactory()
                .UseInMemoryScopes(Scopes.Get())
                .UseInMemoryClients(Clients.Get())
                .UseInMemoryUsers(Users.Get());

            var options = new IdentityServerOptions
            {
                RequireSsl = false,
                Factory = factory,
                SigningCertificate = Certificate.Load()
            };

            //setting up the Owin for the Identity Server
            app.Map("/ids", idsrvapp =>
            {
                idsrvapp.UseIdentityServer(options);
            });
        }
    }
}