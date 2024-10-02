using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 46, 28, 218, 240, 228, 129, 193, 48, 109, 108, 92, 40, 88, 92, 243, 142, 49, 54, 73, 133, 17, 244, 59, 119, 17, 226, 124, 10, 63, 123, 103, 177, 231, 101, 35, 140, 26, 178, 58, 205, 44, 16, 94, 226, 129, 140, 55, 178, 187, 130, 199, 148, 201, 130, 183, 107, 37, 124, 100, 181, 198, 45, 51, 220 }, new byte[] { 154, 225, 28, 106, 107, 193, 182, 156, 77, 232, 77, 89, 52, 12, 131, 91, 166, 103, 164, 221, 161, 98, 207, 224, 238, 107, 164, 110, 197, 128, 25, 5, 104, 252, 193, 43, 141, 125, 218, 67, 62, 5, 187, 202, 214, 162, 64, 193, 30, 102, 96, 208, 121, 13, 210, 133, 75, 171, 242, 38, 174, 163, 221, 58, 72, 204, 217, 35, 236, 239, 74, 6, 25, 78, 88, 76, 11, 117, 230, 215, 112, 175, 24, 124, 222, 160, 176, 250, 199, 89, 146, 155, 53, 218, 27, 107, 225, 127, 234, 139, 140, 131, 41, 6, 50, 210, 175, 185, 191, 237, 131, 173, 130, 31, 185, 145, 84, 17, 12, 59, 219, 15, 42, 70, 248, 99, 119, 76 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 137, 171, 103, 214, 236, 157, 159, 72, 116, 10, 218, 71, 163, 124, 232, 75, 187, 220, 123, 170, 7, 249, 203, 218, 48, 234, 184, 119, 138, 219, 64, 48, 86, 124, 14, 187, 147, 180, 0, 24, 189, 143, 62, 156, 246, 22, 222, 26, 21, 14, 200, 88, 132, 90, 13, 4, 131, 211, 198, 188, 80, 121, 250, 22 }, new byte[] { 112, 20, 213, 156, 180, 73, 252, 12, 13, 162, 73, 202, 147, 118, 194, 38, 19, 146, 223, 157, 52, 8, 164, 243, 171, 7, 154, 6, 59, 185, 79, 171, 255, 71, 40, 123, 229, 162, 51, 177, 191, 197, 117, 171, 102, 80, 70, 78, 154, 41, 215, 159, 159, 170, 87, 186, 163, 165, 59, 45, 223, 172, 37, 114, 167, 120, 103, 169, 20, 141, 15, 134, 172, 86, 4, 88, 18, 253, 165, 73, 218, 130, 10, 123, 212, 152, 32, 28, 158, 188, 168, 47, 249, 172, 99, 214, 138, 35, 84, 47, 189, 109, 63, 38, 103, 8, 219, 105, 54, 200, 123, 25, 162, 69, 151, 104, 65, 37, 207, 99, 60, 136, 239, 138, 23, 255, 61, 227 } });
        }
    }
}
