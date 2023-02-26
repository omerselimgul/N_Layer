using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //AOS yapılandırması 
        protected override void Load(ContainerBuilder builder)
        {
            // IProductServise istenilirse product MAnager new'le ve ver
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDao>().SingleInstance();

        }
    }
}
