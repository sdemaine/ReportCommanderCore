
BEGIN TRANSACTION;
GO

ALTER TABLE [UserProfiles] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [UserProfiles] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [UserProfiles] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [UserProfiles] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [UserProfiles] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [UserDepartmentAssignments] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [UserDepartmentAssignments] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [UserDepartmentAssignments] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [UserDepartmentAssignments] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [UserDepartmentAssignments] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [Schedules] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Schedules] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Schedules] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Schedules] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [Schedules] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [Queue] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Queue] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Queue] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Queue] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [Queue] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [ParameterQueries] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [ParameterQueries] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [ParameterQueries] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ParameterQueries] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [ParameterQueries] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [OutputHistory] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [OutputHistory] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [OutputHistory] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [OutputHistory] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [OutputHistory] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [Notes] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Notes] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Notes] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Notes] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [Notes] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [ExecutionHistory] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [ExecutionHistory] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [ExecutionHistory] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ExecutionHistory] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [ExecutionHistory] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [EmailRecipients] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [EmailRecipients] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [EmailRecipients] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [EmailRecipients] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [EmailRecipients] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [Departments] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Departments] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Departments] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Departments] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [Departments] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [DeliveryEmailRecipients] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [DeliveryEmailRecipients] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [DeliveryEmailRecipients] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [DeliveryEmailRecipients] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [DeliveryEmailRecipients] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [DeliveryConfigs] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [DeliveryConfigs] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [DeliveryConfigs] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [DeliveryConfigs] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [DeliveryConfigs] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [Deliveries] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Deliveries] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Deliveries] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Deliveries] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [Deliveries] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [DatabaseConnections] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [DatabaseConnections] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [DatabaseConnections] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [DatabaseConnections] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [DatabaseConnections] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [ConfigUserAssignments] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [ConfigUserAssignments] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [ConfigUserAssignments] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ConfigUserAssignments] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [ConfigUserAssignments] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [Configs] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Configs] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Configs] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Configs] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [Configs] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [ConfigDepartmentAssignments] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [ConfigDepartmentAssignments] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [ConfigDepartmentAssignments] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [ConfigDepartmentAssignments] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [ConfigDepartmentAssignments] ADD [UpdatedDate] datetime2 NULL;
GO

ALTER TABLE [AuditRecord] ADD [CreatedByUserId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [AuditRecord] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [AuditRecord] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [AuditRecord] ADD [UpdatedByUserId] int NULL;
GO

ALTER TABLE [AuditRecord] ADD [UpdatedDate] datetime2 NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221005172859_inherit from BaseEntity', N'6.0.9');
GO

COMMIT;
GO

