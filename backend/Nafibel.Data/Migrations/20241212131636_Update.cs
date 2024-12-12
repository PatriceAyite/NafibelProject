using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nafibel.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HairStyles_Name",
                table: "HairStyles",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HairStyles_Name",
                table: "HairStyles");
        }
    }
}
