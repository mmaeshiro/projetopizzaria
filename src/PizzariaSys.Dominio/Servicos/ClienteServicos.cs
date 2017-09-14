using PizzariaSys.Dominio.Entidades;
using PizzariaSys.Dominio.Interfaces.Repositorios;
using PizzariaSys.Dominio.Interfaces.Servicos;
using PizzariaSys.Dominio.Servicos.Core;
using System.Linq;

namespace PizzariaSys.Dominio.Servicos
{
    public class ClienteServicos: ServicosBase<Cliente>,IClienteServicos 
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServicos(IClienteRepositorio clienteRepositorio)
            :base(clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente ListarClienteTelefone(string param)
        {
            //var cliente = _clienteRepositorio.ListarTodos().FirstOrDefault(x => x.TelefoneFixo == param || x.TelefoneCelular == param);

            var cliente = _clienteRepositorio.BuscarClientePorTelefone(param);


            return cliente;
        }
    }
}
