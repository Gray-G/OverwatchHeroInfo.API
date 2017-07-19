using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OverwatchHeroInfo.API.Migrations
{
    public partial class EntityChanges1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStrongAgainst",
                table: "CounterPicks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsWeakAgainst",
                table: "CounterPicks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStrongAgainst",
                table: "CounterPicks");

            migrationBuilder.DropColumn(
                name: "IsWeakAgainst",
                table: "CounterPicks");
        }
    }
}
