using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaoNiu.FrameWork.DDD.Repository;

namespace HaoNiu.FrameWork.DDD.Entityframework
{
    /// <summary>
    /// EF上下文实现
    /// </summary>
    public class EntityFrameworkRepositoryContext:IRepositoryContext 
    {
        public void Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}
