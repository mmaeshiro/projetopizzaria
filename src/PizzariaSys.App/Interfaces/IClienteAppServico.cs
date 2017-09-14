using PizzariaSys.App.ViewModels;
using PizzariaSys.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace PizzariaSys.App.Interfaces
{
    public interface IClienteAppServico
    {
        void Inserir(ClienteViewModel model);

        void Alterar(ClienteViewModel model);

        void Deletar(ClienteViewModel model);

        ClienteViewModel BuscarPorId(int id);

        IEnumerable<ClienteViewModel> ListarTodos();

        void Commit();

        ClienteViewModel ListarClienteTelefone(string numeroTelefone);
    }
}
