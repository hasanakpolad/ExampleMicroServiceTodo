using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleMicroServiceTodo.DataAccess.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoModel",
                table: "TodoModel");

            migrationBuilder.RenameTable(
                name: "TodoModel",
                newName: "TodoModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoModels",
                table: "TodoModels",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoModels",
                table: "TodoModels");

            migrationBuilder.RenameTable(
                name: "TodoModels",
                newName: "TodoModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoModel",
                table: "TodoModel",
                column: "Id");
        }
    }
}
