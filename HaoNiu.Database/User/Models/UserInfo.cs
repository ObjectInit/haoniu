using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaoNiu.EntityFrameworkExtend.ComponentModel.DataAnnotations;
using HaoNiu.FrameWork.System.Database;
using HaoNiu.FrameWork.System.Enum;


namespace User.Models
{
    [Table("HaoNiu_UserInfo")]
    public class UserInfo:BaseModel
    {
        /// <summary>
        /// 真实姓名
        /// </summary>
        [MaxLength(20)]
        public string TrueName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// 出生年月
        /// </summary>
        public DateTime? BirthDay { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary> 
        [DecimalPrecision(18,2)]
        public decimal AccountBalance { get; set; }
    }
}
