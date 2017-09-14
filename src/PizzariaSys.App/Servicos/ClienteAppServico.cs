using PizzariaSys.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzariaSys.Dominio.Entidades;
using PizzariaSys.Dominio.Interfaces.Servicos;
using PizzariaSys.App.ViewModels;

namespace PizzariaSys.App.Servicos
{
    public class ClienteAppServico : IClienteAppServico
    {
        private readonly IClienteServicos _clienteServicos;

        public ClienteAppServico(IClienteServicos clienteServicos)
        {
            _clienteServicos = clienteServicos;
        }

        public void Alterar(ClienteViewModel model)
        {

            var cliente = new Cliente
            {
                Id = model.Id,
                Nome = model.Nome,
                Logradouro = model.Logradouro,
                Numero = model.Numero,
                Bairro = model.Bairro,
                TelefoneFixo = model.TelefoneFixo,
                TelefoneCelular = model.TelefoneCelular
            };

            _clienteServicos.Alterar(cliente);
        }

        public ClienteViewModel BuscarPorId(int id)
        {
            var cliente = _clienteServicos.BuscarPorId(id);

            var clienteViewModel = new ClienteViewModel(cliente);

            return clienteViewModel;
        }

        public void Commit()
        {
            _clienteServicos.Commit();
        }

        public void Deletar(ClienteViewModel model)
        {
            var cliente = new Cliente()
            {
                Id = model.Id,
                Nome = model.Nome,
                Logradouro = model.Logradouro,
                Numero = model.Numero,
                Bairro = model.Bairro,
                TelefoneFixo = model.TelefoneFixo,
                TelefoneCelular = model.TelefoneCelular
            };

            _clienteServicos.Deletar(cliente);
        }

        public void Inserir(ClienteViewModel model)
        {
            var cliente = new Cliente()
            {
                Nome = model.Nome,
                Logradouro = model.Logradouro,
                Numero = model.Numero,
                Bairro = model.Bairro,
                TelefoneFixo = model.TelefoneFixo,
                TelefoneCelular = model.TelefoneCelular
            };

            _clienteServicos.Inserir(cliente);
        }

        public ClienteViewModel ListarClienteTelefone(string numeroTelefone)
        {
            var cliente = _clienteServicos.ListarClienteTelefone(numeroTelefone);

            var clienteViewModel = new ClienteViewModel(cliente);

            return clienteViewModel;
        }

        public IEnumerable<ClienteViewModel> ListarTodos()
        {
            var clientes = _clienteServicos.ListarTodos();

            var lstClienteViewModel = new List<ClienteViewModel>();

            foreach (var cliente in clientes)
            {
                var clienteViewModel = new ClienteViewModel(cliente);

                lstClienteViewModel.Add(clienteViewModel);
            }

            return lstClienteViewModel;
        }
    }
}
