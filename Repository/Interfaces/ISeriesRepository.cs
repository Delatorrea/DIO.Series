using System.Collections.Generic;

namespace DIO.Series.Repository.Interfaces
{
    public interface ISeriesRepository<T>
    {
         List<T> GetAll();
         T GetById(int id);
         void Insert(T entity);
         void Delete(int id);
         void Edit(int id, T entity);
         int NextId();
    }
}