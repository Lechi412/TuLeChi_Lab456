namespace TuLeChiLAB_456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql{ "INSERT INTO CATEGORIES(ID, NAME) VALUES(1,'Development')"};
        }
        
        public override void Down()
        {
        }
    }
}
