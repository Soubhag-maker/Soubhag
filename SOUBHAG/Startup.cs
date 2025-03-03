using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOUBHAG.Repository;
using SOUBHAG.Service;
using Microsoft.EntityFrameworkCore;
using SOUBHAG.Controllers;
using AutoMapper;
using SOUBHAG.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
//using Microsoft.Extensions.Hosting;



namespace SOUBHAG
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var key = Encoding.UTF8.GetBytes("test"); // Replace with a strong secret key

      

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // ✅ Add Distributed Memory Cache
            services.AddDistributedMemoryCache();

            // ✅ Add Session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddHttpContextAccessor(); // ✅ Required for accessing HttpContext


            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<Iba1300Repository, ba1300Repository>();
            services.AddScoped<Iba1300Service, ba1300Service>();

            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginService, LoginService>();

            var profiles = typeof(ValuesController).Assembly.GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);


            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           

                app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader()
    );
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }


                app.UseAuthentication();
                app.UseCookiePolicy();

                // app.UseHttpsRedirection();
                app.UseMvc();



            
    }
    }
}
