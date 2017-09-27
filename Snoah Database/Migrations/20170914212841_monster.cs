using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SnoahRpg.Migrations
{
    public partial class monster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Location_LocationId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Monster_MonsterId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Location_CurrentLocationId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "PlayerItem");

            migrationBuilder.DropIndex(
                name: "IX_Player_CurrentLocationId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Item_LocationId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_MonsterId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CurrentLocationId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MonsterId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "CurrentChestId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentHelmId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWeaponId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWristId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gold",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentChestId",
                table: "Monster",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentHelmId",
                table: "Monster",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWeaponId",
                table: "Monster",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWristId",
                table: "Monster",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gold",
                table: "Monster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Power",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_CurrentChestId",
                table: "Player",
                column: "CurrentChestId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CurrentHelmId",
                table: "Player",
                column: "CurrentHelmId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CurrentWeaponId",
                table: "Player",
                column: "CurrentWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CurrentWristId",
                table: "Player",
                column: "CurrentWristId");

            migrationBuilder.CreateIndex(
                name: "IX_Monster_CurrentChestId",
                table: "Monster",
                column: "CurrentChestId");

            migrationBuilder.CreateIndex(
                name: "IX_Monster_CurrentHelmId",
                table: "Monster",
                column: "CurrentHelmId");

            migrationBuilder.CreateIndex(
                name: "IX_Monster_CurrentWeaponId",
                table: "Monster",
                column: "CurrentWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Monster_CurrentWristId",
                table: "Monster",
                column: "CurrentWristId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_StoreId",
                table: "Item",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Store_StoreId",
                table: "Item",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monster_Item_CurrentChestId",
                table: "Monster",
                column: "CurrentChestId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monster_Item_CurrentHelmId",
                table: "Monster",
                column: "CurrentHelmId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monster_Item_CurrentWeaponId",
                table: "Monster",
                column: "CurrentWeaponId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monster_Item_CurrentWristId",
                table: "Monster",
                column: "CurrentWristId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Item_CurrentChestId",
                table: "Player",
                column: "CurrentChestId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Item_CurrentHelmId",
                table: "Player",
                column: "CurrentHelmId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Item_CurrentWeaponId",
                table: "Player",
                column: "CurrentWeaponId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Item_CurrentWristId",
                table: "Player",
                column: "CurrentWristId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Store_StoreId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Monster_Item_CurrentChestId",
                table: "Monster");

            migrationBuilder.DropForeignKey(
                name: "FK_Monster_Item_CurrentHelmId",
                table: "Monster");

            migrationBuilder.DropForeignKey(
                name: "FK_Monster_Item_CurrentWeaponId",
                table: "Monster");

            migrationBuilder.DropForeignKey(
                name: "FK_Monster_Item_CurrentWristId",
                table: "Monster");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Item_CurrentChestId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Item_CurrentHelmId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Item_CurrentWeaponId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Item_CurrentWristId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Player_CurrentChestId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_CurrentHelmId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_CurrentWeaponId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_CurrentWristId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Monster_CurrentChestId",
                table: "Monster");

            migrationBuilder.DropIndex(
                name: "IX_Monster_CurrentHelmId",
                table: "Monster");

            migrationBuilder.DropIndex(
                name: "IX_Monster_CurrentWeaponId",
                table: "Monster");

            migrationBuilder.DropIndex(
                name: "IX_Monster_CurrentWristId",
                table: "Monster");

            migrationBuilder.DropIndex(
                name: "IX_Item_StoreId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CurrentChestId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CurrentHelmId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CurrentWeaponId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CurrentWristId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CurrentChestId",
                table: "Monster");

            migrationBuilder.DropColumn(
                name: "CurrentHelmId",
                table: "Monster");

            migrationBuilder.DropColumn(
                name: "CurrentWeaponId",
                table: "Monster");

            migrationBuilder.DropColumn(
                name: "CurrentWristId",
                table: "Monster");

            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Monster");

            migrationBuilder.DropColumn(
                name: "Item",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "CurrentLocationId",
                table: "Player",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Player",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Power",
                table: "Item",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonsterId",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlayerItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerId = table.Column<int>(nullable: true),
                    Power = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerItem_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_CurrentLocationId",
                table: "Player",
                column: "CurrentLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_LocationId",
                table: "Item",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_MonsterId",
                table: "Item",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItem_PlayerId",
                table: "PlayerItem",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Location_LocationId",
                table: "Item",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Monster_MonsterId",
                table: "Item",
                column: "MonsterId",
                principalTable: "Monster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Location_CurrentLocationId",
                table: "Player",
                column: "CurrentLocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
