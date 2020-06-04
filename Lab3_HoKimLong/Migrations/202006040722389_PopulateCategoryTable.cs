namespace Lab3_HoKimLong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories(Id ,name) values(1,'Developer')");
            Sql("Insert into Categories(Id ,name) values(2,'Bussiness')");
            Sql("Insert into Categories(Id ,name) values(3,'Marketting')");
        }
        
        public override void Down()
        {
        }
    }
}
