using AppConsole.Menu.Strategies;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Menu
{
    public class MenuModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ConsoleMenu>();
            builder.RegisterType<ListerSemainesMenuStrategy>().Keyed<IMenuStrategy>("1").As<IMenuStrategy>();
            builder.RegisterType<AjouterSemaineMenuStrategy>().Keyed<IMenuStrategy>("2").As<IMenuStrategy>(); ;
            builder.RegisterType<QuitterAppliMenuStrategy>().Keyed<IMenuStrategy>("3").As<IMenuStrategy>(); ;

        }
    }
}
