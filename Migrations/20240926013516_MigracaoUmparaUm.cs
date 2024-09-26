using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmparaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 137, 171, 103, 214, 236, 157, 159, 72, 116, 10, 218, 71, 163, 124, 232, 75, 187, 220, 123, 170, 7, 249, 203, 218, 48, 234, 184, 119, 138, 219, 64, 48, 86, 124, 14, 187, 147, 180, 0, 24, 189, 143, 62, 156, 246, 22, 222, 26, 21, 14, 200, 88, 132, 90, 13, 4, 131, 211, 198, 188, 80, 121, 250, 22 }, new byte[] { 112, 20, 213, 156, 180, 73, 252, 12, 13, 162, 73, 202, 147, 118, 194, 38, 19, 146, 223, 157, 52, 8, 164, 243, 171, 7, 154, 6, 59, 185, 79, 171, 255, 71, 40, 123, 229, 162, 51, 177, 191, 197, 117, 171, 102, 80, 70, 78, 154, 41, 215, 159, 159, 170, 87, 186, 163, 165, 59, 45, 223, 172, 37, 114, 167, 120, 103, 169, 20, 141, 15, 134, 172, 86, 4, 88, 18, 253, 165, 73, 218, 130, 10, 123, 212, 152, 32, 28, 158, 188, 168, 47, 249, 172, 99, 214, 138, 35, 84, 47, 189, 109, 63, 38, 103, 8, 219, 105, 54, 200, 123, 25, 162, 69, 151, 104, 65, 37, 207, 99, 60, 136, 239, 138, 23, 255, 61, 227 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 167, 134, 31, 116, 63, 248, 30, 39, 83, 10, 246, 255, 214, 20, 252, 3, 55, 231, 171, 197, 93, 126, 200, 30, 181, 27, 75, 253, 60, 248, 143, 65, 138, 153, 65, 2, 210, 55, 173, 173, 25, 139, 145, 103, 154, 207, 95, 101, 136, 145, 229, 79, 255, 161, 143, 6, 44, 65, 137, 234, 3, 157, 82, 233 }, new byte[] { 37, 120, 210, 55, 63, 4, 190, 129, 205, 13, 22, 83, 242, 157, 228, 97, 47, 192, 90, 203, 199, 46, 211, 81, 2, 53, 96, 164, 50, 215, 201, 156, 202, 206, 250, 144, 141, 163, 198, 97, 195, 114, 120, 179, 79, 100, 211, 246, 190, 105, 103, 134, 228, 81, 232, 121, 127, 167, 201, 62, 247, 121, 143, 83, 254, 133, 160, 207, 71, 223, 252, 213, 113, 249, 115, 211, 181, 70, 112, 185, 232, 245, 22, 116, 193, 55, 208, 159, 43, 66, 24, 218, 146, 211, 196, 255, 253, 254, 201, 143, 167, 224, 152, 130, 118, 60, 226, 69, 23, 25, 177, 58, 252, 138, 68, 177, 131, 235, 192, 166, 229, 48, 22, 166, 20, 236, 236, 152 } });
        }
    }
}
