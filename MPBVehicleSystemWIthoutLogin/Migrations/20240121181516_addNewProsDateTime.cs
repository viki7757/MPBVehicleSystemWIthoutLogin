﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MPBVehicleSystemWIthoutLogin.Migrations
{
    /// <inheritdoc />
    public partial class addNewProsDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "VehicleLocations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "VehicleDepartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "VehicleLocations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "VehicleDepartments");
        }
    }
}
