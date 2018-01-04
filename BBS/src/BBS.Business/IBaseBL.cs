using System.Collections.Generic;

namespace BBS.Business
{
    // implement crud operaitons to base
    interface IBaseBL<T> 
    {
        List<T> GetAll();

        T Find(int id);

        T Create(T obj);

        T Update(T obj);

        bool Delete(int id);
    }
}
