using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App9M.Migrations
{
    /// <inheritdoc />
    public partial class tblHeaders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HeaderKey = table.Column<string>(type: "TEXT", nullable: false),
                    HeaderValue = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHeaders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: DateTime.Now);

            migrationBuilder.InsertData(
                table: "tblSettings",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, DateTime.Now, "", "LoginReqType", null },
                    { 3, DateTime.Now, "", "LoginUrl", null },
                    { 4, DateTime.Now, "", "LoginReqJson", null },
                    { 5, DateTime.Now, "", "LoginRespJson", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblHeaders");

            migrationBuilder.DeleteData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "tblSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: DateTime.Now);
        }
    }
}
