using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testeMvc.Migrations
{
    /// <inheritdoc />
    public partial class primeiramigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseDados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ficticio1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ficticio2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ficticio3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ficticio4 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseDados", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Clientes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Clientes", x => x.Id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseDados");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
