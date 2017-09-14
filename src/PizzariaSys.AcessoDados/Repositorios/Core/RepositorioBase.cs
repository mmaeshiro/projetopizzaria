using PizzariaSys.AcessoDados.Contexto;
using System.Data.Entity;
using System.Linq;
using PizzariaSys.Dominio.Interfaces.Repositorios.Core;
using System;

namespace PizzariaSys.AcessoDados.Repositorios.Core
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        protected EfContexto _db;
        //Injeção de independença
        public RepositorioBase(EfContexto db)
        {
            _db = db;
        }

        public void Alterar(T entidade)
        {
            _db.Entry(entidade).State = EntityState.Modified;
        }

        public T BuscarPorId(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Deletar(T entidade)
        {
            _db.Set<T>.Remove(entidade);
        }

        public void Inserir(T entidade)
        {
            _db.Set<T>().Add(entidade);
        }

        public IQueryable<T> ListarTodos()
        {
            return _db.Set<T>();
        }
    }
}
