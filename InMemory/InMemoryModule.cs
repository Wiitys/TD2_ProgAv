using Autofac;
using TD2.Interfaces;
using TD2.Models;
using TD2.Services;

namespace InMemory
{
    public class InMemoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<SemaineService>().As<ISemaineService>();

            builder.RegisterType<CoursService>().As<ICoursService>();

        }


    }
}
