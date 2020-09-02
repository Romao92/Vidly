namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberToMovie : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
