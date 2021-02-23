using Microsoft.EntityFrameworkCore.Migrations;

namespace DT102G_ASP_NET_Moment3.Migrations
{
    public partial class fixfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Records_RecordId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "RecordId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Records_RecordId",
                table: "User",
                column: "RecordId",
                principalTable: "Records",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Records_RecordId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "RecordId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_User_Records_RecordId",
                table: "User",
                column: "RecordId",
                principalTable: "Records",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
