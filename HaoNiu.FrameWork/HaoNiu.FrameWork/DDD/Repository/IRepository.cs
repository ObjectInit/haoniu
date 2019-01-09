using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaoNiu.FrameWork.DDD.Domain;

namespace HaoNiu.FrameWork.DDD.Repository
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {
        void Add(TAggregateRoot t);

        TAggregateRoot GetByKey(Guid key);
    }
}
