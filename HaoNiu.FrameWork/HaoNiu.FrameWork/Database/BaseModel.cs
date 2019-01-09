using System;
using System.ComponentModel.DataAnnotations;

namespace HaoNiu.FrameWork.Database
{
    public class BaseModel
    {
        [Key]

        public Guid Id { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool Enabled { get; set; }
    }
}
