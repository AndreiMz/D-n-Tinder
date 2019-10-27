using Microsoft.EntityFrameworkCore.Migrations;

namespace DnTinder.Migrations
{
    public partial class AddedBugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ReproductionSteps = table.Column<string>(nullable: true),
                    ExpectedBehaviour = table.Column<string>(nullable: true),
                    ObservedBehaviour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");
        }
    }
}
