﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctionWebsite.Startup))]
namespace AuctionWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
