using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDBTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Username1",
                table: "Reviews",
                type: "VARCHAR(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Username1",
                table: "Reviews",
                column: "Username1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_Username1",
                table: "Reviews",
                column: "Username1",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_Username1",
                table: "Reviews");
            
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_Username1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Username1",
                table: "Reviews");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
