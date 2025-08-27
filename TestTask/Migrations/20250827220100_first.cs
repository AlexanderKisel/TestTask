using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deps",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(maxLength: 100, nullable: false),
                    second_name = table.Column<string>(maxLength: 100, nullable: false),
                    last_name = table.Column<string>(maxLength: 100, nullable: false),
                    date_employ = table.Column<DateTime>(nullable: true),
                    date_unemploy = table.Column<DateTime>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    id_dep = table.Column<int>(nullable: false),
                    id_post = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.id);
                    table.ForeignKey(
                        name: "FK_Person_Dep",
                        column: x => x.id_dep,
                        principalTable: "deps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Post",
                        column: x => x.id_post,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Status",
                        column: x => x.status,
                        principalTable: "status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_persons_id_dep",
                table: "persons",
                column: "id_dep");

            migrationBuilder.CreateIndex(
                name: "IX_persons_id_post",
                table: "persons",
                column: "id_post");

            migrationBuilder.CreateIndex(
                name: "IX_persons_status",
                table: "persons",
                column: "status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "deps");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "status");
        }
    }
}
