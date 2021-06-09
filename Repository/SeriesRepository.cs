using System.Collections.Generic;
using DIO.Series.Models;
using DIO.Series.Repository.Interfaces;

namespace DIO.Series.Repository
{
  public class SeriesRepository : ISeriesRepository<Serie>
  {
    public readonly List<Serie> _serieList;

    public SeriesRepository(List<Serie> serieList)
    {
      this._serieList = serieList;
    }
    
    public void Edit(int id, Serie entity)
    {
      _serieList[id] = entity;
    }

    public void Delete(int id)
    {
      _serieList[id].Invalidate();
    }

    public void Insert(Serie entity)
    {
      _serieList.Add(entity);
    }

    public List<Serie> GetAll()
    {
      return _serieList.FindAll(
        serie => serie.Valid == true
      );
    }

    public int NextId()
    {
      return _serieList.Count + 1;
    }

    public Serie GetById(int id)
    {
      return _serieList[id];
    }
  }
}