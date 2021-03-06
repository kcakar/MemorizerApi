﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Memorizer.Data;
using Microsoft.EntityFrameworkCore;
using GraphiQl;

namespace Memorizer.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                //.AddJwtBearer(
                //    options =>
                //    {
                //        options.Authority = "https://securetoken.google.com/react-workout";
                //        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                //        {
                //            ValidateIssuer=true,
                //            ValidIssuer= "https://securetoken.google.com/react-workout",
                //            ValidateAudience=true,
                //            ValidAudience= "react-workout",
                //            ValidateLifetime=true
                //        };
                //    }
                //);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<MemorizerContext>(opt => opt.UseInMemoryDatabase("MemorizerDb"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseGraphiQl();

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {

                var db = serviceScope.ServiceProvider.GetService<MemorizerContext>();
                Memorizer.Core.DataSeed.Run(db);
            }

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
