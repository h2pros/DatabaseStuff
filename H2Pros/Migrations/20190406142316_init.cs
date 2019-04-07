using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace H2Pros.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    cpr = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.cpr);
                });

            migrationBuilder.CreateTable(
                name: "consumptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dateCreated = table.Column<DateTime>(nullable: false),
                    coldWaterFlow = table.Column<int>(nullable: false),
                    hotWaterFlow = table.Column<int>(nullable: false),
                    User = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_consumptions_users_User",
                        column: x => x.User,
                        principalTable: "users",
                        principalColumn: "cpr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_consumptions_User",
                table: "consumptions",
                column: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consumptions");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
