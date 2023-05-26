using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF1tomany.Migrations
{
    /// <inheritdoc />
    public partial class Addconstrainstotables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Comments_T_Articles_ArticleId",
                table: "T_Comments");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "T_Comments",
                newName: "TheArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_T_Comments_ArticleId",
                table: "T_Comments",
                newName: "IX_T_Comments_TheArticleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "T_Comments",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "T_Articles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "T_Articles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Comments_T_Articles_TheArticleId",
                table: "T_Comments",
                column: "TheArticleId",
                principalTable: "T_Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Comments_T_Articles_TheArticleId",
                table: "T_Comments");

            migrationBuilder.RenameColumn(
                name: "TheArticleId",
                table: "T_Comments",
                newName: "ArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_T_Comments_TheArticleId",
                table: "T_Comments",
                newName: "IX_T_Comments_ArticleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "T_Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "T_Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "T_Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Comments_T_Articles_ArticleId",
                table: "T_Comments",
                column: "ArticleId",
                principalTable: "T_Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
