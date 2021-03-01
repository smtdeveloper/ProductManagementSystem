using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstrack
{
    // generic Constraint 
    // class : Referans tip olabilir
    // IEntity : classını imlanet edenler olanlar olabilir
    // new() ; newlwne bilmeli

    public interface IEntityRepository<T> where T:class ,IEntity,new()
    {

       
        List<T> GetAll(Expression<Func<T , bool >> filter=null);

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity );
        void Update(T entity);
        void Delete(T entity);

  
    }
}
