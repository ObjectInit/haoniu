using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaoNiu.FrameWork.System.Domain;

namespace HaoNiu.Rpc.User.Repositories
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {

    }
}
