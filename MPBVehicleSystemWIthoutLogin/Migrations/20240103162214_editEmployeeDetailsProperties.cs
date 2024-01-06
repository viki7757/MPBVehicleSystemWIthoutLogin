using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MPBVehicleSystemWIthoutLogin.Migrations
{
    /// <inheritdoc />
    public partial class editEmployeeDetailsProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeDetails");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "EmployeeDetails",
                newName: "SiteLocation");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "EmployeeDetails",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "HHEmployeeNo",
                table: "EmployeeDetails",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LHSEmployeeNo",
                table: "EmployeeDetails",
                type: "varchar(20)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HHEmployeeNo",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "LHSEmployeeNo",
                table: "EmployeeDetails");

            migrationBuilder.RenameColumn(
                name: "SiteLocation",
                table: "EmployeeDetails",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EmployeeDetails",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "EmployeeDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
