using System.Collections.Generic;
using System.Linq;

namespace PizzariaSys.Dominio.Interfaces.Repositorios.Core


{
    //Repositorio de metodos generico
    public interface IRepositorioBase<T> where T :class
    {
        void Inserir(T entidade);

        void Alterar(T entidade);

        void Deletar(T entidade);

        T BuscarPorId(int id);

        IQueryable<T> ListarTodos();

        void Commit();
    }
}
