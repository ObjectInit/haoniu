using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoNiu.FrameWork.System.Domain.Repository
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
