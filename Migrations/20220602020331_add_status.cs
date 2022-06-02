using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_test.Migrations
{
    public partial class add_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Users",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "nome", "senha", "sobrenome", "status" },
                values: new object[,]
                {
                    { 1, null, "derex1", "derex32-1", "xered1", null },
                    { 2, null, "derex2", "derex32-2", "xered2", null },
                    { 3, null, "derex3", "derex32-3", "xered3", null },
                    { 4, null, "derex4", "derex32-4", "xered4", null },
                    { 5, null, "derex5", "derex32-5", "xered5", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "status",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
