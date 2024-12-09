using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App9M.Migrations
{
    /// <inheritdoc />
    public partial class urlIdInParamNsettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "urlId",
                table: "tblParameters",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "urlId",
                table: "tblHeaders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblParameters_urlId",
                table: "tblParameters",
                column: "urlId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHeaders_urlId",
                table: "tblHeaders",
                column: "urlId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblHeaders_tblUrlList_urlId",
                table: "tblHeaders",
                column: "urlId",
                principalTable: "tblUrlList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblParameters_tblUrlList_urlId",
                table: "tblParameters",
                column: "urlId",
                principalTable: "tblUrlList",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblHeaders_tblUrlList_urlId",
                table: "tblHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_tblParameters_tblUrlList_urlId",
                table: "tblParameters");

            migrationBuilder.DropIndex(
                name: "IX_tblParameters_urlId",
                table: "tblParameters");

            migrationBuilder.DropIndex(
                name: "IX_tblHeaders_urlId",
                table: "tblHeaders");

            migrationBuilder.DropColumn(
                name: "urlId",
                table: "tblParameters");

            migrationBuilder.DropColumn(
                name: "urlId",
                table: "tblHeaders");

            
        }
    }
}
