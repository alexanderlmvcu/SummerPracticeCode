﻿using MedRemind.NHibernate.Base;
using MedRemind.NHibernate.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate
{
    public class NHibernateRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly ISession _session;

        public NHibernateRepository(
            ISession session
        )
        {
            _session = session;
        }

        public TEntity Add(TEntity entity)
        {
            _session.Save(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }

        public TEntity Get(int id)
        {
            return _session.Get<TEntity>(id);
        }

        public IQueryOver<TEntity, TEntity> GetQueryOver()
        {
            return _session.QueryOver<TEntity>();
        }

        public TEntity Update(TEntity entity)
        {
            _session.SaveOrUpdate(entity);
            return entity;
        }
    }
}