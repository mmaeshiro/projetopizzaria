using System;
using System.Linq;
using PizzariaSys.Dominio.Interfaces.Servicos.Core;
using PizzariaSys.Dominio.Interfaces.Repositorios.Core;

namespace PizzariaSys.Dominio.Servicos.Core
{
    public class ServicosBase<T> : IServicosBase<T> where T : class
    {
        private readonly IRepositorioBase<T> _repositorioBase;

        public ServicosBase(IRepositorioBase<T> repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public void Alterar(T entidade)
        {
            _repositorioBase.Alterar(entidade);
        }

        public T BuscarPorId(int id)
        {
           return _repositorioBase.BuscarPorId(id);
        }

        public void Commit()
        {
            _repositorioBase.Commit();
        }

        public void Deletar(T entidade)
        {
            _repositorioBase.Deletar(entidade);
        }

        public void Inserir(T entidade)
        {
            _repositorioBase.Inserir(entidade);
        }

        public IQueryable<T> ListarTodos()
        {
            return _repositorioBase.ListarTodos();
        }
    }
}
