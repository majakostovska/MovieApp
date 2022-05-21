namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Genre_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.PersonMovies",
                c => new
                    {
                        Person_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_Id, t.Movie_Id })
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Person_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonMovies", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.PersonMovies", "Person_Id", "dbo.People");
            DropForeignKey("dbo.MovieGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.MovieGenres", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.PersonMovies", new[] { "Movie_Id" });
            DropIndex("dbo.PersonMovies", new[] { "Person_Id" });
            DropIndex("dbo.MovieGenres", new[] { "Genre_Id" });
            DropIndex("dbo.MovieGenres", new[] { "Movie_Id" });
            DropTable("dbo.PersonMovies");
            DropTable("dbo.MovieGenres");
        }
    }
}
