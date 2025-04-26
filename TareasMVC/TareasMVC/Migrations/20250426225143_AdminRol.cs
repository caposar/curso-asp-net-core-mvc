using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
IF NOT EXISTS(Select Id from AspNetRoles where Id = '82f26451-3c9f-4482-b3da-1fef25bebf7a')
BEGIN
	INSERT AspNetRoles (Id, [Name], [NormalizedName])
	VALUES ('82f26451-3c9f-4482-b3da-1fef25bebf7a', 'admin', 'ADMIN')
END

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id='82f26451-3c9f-4482-b3da-1fef25bebf7a'");
        }
    }
}
