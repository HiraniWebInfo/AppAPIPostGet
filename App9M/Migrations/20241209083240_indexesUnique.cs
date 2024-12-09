using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App9M.Migrations
{
    /// <inheritdoc />
    public partial class indexesUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblParameters_urlId",
                table: "tblParameters");

            migrationBuilder.DropIndex(
                name: "IX_tblHeaders_urlId",
                table: "tblHeaders");

            migrationBuilder.CreateIndex(
                name: "IX_tblUrlList_Name",
                table: "tblUrlList",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblSettings_Name",
                table: "tblSettings",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblParameters_urlId_Name",
                table: "tblParameters",
                columns: new[] { "urlId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblHeaders_urlId_HeaderKey",
                table: "tblHeaders",
                columns: new[] { "urlId", "HeaderKey" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblUrlList_Name",
                table: "tblUrlList");

            migrationBuilder.DropIndex(
                name: "IX_tblSettings_Name",
                table: "tblSettings");

            migrationBuilder.DropIndex(
                name: "IX_tblParameters_urlId_Name",
                table: "tblParameters");

            migrationBuilder.DropIndex(
                name: "IX_tblHeaders_urlId_HeaderKey",
                table: "tblHeaders");

            migrationBuilder.CreateIndex(
                name: "IX_tblParameters_urlId",
                table: "tblParameters",
                column: "urlId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHeaders_urlId",
                table: "tblHeaders",
                column: "urlId");
        }
    }
}
