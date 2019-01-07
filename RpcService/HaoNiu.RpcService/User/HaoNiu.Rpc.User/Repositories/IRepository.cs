using System;
using System.Collections.Generic;
using HaoNiu.FrameWork.System.Domain;

namespace HaoNiu.UserRpc.Domain.Repositories
{
    /// <summary>
    /// 仓储接口 只对聚合根进行操作
    /// </summary>
    /// <typeparam name="TAggregateRoot"></typeparam>
    public interface IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {
        /// <summary>
        /// 根据主键获取聚合根
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<TAggregateRoot> GetByKey(Guid key);
    }
}
