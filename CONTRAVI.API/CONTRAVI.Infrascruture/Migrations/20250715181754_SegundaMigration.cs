using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CONTRAVI.Infrascruture.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Admin_Login",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoadMapOrigemId",
                table: "Roads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PassengerId1",
                table: "PassengerDestination",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PassengerDestination_PassengerId1",
                table: "PassengerDestination",
                column: "PassengerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerDestination_User_PassengerId1",
                table: "PassengerDestination",
                column: "PassengerId1",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassengerDestination_User_PassengerId1",
                table: "PassengerDestination");

            migrationBuilder.DropIndex(
                name: "IX_PassengerDestination_PassengerId1",
                table: "PassengerDestination");

            migrationBuilder.DropColumn(
                name: "Admin_Login",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoadMapOrigemId",
                table: "Roads");

            migrationBuilder.DropColumn(
                name: "PassengerId1",
                table: "PassengerDestination");
        }
    }
}
