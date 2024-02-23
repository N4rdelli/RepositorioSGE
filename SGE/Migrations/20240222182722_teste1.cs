using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGE.Migrations
{
    /// <inheritdoc />
    public partial class teste1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_TipoUsuario_TipoUsuarioId",
                table: "Aluno");

            migrationBuilder.AlterColumn<Guid>(
                name: "TipoUsuarioId",
                table: "Aluno",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_TipoUsuario_TipoUsuarioId",
                table: "Aluno",
                column: "TipoUsuarioId",
                principalTable: "TipoUsuario",
                principalColumn: "TipoUsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_TipoUsuario_TipoUsuarioId",
                table: "Aluno");

            migrationBuilder.AlterColumn<Guid>(
                name: "TipoUsuarioId",
                table: "Aluno",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_TipoUsuario_TipoUsuarioId",
                table: "Aluno",
                column: "TipoUsuarioId",
                principalTable: "TipoUsuario",
                principalColumn: "TipoUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
