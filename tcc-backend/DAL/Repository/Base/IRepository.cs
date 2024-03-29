﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repository.Base
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> Adicionar(TEntity entity);
        Task<TEntity> GetObject(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetObjectTracking(Expression<Func<TEntity, bool>> predicate);
        TEntity GetObjectNoAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> BuscarTracking(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> ObterTodos();
        Task Remover(int id);
        bool Existe(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
        Task<TEntity> FindByKey(params object[] key);
        BancoAPIContext GetConexao();
        Task<TEntity> update(TEntity entity);
        void IniciaTransacao();
        void CommitTransacao();
        void RoolbackTransacao();
        bool JaExisteTrasacao();
        Task<int> GetSequecial(Expression<Func<TEntity, bool>> predicate);
    }
}
