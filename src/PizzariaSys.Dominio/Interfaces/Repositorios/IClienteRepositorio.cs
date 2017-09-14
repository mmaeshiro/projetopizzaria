using PizzariaSys.Dominio.Entidades;
using PizzariaSys.Dominio.Interfaces.Repositorios.Core;

namespace PizzariaSys.Dominio.Interfaces.Repositorios
{
    // metodos especificos de cliente para o Banco Dados
    public interface IClienteRepositorio: IRepositorioBase<Cliente>
    {
        Cliente BuscarClientePorTelefone(string numeroTelefone);
    }
}
