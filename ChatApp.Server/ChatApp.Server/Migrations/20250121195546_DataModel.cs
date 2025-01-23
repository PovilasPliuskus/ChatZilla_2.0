using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "User",
                type: "timestamp with time zone",
                nullable: true,
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "User",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Test",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Test",
                type: "uuid",
                nullable: false,
                comment: "Guid ID",
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValueSql: "gen_random_uuid()",
                oldComment: "Guid ID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Message",
                type: "timestamp with time zone",
                nullable: true,
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Message",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Message",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ChatParticipants",
                type: "timestamp with time zone",
                nullable: true,
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JoinedAt",
                table: "ChatParticipants",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Timestamp when the user joined the chat",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the user joined the chat");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ChatParticipants",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Chat",
                type: "timestamp with time zone",
                nullable: true,
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Chat",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValueSql: "gen_random_uuid()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "User",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "User",
                type: "uuid",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Test",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Test",
                type: "uuid",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                comment: "Guid ID",
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Guid ID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Message",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Message",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Message",
                type: "uuid",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ChatParticipants",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JoinedAt",
                table: "ChatParticipants",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the user joined the chat",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Timestamp when the user joined the chat");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ChatParticipants",
                type: "uuid",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Chat",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was modified",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldComment: "Timestamp when the record was modified");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                comment: "Timestamp when the record was created",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Timestamp when the record was created");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Chat",
                type: "uuid",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uuid");
        }
    }
}
