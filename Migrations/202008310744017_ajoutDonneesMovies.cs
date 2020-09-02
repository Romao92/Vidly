namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutDonneesMovies : DbMigration
    {
        public override void Up()
        {
            /*Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Hangover','Comedy','06/11/2009','31/08/2020',5)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Die Hard','Action','20/07/1988','31/08/2020',8)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('The Terminator','Action','26/10/1984','31/08/2020',9)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Toy Story','Family','22/11/1995','31/08/2020',10)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Titanic','Romance','19/12/1997','31/08/2020',3)");*/
        }
        
        public override void Down()
        {
        }
    }
}
