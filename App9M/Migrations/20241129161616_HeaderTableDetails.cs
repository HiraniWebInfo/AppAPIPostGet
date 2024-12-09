using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App9M.Migrations
{
    /// <inheritdoc />
    public partial class HeaderTableDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "tblHeaders",
                type: "TEXT",
                nullable: false,
                defaultValue: DateTime.Now);

            migrationBuilder.AddColumn<string>(
                name: "HeaderFinalValue",
                table: "tblHeaders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "tblHeaders",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "tblHeaders");

            migrationBuilder.DropColumn(
                name: "HeaderFinalValue",
                table: "tblHeaders");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "tblHeaders");
        }
    }
}
