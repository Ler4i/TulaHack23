using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutority.Data.Migrations
{
    public partial class NewtableClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Post = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Clients",
                columns: new[] { "Id", "Delete", "Email", "Name", "Post" },
                values: new object[] { 1, false, "", "First", "Director" });

            //migrationBuilder.Sql(@" ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients",
                schema: "data");
        } 
    }
}
