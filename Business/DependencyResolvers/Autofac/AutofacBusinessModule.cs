using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //uygulama ayağa kalktıgında burası çalışıcak.
        protected override void Load(ContainerBuilder builder)
        {
            //Iproductservice istenirse ProductManager veriyoruz.
            //WebApi altında bulunan startup'tan bu katmana çektik.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EFProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
