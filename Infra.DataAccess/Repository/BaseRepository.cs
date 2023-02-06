using Dominio.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                //Nombre BD
                using (var context = new TransSchoolJosuePaucarEntities())//Crea una variable en memoria y luego la elimina para que no se queden hilos de comunicación con BD
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el registro: " + ex);
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                //Nombre BD
                using (var context = new TransSchoolJosuePaucarEntities())//Crea una variable en memoria y luego la elimina para que no se queden hilos de comunicación con BD
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar el registro: " + ex);
            }
        }

        public void Delete(int Id)
        {
            try
            {
                using (var context = new TransSchoolJosuePaucarEntities())
                {
                    var entity = context.Set<TEntity>().Find(Id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el registro: " + ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new TransSchoolJosuePaucarEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar los registros: " + ex);
            }
        }

        public TEntity GetById(int Id)
        {
            try
            {
                using (var context = new TransSchoolJosuePaucarEntities())
                {
                    return context.Set<TEntity>().Find(Id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo obtener el registro por Id: " + ex);
            }
        }

        public void Dispose()
        {
            //Acción que se ejecuta por defecto adicional
            throw new NotImplementedException();
        }
    }
}
