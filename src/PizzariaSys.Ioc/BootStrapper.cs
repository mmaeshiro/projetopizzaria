using PizzariaSys.AcessoDados.Contexto;
using PizzariaSys.AcessoDados.Repositorios;
using PizzariaSys.AcessoDados.Repositorios.Core;
using PizzariaSys.App.Interfaces;
using PizzariaSys.App.Servicos;
using PizzariaSys.Dominio.Interfaces.Repositorios;
using PizzariaSys.Dominio.Interfaces.Repositorios.Core;
using PizzariaSys.Dominio.Interfaces.Servicos;
using PizzariaSys.Dominio.Interfaces.Servicos.Core;
using PizzariaSys.Dominio.Servicos;
using PizzariaSys.Dominio.Servicos.Core;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSys.Ioc
{
    public static class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //Aplicacao--------------------
            container.Register<IClienteAppServico, ClienteAppServico>(Lifestyle.Scoped);

            //Dominio----------------------
            container.Register(typeof(IServicosBase<>), typeof(ServicosBase<>));
            container.Register<IClienteServicos, ClienteServicos>(Lifestyle.Scoped);

            //Repositorio-------------------
            //quando generico add typeof
            container.Register(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            //especifico não precisa
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Scoped);

            //Contexto----------------------
            container.Register<EfContexto,EfContexto>(Lifestyle.Scoped);
        }
    }
}
