using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golrang.Framework.Domain;

namespace Golrang.Framework.Infra
{
    public interface BaseRepository<T> where T :BaseEntity
    {
        void Add(T entity);
        void Remove(int id);

        T Get(int id);
        List<T> Get();
    }
}
