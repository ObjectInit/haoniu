using System;

namespace HaoNiu.FrameWork.DDD.Domain
{
    /// <summary>
    /// 实体接口 (聚合根是由实体和值对象组成的系统边界对象)
    /// </summary>
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
