using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetcoreangular.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("INSERT INTO Manufacturer (Name) VALUES ('Toyota')");
			migrationBuilder.Sql("INSERT INTO Manufacturer (Name) VALUES ('Honda')");
			migrationBuilder.Sql("INSERT INTO Manufacturer (Name) VALUES ('Suzuki')");

			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Corolla', (SELECT Id FROM Manufacturer WHERE Name='Toyota'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Vitz', (SELECT Id FROM Manufacturer WHERE Name='Toyota'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Prius', (SELECT Id FROM Manufacturer WHERE Name='Toyota'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Civic', (SELECT Id FROM Manufacturer WHERE Name='Honda'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('City', (SELECT Id FROM Manufacturer WHERE Name='Honda'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Accord', (SELECT Id FROM Manufacturer WHERE Name='Honda'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Swift', (SELECT Id FROM Manufacturer WHERE Name='Suzuki'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('Mehran', (SELECT Id FROM Manufacturer WHERE Name='Suzuki'))");
			migrationBuilder.Sql("INSERT INTO Model (Name, ManufacturerId) VALUES ('WagonR', (SELECT Id FROM Manufacturer WHERE Name='Suzuki'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("DELETE FROM Model");
			migrationBuilder.Sql("DELETE FROM Manufacturer");
        }
    }
}
