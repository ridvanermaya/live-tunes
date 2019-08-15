using Microsoft.EntityFrameworkCore.Migrations;

namespace LiveTunes.MVC.Migrations
{
    public partial class manualMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicCategory",
                columns: new[] { "Id", "CategoryName" },
                values: new object[][] { { 10, "Rock" }, { 11, "jazz" } })
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
