using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
[assembly: OwinStartupAttribute(typeof(IntexNorthwestLabs.Startup))]

namespace IntexNorthwestLabs
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {

        }
    }
}