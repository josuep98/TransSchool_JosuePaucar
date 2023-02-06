using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int Id);//borrado físico
        IEnumerable<TEntity> GetAll();//Lista toda la entidad
        TEntity GetById(int Id);
    }
}
