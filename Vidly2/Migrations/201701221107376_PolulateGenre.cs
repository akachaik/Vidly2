namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (ID, NAME) VALUES( 1, 'Action')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES( 2, 'Science Fiction')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES( 3, 'Drama')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES( 4, 'Comedy')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES( 5, 'Documentary')");
        }
        
        public override void Down()
        {
        }
    }
}
