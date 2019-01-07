namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HaoNiu_UserInfo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TrueName = c.String(maxLength: 20),
                        NickName = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        BirthDay = c.DateTime(),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HaoNiu_UserInfo");
        }
    }
}
