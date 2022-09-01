using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterNow.Migrations
{
    public partial class DirectorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Shows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shows_DirectorId",
                table: "Shows",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Director_DirectorId",
                table: "Shows",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Director_DirectorId",
                table: "Shows");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropIndex(
                name: "IX_Shows_DirectorId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Shows");
        }
    }
}
