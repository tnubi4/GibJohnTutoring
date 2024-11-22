using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GibJohnTutoring.Migrations
{
    /// <inheritdoc />
    public partial class secondcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Time",
                table: "BookTutor",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AddColumn<bool>(
                name: "bool",
                table: "BookTutor",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bool",
                table: "BookTutor");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Time",
                table: "BookTutor",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0),
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);
        }
    }
}
