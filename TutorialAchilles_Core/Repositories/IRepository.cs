using System.Collections.Generic;

namespace TutorialAchilles_Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        T GetById(int id);
        int Save(T entity);
        int Delete(int id);
    }
}