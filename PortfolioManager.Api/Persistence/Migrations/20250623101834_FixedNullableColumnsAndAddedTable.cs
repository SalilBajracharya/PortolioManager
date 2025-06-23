using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioManager.Api.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixedNullableColumnsAndAddedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationTab_AspNetUsers_UserId",
                table: "EducationTab");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceTab_AspNetUsers_UserId",
                table: "ExperienceTab");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEducation_EducationTab_EducationTabId",
                table: "UserEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExperience_ExperienceTab_ExperienceTabId",
                table: "UserExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_AspNetUsers_UserId",
                table: "UserProjects");

            migrationBuilder.DropIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExperience",
                table: "UserExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEducation",
                table: "UserEducation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperienceTab",
                table: "ExperienceTab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationTab",
                table: "EducationTab");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserProjects");

            migrationBuilder.RenameTable(
                name: "UserExperience",
                newName: "UserExperiences");

            migrationBuilder.RenameTable(
                name: "UserEducation",
                newName: "UserEducations");

            migrationBuilder.RenameTable(
                name: "ExperienceTab",
                newName: "ExperienceTabs");

            migrationBuilder.RenameTable(
                name: "EducationTab",
                newName: "EducationTabs");

            migrationBuilder.RenameIndex(
                name: "IX_UserExperience_ExperienceTabId",
                table: "UserExperiences",
                newName: "IX_UserExperiences_ExperienceTabId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEducation_EducationTabId",
                table: "UserEducations",
                newName: "IX_UserEducations_EducationTabId");

            migrationBuilder.RenameIndex(
                name: "IX_ExperienceTab_UserId",
                table: "ExperienceTabs",
                newName: "IX_ExperienceTabs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationTab_UserId",
                table: "EducationTabs",
                newName: "IX_EducationTabs_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "TechStackNames",
                table: "UserTechStacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TechPageQuote",
                table: "UserTechStacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TechDescription",
                table: "UserTechStacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TechStacks",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectUrl",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectTitle",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectPageQuote",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectDetails",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Learnings",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Features",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Challenges",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ProjectTabId",
                table: "UserProjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ShortIntro",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LongIntro",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "UserExperiences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCurrent",
                table: "UserEducations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "EducationDetails",
                table: "UserEducations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ExperienceSummary",
                table: "ExperienceTabs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ExperienceQuote",
                table: "ExperienceTabs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EducationSummary",
                table: "EducationTabs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EducationQuote",
                table: "EducationTabs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExperiences",
                table: "UserExperiences",
                column: "Recid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEducations",
                table: "UserEducations",
                column: "Recid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperienceTabs",
                table: "ExperienceTabs",
                column: "Recid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationTabs",
                table: "EducationTabs",
                column: "Recid");

            migrationBuilder.CreateTable(
                name: "ProjectTabs",
                columns: table => new
                {
                    Recid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectPageQuote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTabs", x => x.Recid);
                    table.ForeignKey(
                        name: "FK_ProjectTabs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_ProjectTabId",
                table: "UserProjects",
                column: "ProjectTabId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTabs_UserId",
                table: "ProjectTabs",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationTabs_AspNetUsers_UserId",
                table: "EducationTabs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceTabs_AspNetUsers_UserId",
                table: "ExperienceTabs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEducations_EducationTabs_EducationTabId",
                table: "UserEducations",
                column: "EducationTabId",
                principalTable: "EducationTabs",
                principalColumn: "Recid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExperiences_ExperienceTabs_ExperienceTabId",
                table: "UserExperiences",
                column: "ExperienceTabId",
                principalTable: "ExperienceTabs",
                principalColumn: "Recid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_ProjectTabs_ProjectTabId",
                table: "UserProjects",
                column: "ProjectTabId",
                principalTable: "ProjectTabs",
                principalColumn: "Recid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationTabs_AspNetUsers_UserId",
                table: "EducationTabs");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceTabs_AspNetUsers_UserId",
                table: "ExperienceTabs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEducations_EducationTabs_EducationTabId",
                table: "UserEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExperiences_ExperienceTabs_ExperienceTabId",
                table: "UserExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_ProjectTabs_ProjectTabId",
                table: "UserProjects");

            migrationBuilder.DropTable(
                name: "ProjectTabs");

            migrationBuilder.DropIndex(
                name: "IX_UserProjects_ProjectTabId",
                table: "UserProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExperiences",
                table: "UserExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEducations",
                table: "UserEducations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperienceTabs",
                table: "ExperienceTabs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationTabs",
                table: "EducationTabs");

            migrationBuilder.DropColumn(
                name: "ProjectTabId",
                table: "UserProjects");

            migrationBuilder.RenameTable(
                name: "UserExperiences",
                newName: "UserExperience");

            migrationBuilder.RenameTable(
                name: "UserEducations",
                newName: "UserEducation");

            migrationBuilder.RenameTable(
                name: "ExperienceTabs",
                newName: "ExperienceTab");

            migrationBuilder.RenameTable(
                name: "EducationTabs",
                newName: "EducationTab");

            migrationBuilder.RenameIndex(
                name: "IX_UserExperiences_ExperienceTabId",
                table: "UserExperience",
                newName: "IX_UserExperience_ExperienceTabId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEducations_EducationTabId",
                table: "UserEducation",
                newName: "IX_UserEducation_EducationTabId");

            migrationBuilder.RenameIndex(
                name: "IX_ExperienceTabs_UserId",
                table: "ExperienceTab",
                newName: "IX_ExperienceTab_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationTabs_UserId",
                table: "EducationTab",
                newName: "IX_EducationTab_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "TechStackNames",
                table: "UserTechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TechPageQuote",
                table: "UserTechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TechDescription",
                table: "UserTechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TechStacks",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectUrl",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectTitle",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectPageQuote",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectDetails",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Learnings",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Features",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Challenges",
                table: "UserProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserProjects",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ShortIntro",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LongIntro",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "UserExperience",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsCurrent",
                table: "UserEducation",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EducationDetails",
                table: "UserEducation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExperienceSummary",
                table: "ExperienceTab",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExperienceQuote",
                table: "ExperienceTab",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EducationSummary",
                table: "EducationTab",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EducationQuote",
                table: "EducationTab",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExperience",
                table: "UserExperience",
                column: "Recid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEducation",
                table: "UserEducation",
                column: "Recid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperienceTab",
                table: "ExperienceTab",
                column: "Recid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationTab",
                table: "EducationTab",
                column: "Recid");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationTab_AspNetUsers_UserId",
                table: "EducationTab",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceTab_AspNetUsers_UserId",
                table: "ExperienceTab",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEducation_EducationTab_EducationTabId",
                table: "UserEducation",
                column: "EducationTabId",
                principalTable: "EducationTab",
                principalColumn: "Recid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExperience_ExperienceTab_ExperienceTabId",
                table: "UserExperience",
                column: "ExperienceTabId",
                principalTable: "ExperienceTab",
                principalColumn: "Recid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_AspNetUsers_UserId",
                table: "UserProjects",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
