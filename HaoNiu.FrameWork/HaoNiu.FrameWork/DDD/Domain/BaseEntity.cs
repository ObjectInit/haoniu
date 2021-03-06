﻿using System;

namespace HaoNiu.FrameWork.DDD.Domain
{
    /// <summary>
    /// 基础实体类
    /// </summary>
    public abstract class BaseEntity:IEntity
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enabled { get; set; }
    }
}
