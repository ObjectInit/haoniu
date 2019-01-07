using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoNiu.FrameWork.System.Domain
{
    /// <summary>
    /// 实体接口 (聚合根是由实体和值对象组成的系统边界对象)
    /// </summary>
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
