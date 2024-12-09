using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App9M.Migrations
{
    /// <inheritdoc />
    public partial class ParameterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: false),
                    PathValue = table.Column<string>(type: "TEXT", nullable: false),
                    FinalValue = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblParameters", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: DateTime.Now);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblParameters");

            migrationBuilder.UpdateData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: DateTime.Now);
        }
    }
}
