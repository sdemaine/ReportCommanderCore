using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportCommander.Infrastructure.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    VersionNumber = table.Column<int>(type: "int", nullable: false),
                    VersionData = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatabaseConnections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatabaseServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SqlUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SqlPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseConnections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientEmailAddressList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlankReportEmailRecipient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderInBody = table.Column<bool>(type: "bit", nullable: false),
                    HighPriority = table.Column<bool>(type: "bit", nullable: false),
                    EmailAttachmentMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailBodyRowCountLimit = table.Column<int>(type: "int", nullable: false),
                    EmailDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowColorList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowHeaders = table.Column<bool>(type: "bit", nullable: false),
                    FreezeTopRow = table.Column<bool>(type: "bit", nullable: false),
                    OutputFolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailExcelFile = table.Column<bool>(type: "bit", nullable: false),
                    SaveExcelFile = table.Column<bool>(type: "bit", nullable: false),
                    EmailDelimitedFile = table.Column<bool>(type: "bit", nullable: false),
                    SaveDelimitedFile = table.Column<bool>(type: "bit", nullable: false),
                    Delimiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaveXtraReport = table.Column<bool>(type: "bit", nullable: false),
                    XtraReportParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailXtraReport = table.Column<bool>(type: "bit", nullable: false),
                    SendFTP = table.Column<bool>(type: "bit", nullable: false),
                    SecureFTP = table.Column<bool>(type: "bit", nullable: false),
                    FTPHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPDestinationFolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSHFingerprint = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailRecipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDistributionGroup = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailRecipients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DarkModeEnabled = table.Column<bool>(type: "bit", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportOwnerUserID = table.Column<int>(type: "int", nullable: false),
                    SkipWhenEmpty = table.Column<bool>(type: "bit", nullable: false),
                    DatabaseConnectionId = table.Column<int>(type: "int", nullable: false),
                    StoredProcedureName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ParameterList = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CommandTimeout = table.Column<int>(type: "int", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XtraReport = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configs_DatabaseConnections_DatabaseConnectionId",
                        column: x => x.DatabaseConnectionId,
                        principalTable: "DatabaseConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    LastExecutionTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DynamicDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunOnMonday = table.Column<bool>(type: "bit", nullable: false),
                    RunOnTuesday = table.Column<bool>(type: "bit", nullable: false),
                    RunOnWednesday = table.Column<bool>(type: "bit", nullable: false),
                    RunOnThursday = table.Column<bool>(type: "bit", nullable: false),
                    RunOnFriday = table.Column<bool>(type: "bit", nullable: false),
                    RunOnSaturday = table.Column<bool>(type: "bit", nullable: false),
                    RunOnSunday = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryEmailRecipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    EmailRecipientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryEmailRecipients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryEmailRecipients_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryEmailRecipients_EmailRecipients_EmailRecipientId",
                        column: x => x.EmailRecipientId,
                        principalTable: "EmailRecipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDepartmentAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartmentAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDepartmentAssignments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartmentAssignments_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConfigDepartmentAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigDepartmentAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigDepartmentAssignments_Configs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "Configs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfigDepartmentAssignments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConfigUserAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigId = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigUserAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigUserAssignments_Configs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "Configs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfigUserAssignments_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    ConfigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryConfigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryConfigs_Configs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "Configs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryConfigs_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterQueries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigId = table.Column<int>(type: "int", nullable: false),
                    ParameterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Query = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayField = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterQueries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterQueries_Configs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "Configs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Queue_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExecutionHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueueId = table.Column<int>(type: "int", nullable: false),
                    ExecutionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExecutionHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExecutionHistory_Queue_QueueId",
                        column: x => x.QueueId,
                        principalTable: "Queue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutputHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExecutionHistoryId = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutputFolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmail = table.Column<bool>(type: "bit", nullable: false),
                    IsPDF = table.Column<bool>(type: "bit", nullable: false),
                    IsCSV = table.Column<bool>(type: "bit", nullable: false),
                    IsFTP = table.Column<bool>(type: "bit", nullable: false),
                    FtpRemoteDirectory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FtpHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FtpUsername = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutputHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutputHistory_ExecutionHistory_ExecutionHistoryId",
                        column: x => x.ExecutionHistoryId,
                        principalTable: "ExecutionHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigDepartmentAssignments_ConfigId",
                table: "ConfigDepartmentAssignments",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigDepartmentAssignments_DepartmentId",
                table: "ConfigDepartmentAssignments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Configs_DatabaseConnectionId",
                table: "Configs",
                column: "DatabaseConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigUserAssignments_ConfigId",
                table: "ConfigUserAssignments",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigUserAssignments_UserProfileId",
                table: "ConfigUserAssignments",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryConfigs_ConfigId",
                table: "DeliveryConfigs",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryConfigs_DeliveryId",
                table: "DeliveryConfigs",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryEmailRecipients_DeliveryId",
                table: "DeliveryEmailRecipients",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryEmailRecipients_EmailRecipientId",
                table: "DeliveryEmailRecipients",
                column: "EmailRecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionHistory_QueueId",
                table: "ExecutionHistory",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_OutputHistory_ExecutionHistoryId",
                table: "OutputHistory",
                column: "ExecutionHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterQueries_ConfigId",
                table: "ParameterQueries",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_Queue_ScheduleId",
                table: "Queue",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DeliveryId",
                table: "Schedules",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartmentAssignments_DepartmentId",
                table: "UserDepartmentAssignments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartmentAssignments_UserProfileId",
                table: "UserDepartmentAssignments",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditRecord");

            migrationBuilder.DropTable(
                name: "ConfigDepartmentAssignments");

            migrationBuilder.DropTable(
                name: "ConfigUserAssignments");

            migrationBuilder.DropTable(
                name: "DeliveryConfigs");

            migrationBuilder.DropTable(
                name: "DeliveryEmailRecipients");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "OutputHistory");

            migrationBuilder.DropTable(
                name: "ParameterQueries");

            migrationBuilder.DropTable(
                name: "UserDepartmentAssignments");

            migrationBuilder.DropTable(
                name: "EmailRecipients");

            migrationBuilder.DropTable(
                name: "ExecutionHistory");

            migrationBuilder.DropTable(
                name: "Configs");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Queue");

            migrationBuilder.DropTable(
                name: "DatabaseConnections");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Deliveries");
        }
    }
}
