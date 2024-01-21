using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MPBVehicleSystemWIthoutLogin.Migrations
{
    /// <inheritdoc />
    public partial class addNewPros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "VehicleLocations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "VehicleDepartments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "VehicleLocations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "VehicleDepartments");
        }
    }
}
