using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDemo.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Employee",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   Name = table.Column<string>(maxLength: 256, nullable: true),
                   Salary = table.Column<Decimal>(nullable: true),
                  
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Emp", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
