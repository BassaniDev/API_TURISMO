using Microsoft.EntityFrameworkCore.Migrations;

namespace API_TURISMO.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Eid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uf = table.Column<string>(maxLength: 2, nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Eid);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Cid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eid = table.Column<int>(nullable: false),
                    EstadoEid = table.Column<int>(nullable: true),
                    uf = table.Column<string>(maxLength: 2, nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Cid);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_EstadoEid",
                        column: x => x.EstadoEid,
                        principalTable: "Estado",
                        principalColumn: "Eid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "P_Turistico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    Descrição = table.Column<string>(maxLength: 100, nullable: false),
                    Endereço = table.Column<string>(maxLength: 60, nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    Cidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_Turistico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_P_Turistico_Cidade_Cidade",
                        column: x => x.Cidade,
                        principalTable: "Cidade",
                        principalColumn: "Cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_P_Turistico_Estado_Estado",
                        column: x => x.Estado,
                        principalTable: "Estado",
                        principalColumn: "Eid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_EstadoEid",
                table: "Cidade",
                column: "EstadoEid");

            migrationBuilder.CreateIndex(
                name: "IX_P_Turistico_Cidade",
                table: "P_Turistico",
                column: "Cidade");

            migrationBuilder.CreateIndex(
                name: "IX_P_Turistico_Estado",
                table: "P_Turistico",
                column: "Estado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_Turistico");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
