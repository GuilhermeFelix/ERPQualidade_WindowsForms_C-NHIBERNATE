using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate_PostGreSQLDAL
{
    public class RepositoryConnectDAOCapabilidade_ferramentademedicao<T> : IConnectDAO<T> where T : class
    {
        public void Alterar(T entidade)
        {

            using (ISession session = Capabilidade_ferramentademedicao_SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Atualizar Entidades: " + ex.Message);
                    }
                }
            }
        }

        public IList<T> Consultar()
        {
            using (ISession session = Capabilidade_ferramentademedicao_SessionFactory.AbrirSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = Capabilidade_ferramentademedicao_SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Excluir Entidades: " + ex.Message);
                    }
                }
            }
        }

        public void Inserir(T entidade)
        {
            using (ISession session = Capabilidade_ferramentademedicao_SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch(Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Inserir Entidades: " + ex.Message);
                    }
                }
            }
        }
        public T RetornarPorId(int id)
        {
            using (ISession session = Capabilidade_ferramentademedicao_SessionFactory.AbrirSession())
            {
                return session.Get<T>(id);
            }
        }

    }
}
