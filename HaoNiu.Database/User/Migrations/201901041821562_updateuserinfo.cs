namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuserinfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HaoNiu_UserInfo", "AccountBalance", c => c.Decimal(nullable: false, precision: 18, scale: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HaoNiu_UserInfo", "AccountBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
