using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "WatchedDate");

            migrationBuilder.AddColumn<decimal>(
                name: "TimeStamp",
                table: "Movie",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "WatchedDate",
                table: "Movie",
                newName: "ReleaseDate");

            migrationBuilder.AddColumn<float>(
                name: "Timestamp",
                table: "Movie",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
