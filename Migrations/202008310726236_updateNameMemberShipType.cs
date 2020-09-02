namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateNameMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes set Name='Quarterly' where Id = 3");
            Sql("UPDATE MemberShipTypes set Name='Annual' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
