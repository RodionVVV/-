namespace WindowsFormsApp17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        idFilm = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        genre = c.String(),
                        prStartDate = c.DateTime(nullable: false),
                        prEndDate = c.DateTime(nullable: false),
                        rentalPrice = c.Int(nullable: false),
                        ticketPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idFilm);
            
            CreateTable(
                "dbo.FoodRevenues",
                c => new
                    {
                        idFoodRevenue = c.Int(nullable: false, identity: true),
                        idProduct = c.Int(nullable: false),
                        idShow = c.Int(nullable: false),
                        quantitySold = c.Int(nullable: false),
                        profit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idFoodRevenue);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        idProduct = c.Int(nullable: false, identity: true),
                        nameProduct = c.String(),
                        priceProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProduct);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        idShow = c.Int(nullable: false, identity: true),
                        idCinema = c.Int(nullable: false),
                        idFilm = c.Int(nullable: false),
                        showStartTime = c.DateTime(nullable: false),
                        showEndTime = c.DateTime(nullable: false),
                        occupiedPlaces = c.Int(nullable: false),
                        profit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idShow);
            
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        idCinema = c.Int(nullable: false, identity: true),
                        idFilm = c.Int(nullable: false),
                        vacancies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idCinema);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cinemas");
            DropTable("dbo.Shows");
            DropTable("dbo.Products");
            DropTable("dbo.FoodRevenues");
            DropTable("dbo.Films");
        }
    }
}
