using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoNiu.FrameWork.DDD.Repository
{
    /// <summary>
    /// 仓储上下文
    /// </summary>
    public interface IRepositoryContext
    {
        void Get<T>();
    }
}
