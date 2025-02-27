using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "187baaf3-27ed-4e1a-af10-337728618547", "be3fcca3-f743-4426-9887-5f6b1dc2f021", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e870cb5-a051-44f6-878f-4e05f95cef22", "ab31255c-7c05-477a-a78b-42810fdda4bb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c660502a-1ec9-4c72-aa4a-f8fc035e08f0", "d76202ec-6f86-4e95-b1b0-b02120a60fd3", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187baaf3-27ed-4e1a-af10-337728618547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e870cb5-a051-44f6-878f-4e05f95cef22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c660502a-1ec9-4c72-aa4a-f8fc035e08f0");
        }
    }
}
