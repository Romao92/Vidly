﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatasMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes set Name='Pay as You Go' where Id = 1");
            Sql("UPDATE MemberShipTypes set Name='Monthly' where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
