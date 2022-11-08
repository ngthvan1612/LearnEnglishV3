using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEnglish.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TopicTrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NodeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vocabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Audio = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TopicTreeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vocabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vocabs_TopicTrees_TopicTreeId",
                        column: x => x.TopicTreeId,
                        principalTable: "TopicTrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LearningVocabStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VocabId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningVocabStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearningVocabStatuses_Vocabs_VocabId",
                        column: x => x.VocabId,
                        principalTable: "Vocabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LearningVocabStatuses_VocabId",
                table: "LearningVocabStatuses",
                column: "VocabId");

            migrationBuilder.CreateIndex(
                name: "IX_Vocabs_TopicTreeId",
                table: "Vocabs",
                column: "TopicTreeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LearningVocabStatuses");

            migrationBuilder.DropTable(
                name: "Vocabs");

            migrationBuilder.DropTable(
                name: "TopicTrees");
        }
    }
}
