using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaoNiu.EntityFrameworkExtend.ComponentModel.DataAnnotations;
using User.Models;

namespace User
{
    public class UserContext:DbContext
    {
        public UserContext() :base("HaoNiuContext")
        {
            Database.SetInitializer<UserContext>(null);//从不创建数据库
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new DecimalPrecisionAttributeConvention());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}
