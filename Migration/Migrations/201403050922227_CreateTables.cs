namespace Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable("FurnishedUnfurnished", c => new
            {
                Value = c.String(nullable: true, maxLength: 50),
                Id = c.Int(nullable: false, identity: true)
            }).PrimaryKey(t => t.Id);

            CreateTable("Tenures", c => new
            {
                Value = c.String(nullable: true, maxLength: 100),
                Id = c.Int(nullable: false, identity: true)
            }).PrimaryKey(t => t.Id);

            CreateTable("Buildings", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                ShortDescription = c.String(nullable: true, maxLength: 1000),
                LongDescription = c.String(nullable: true),
                SellerCorner = c.String(nullable: false, maxLength: 1000),
                Area = c.String(nullable: false, maxLength: 300),
                PostCode = c.String(nullable: false, maxLength: 20),
                Address = c.String(nullable: false, maxLength: 200),
                IdFunUnfun = c.Int(nullable: true),
                IdTenures = c.Int(nullable: true),
                Badrooms = c.Int(nullable: false),
                Bathrooms = c.Int(nullable: false),
                Livingrooms = c.Int(nullable: false),
                PropertyStatus = c.String(nullable: false, maxLength: 100),
                SSTC = c.Boolean(nullable: false),
                Garden = c.Boolean(nullable: false),
                Parking = c.Boolean(nullable: false),
                Shower = c.Boolean(nullable: false),
                IsItSell = c.Boolean(nullable: false),
                Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                MainPhoto = c.String(nullable: true)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("FurnishedUnfurnished", t => t.IdFunUnfun, cascadeDelete: true)
            .ForeignKey("Tenures", t => t.IdTenures, cascadeDelete: true);

            CreateTable("BuildingPhotos", c => new
            {
                Id = c.Int(nullable: true, identity: true),
                FileName = c.String(nullable: false, maxLength: 100),
                IdBuilding = c.Int(nullable: false)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("Buildings", t => t.IdBuilding, cascadeDelete: true)
            .Index(t => t.IdBuilding);

            CreateTable("Planes2D3D", c => new
            {
                Id = c.Int(nullable: true, identity: true),
                IdBuilding = c.Int(nullable: false),
                IsIt2D = c.Boolean(nullable: false),
                Link = c.String(nullable: false, maxLength: 200)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("Buildings", t => t.IdBuilding, cascadeDelete: true)
            .Index(t => t.IdBuilding);

            CreateTable("EPCs", c => new
            {
                Id = c.Int(nullable: true, identity: true),
                IdBuilding = c.Int(nullable: false),
                PDFLink = c.String(nullable: false, maxLength: 200)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("Buildings", t => t.IdBuilding, cascadeDelete: true)
            .Index(t => t.IdBuilding);

            CreateTable("EPCGraphics", c => new
            {
                Id = c.Int(nullable: true, identity: true),
                IdEPC = c.Int(nullable: false),
                GraphicLink = c.String(nullable: false, maxLength: 100)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("EPCs", t => t.IdEPC, cascadeDelete: true)
            .Index(t => t.IdEPC);

            CreateTable("TypeUser", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                Name = c.String(nullable: false, maxLength: 200)
            }).PrimaryKey(t => t.Id);

            CreateTable("Users", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                Email = c.String(nullable: false, maxLength: 100),
                Password = c.String(nullable: false, maxLength: 25),
                IdType = c.Int(nullable: false)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("TypeUser", t => t.IdType, cascadeDelete: true);

            CreateTable("CMSType", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                IdUsers = c.Int(nullable: false),
                TypeName = c.String(nullable: false, maxLength: 100)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("Users", t => t.IdUsers, cascadeDelete: true)
            .Index(t => t.IdUsers);

            CreateTable("CMSPage", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                IdCMSType = c.Int(nullable: false),
                Content = c.String(nullable: false, maxLength: 100000),
                PageTitle = c.String(nullable: false, maxLength: 200)
            }).PrimaryKey(t => t.Id)
            .ForeignKey("CMSType", t => t.IdCMSType, cascadeDelete: true)
            .Index(t => t.IdCMSType);

            CreateIndex("Users", "Email", unique: true);

        }

        public override void Down()
        {
            DropIndex("Users", "Email");

            DropTable("CMSPage");
            DropTable("CMSType");
            DropTable("Users");
            DropTable("TypeUser");

            DropTable("BuildingPhotos");
            DropTable("Planes2D3D");
            DropTable("EPCGraphics");
            DropTable("EPCs");

            DropTable("Buildings");

            DropTable("Tenures");
            DropTable("FurnishedUnfurnished");


        }
    }
}
