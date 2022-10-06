using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportCommander.Infrastructure.Migrations
{
    public partial class inheritfromBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "UserProfiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UserProfiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "UserDepartmentAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserDepartmentAssignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserDepartmentAssignments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "UserDepartmentAssignments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UserDepartmentAssignments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Schedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Queue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Queue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Queue",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Queue",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Queue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ParameterQueries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ParameterQueries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ParameterQueries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "ParameterQueries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ParameterQueries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "OutputHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OutputHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OutputHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "OutputHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "OutputHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Notes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Notes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ExecutionHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ExecutionHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ExecutionHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "ExecutionHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ExecutionHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "EmailRecipients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EmailRecipients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmailRecipients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "EmailRecipients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmailRecipients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DeliveryEmailRecipients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DeliveryEmailRecipients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DeliveryEmailRecipients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "DeliveryEmailRecipients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DeliveryEmailRecipients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DeliveryConfigs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DeliveryConfigs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DeliveryConfigs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "DeliveryConfigs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DeliveryConfigs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Deliveries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Deliveries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Deliveries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Deliveries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Deliveries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DatabaseConnections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DatabaseConnections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DatabaseConnections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "DatabaseConnections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DatabaseConnections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ConfigUserAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ConfigUserAssignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigUserAssignments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "ConfigUserAssignments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ConfigUserAssignments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Configs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Configs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Configs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Configs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Configs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ConfigDepartmentAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ConfigDepartmentAssignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ConfigDepartmentAssignments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "ConfigDepartmentAssignments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ConfigDepartmentAssignments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "AuditRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AuditRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AuditRecord",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "AuditRecord",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AuditRecord",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UserDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "UserDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UserDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ParameterQueries");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ParameterQueries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ParameterQueries");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "ParameterQueries");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ParameterQueries");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "OutputHistory");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OutputHistory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OutputHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "OutputHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "OutputHistory");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ExecutionHistory");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ExecutionHistory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ExecutionHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "ExecutionHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ExecutionHistory");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "EmailRecipients");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EmailRecipients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmailRecipients");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "EmailRecipients");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EmailRecipients");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DeliveryEmailRecipients");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DeliveryEmailRecipients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DeliveryEmailRecipients");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "DeliveryEmailRecipients");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DeliveryEmailRecipients");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DeliveryConfigs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DeliveryConfigs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DeliveryConfigs");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "DeliveryConfigs");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DeliveryConfigs");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DatabaseConnections");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DatabaseConnections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DatabaseConnections");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "DatabaseConnections");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DatabaseConnections");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ConfigUserAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ConfigUserAssignments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigUserAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "ConfigUserAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ConfigUserAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ConfigDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ConfigDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ConfigDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "ConfigDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ConfigDepartmentAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "AuditRecord");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AuditRecord");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AuditRecord");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "AuditRecord");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AuditRecord");
        }
    }
}
