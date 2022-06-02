using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_test.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sobrenome",
                table: "Users",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "status" },
                values: new object[] { "email@email.com1", "on" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "status" },
                values: new object[] { "email@email.com2", "on" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "status" },
                values: new object[] { "email@email.com3", "on" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "status" },
                values: new object[] { "email@email.com4", "on" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "status" },
                values: new object[] { "email@email.com5", "on" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "nome", "senha", "sobrenome", "status" },
                values: new object[] { 6, "email@email.com6", "derex6", "derex32-6", "xered6", "on" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_sobrenome",
                table: "Users",
                column: "sobrenome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_sobrenome",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "sobrenome",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "status" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "status" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "status" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "status" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "status" },
                values: new object[] { null, null });
        }
    }
}
