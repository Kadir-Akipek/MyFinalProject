using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    //Autofac ile startup'ta yazdıklarımızı, yapmamızı sağlayan ortamı kuruyoruz. Autofac bize aynı zamanda AOP desteği verir
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder) //override ile sanal metodları yazarız
        {
            //RegisterType, services.AddSingleton'a karşılık gelir
            //Bu yazdığımız yapı Data tutmamaktadır o yüzden bir instance üretip onu tüm kullanıcılara verebiliriz
            builder.RegisterType<ProductManager>().As<IProductService>(); //Birisi constructor'da senden IProductService isterse ona bir tane ProductManager instance'ı ver
            builder.RegisterType<EfProductDal>().As<IProductDal>(); //Birisi IProductDal isterse ona EfProductDal ver

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
