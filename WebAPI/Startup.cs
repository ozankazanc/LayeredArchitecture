using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
            //Autofac,Ninject,CastleWindsor,StructureMap,LightInject,DryInject -->IoC Container
            //Bunlar IoC Container sa�layan �r�nler
            
            
            services.AddControllers();
            //Bana arkaplanda bir referans olu�tur.
            //Birisi senden IProductService isterse ona bir tane arkaplanda ProductManager olu�tur onu ver.
            //E�er bir ba��ml�l�k g�r�rsen kar��l��� budur.
            //Arkaplanda bizim i�in ProductManager'� new liyor.
            //Singleton'�, i�erisinde data tutmuyorsak kullan�yoruz. Sepet gibi bir yap�da kullanm�yoruz mesela.
            
            //----Autofac ile yoruma al�nd�, buraya gerek kalmad�.----
            //services.AddSingleton<IProductService,ProductManager>();
            //services.AddSingleton<IProductDal, EFProductDal>();
            //--------------------------------------------------------

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
