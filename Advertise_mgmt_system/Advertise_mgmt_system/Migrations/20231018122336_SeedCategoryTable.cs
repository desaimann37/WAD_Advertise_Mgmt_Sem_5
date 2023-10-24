using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Advertise_mgmt_system.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "CategoryDetails",
                columns: new[] { "Id", "Adv_Description", "Adv_Name", "Adv_Theme" },
                values: new object[] { 1, "This Advertise is to get Admissions into respective College/School in Town!", "Education", "Educational" });

            migrationBuilder.InsertData(
                table: "CategoryDetails",
                columns: new[] { "Id", "Adv_Description", "Adv_Name", "Adv_Theme" },
                values: new object[] { 2, "Explore New Worlds With Bare Minimum Flight bookings", "Travel", "Explore_World" });

            migrationBuilder.InsertData(
                table: "CategoryDetails",
                columns: new[] { "Id", "Adv_Description", "Adv_Name", "Adv_Theme" },
                values: new object[] { 3, "Recruitment of new Tech. Company called FApple The way of Apple :)", "Recruitment", "Recruiting" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDetails",
                table: "CategoryDetails");

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "CategoryDetails",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }
    }
}
