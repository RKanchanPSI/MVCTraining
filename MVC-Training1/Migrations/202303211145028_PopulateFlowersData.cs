namespace MVC_Training1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFlowersData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Flowers ON");
            Sql("INSERT INTO Flowers (Id, Name, ImageUrl) Values (1,'Mug','~/Content/images/rose.png')");
            Sql("INSERT INTO Flowers (Id, Name, ImageUrl) Values (2,'Lilly','~/Content/images/lilly.png')");
            Sql("INSERT INTO Flowers (Id, Name, ImageUrl) Values (3,'Daisy','~/Content/images/daisy.png')");
            Sql("INSERT INTO Flowers (Id, Name, ImageUrl) Values (4,'Sunflower','~/Content/images/sunflower.png')");
        }

        public override void Down()
        {
        }
    }
}
