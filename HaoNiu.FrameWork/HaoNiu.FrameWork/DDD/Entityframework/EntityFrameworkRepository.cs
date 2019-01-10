using HaoNiu.FrameWork.DDD.Domain;
using HaoNiu.FrameWork.DDD.Repository;

namespace HaoNiu.FrameWork.DDD.Entityframework
{
    public abstract  class EntityFrameworkRepository<TAggregateRoot> : IEntityFrameworkRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {
    }
}
