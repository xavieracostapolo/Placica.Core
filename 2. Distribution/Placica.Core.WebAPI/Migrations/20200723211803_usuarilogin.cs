using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Placica.Core.WebAPI.Migrations
{
    public partial class usuarilogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    PictureUrl = table.Column<string>(nullable: false),
                    Provider = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 337, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "Parametros",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 335, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 335, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "Parametros",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 335, DateTimeKind.Unspecified).AddTicks(2000), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 21, 18, 2, 335, DateTimeKind.Unspecified).AddTicks(2020), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UserId",
                table: "Usuarios",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), (short)1 });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), (short)1 });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 0, 0, 0, 0)), (short)1 });

            migrationBuilder.UpdateData(
                table: "ParametroDetalles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 0, 0, 0, 0)), (short)1 });

            migrationBuilder.UpdateData(
                table: "Parametros",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 0, 0, 0, 0)), (short)1 });

            migrationBuilder.UpdateData(
                table: "Parametros",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)), (short)1 });
        }
    }
}
