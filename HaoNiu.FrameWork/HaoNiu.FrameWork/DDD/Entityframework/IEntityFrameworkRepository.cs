using HaoNiu.FrameWork.DDD.Domain;
using HaoNiu.FrameWork.DDD.Repository;

namespace HaoNiu.FrameWork.DDD.Entityframework
{
    public interface IEntityFrameworkRepository<TAggregateRoot>: IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {

    }
}
