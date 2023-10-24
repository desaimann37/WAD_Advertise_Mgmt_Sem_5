using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Advertise_mgmt_system.Migrations
{
    public partial class Categories_Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "CategoryDetails",
             columns: table => new
             {
                 Id = table.Column<int>(type: "int", nullable: false),
                 Adv_Name = table.Column<string>(type: "nvarchar(450)", maxLength: 256, nullable: false),
                 Adv_Theme = table.Column<string>(type: "nvarchar(450)", maxLength: 256, nullable: false),
                 Adv_Description = table.Column<string>(type: "nvarchar(450)", maxLength: 256, nullable: false)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_CategoryDetails", x => x.Id);
             });

             migrationBuilder.CreateIndex(
                name: "CategoryIdIndex",
                table: "CategoryDetails",
                column: "Id"
             );
            migrationBuilder.CreateIndex(
                name: "CategoryAdvNameIndex",
                table: "CategoryDetails",
                column: "Adv_Name"
            );
            migrationBuilder.CreateIndex(
                name: "CategoryAdvThemeIndex",
                table: "CategoryDetails",
                column: "Adv_Theme"
            );
            migrationBuilder.CreateIndex(
                name: "CategoryAdvDescIndex",
                table: "CategoryDetails",
                column: "Adv_Description"
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDetails"
            );
        }
    }
}
