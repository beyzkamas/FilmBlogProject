using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogApp.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Tags_TagID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TagID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "Comments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TagID",
                table: "Comments",
                column: "TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Tags_TagID",
                table: "Comments",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "TagID");
        }
    }
}
