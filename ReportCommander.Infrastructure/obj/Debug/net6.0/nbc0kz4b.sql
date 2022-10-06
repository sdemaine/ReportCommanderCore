IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AuditRecord] (
    [Id] int NOT NULL IDENTITY,
    [EntityType] nvarchar(max) NOT NULL,
    [EntityId] int NOT NULL,
    [VersionNumber] int NOT NULL,
    [VersionData] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_AuditRecord] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [DatabaseConnections] (
    [Id] int NOT NULL IDENTITY,
    [ConnectionName] nvarchar(max) NOT NULL,
    [DatabaseServer] nvarchar(max) NOT NULL,
    [DatabaseName] nvarchar(max) NOT NULL,
    [SqlUsername] nvarchar(max) NOT NULL,
    [SqlPassword] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_DatabaseConnections] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Deliveries] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [MailHost] nvarchar(max) NULL,
    [SubjectLine] nvarchar(max) NULL,
    [SenderEmailAddress] nvarchar(max) NULL,
    [RecipientEmailAddressList] nvarchar(max) NULL,
    [BlankReportEmailRecipient] nvarchar(max) NULL,
    [RenderInBody] bit NOT NULL,
    [HighPriority] bit NOT NULL,
    [EmailAttachmentMessage] nvarchar(max) NULL,
    [EmailBodyRowCountLimit] int NOT NULL,
    [EmailDescription] nvarchar(max) NULL,
    [EmailTemplate] nvarchar(max) NULL,
    [RowColorList] nvarchar(max) NULL,
    [ShowHeaders] bit NOT NULL,
    [FreezeTopRow] bit NOT NULL,
    [OutputFolder] nvarchar(max) NULL,
    [EmailExcelFile] bit NOT NULL,
    [SaveExcelFile] bit NOT NULL,
    [EmailDelimitedFile] bit NOT NULL,
    [SaveDelimitedFile] bit NOT NULL,
    [Delimiter] nvarchar(max) NULL,
    [SaveXtraReport] bit NOT NULL,
    [XtraReportParameters] nvarchar(max) NULL,
    [EmailXtraReport] bit NOT NULL,
    [SendFTP] bit NOT NULL,
    [SecureFTP] bit NOT NULL,
    [FTPHost] nvarchar(max) NULL,
    [FTPUsername] nvarchar(max) NULL,
    [FTPPassword] nvarchar(max) NULL,
    [FTPDestinationFolder] nvarchar(max) NULL,
    [SSHFingerprint] nvarchar(max) NULL,
    CONSTRAINT [PK_Deliveries] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Departments] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EmailRecipients] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [EmailAddress] nvarchar(max) NOT NULL,
    [IsDistributionGroup] bit NOT NULL,
    CONSTRAINT [PK_EmailRecipients] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Notes] (
    [Id] int NOT NULL IDENTITY,
    [Content] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Notes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [UserProfiles] (
    [Id] int NOT NULL IDENTITY,
    [UserID] int NOT NULL,
    [IsAdmin] bit NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [DarkModeEnabled] bit NOT NULL,
    [EmailAddress] nvarchar(max) NULL,
    [ProfilePhoto] varbinary(max) NULL,
    CONSTRAINT [PK_UserProfiles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Configs] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [ReportOwnerUserID] int NOT NULL,
    [SkipWhenEmpty] bit NOT NULL,
    [DatabaseConnectionId] int NOT NULL,
    [StoredProcedureName] nvarchar(1000) NOT NULL,
    [ParameterList] nvarchar(4000) NOT NULL,
    [CommandTimeout] int NOT NULL,
    [Filename] nvarchar(max) NULL,
    [XtraReport] varbinary(max) NULL,
    CONSTRAINT [PK_Configs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Configs_DatabaseConnections_DatabaseConnectionId] FOREIGN KEY ([DatabaseConnectionId]) REFERENCES [DatabaseConnections] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Schedules] (
    [Id] int NOT NULL IDENTITY,
    [DeliveryId] int NOT NULL,
    [LastExecutionTimeStamp] datetime2 NULL,
    [DynamicDate] nvarchar(max) NOT NULL,
    [ScheduleTime] nvarchar(max) NOT NULL,
    [RunOnMonday] bit NOT NULL,
    [RunOnTuesday] bit NOT NULL,
    [RunOnWednesday] bit NOT NULL,
    [RunOnThursday] bit NOT NULL,
    [RunOnFriday] bit NOT NULL,
    [RunOnSaturday] bit NOT NULL,
    [RunOnSunday] bit NOT NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Schedules] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Schedules_Deliveries_DeliveryId] FOREIGN KEY ([DeliveryId]) REFERENCES [Deliveries] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [DeliveryEmailRecipients] (
    [Id] int NOT NULL IDENTITY,
    [DeliveryId] int NOT NULL,
    [EmailRecipientId] int NOT NULL,
    CONSTRAINT [PK_DeliveryEmailRecipients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DeliveryEmailRecipients_Deliveries_DeliveryId] FOREIGN KEY ([DeliveryId]) REFERENCES [Deliveries] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DeliveryEmailRecipients_EmailRecipients_EmailRecipientId] FOREIGN KEY ([EmailRecipientId]) REFERENCES [EmailRecipients] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserDepartmentAssignments] (
    [Id] int NOT NULL IDENTITY,
    [UserProfileId] int NOT NULL,
    [DepartmentId] int NOT NULL,
    CONSTRAINT [PK_UserDepartmentAssignments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserDepartmentAssignments_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserDepartmentAssignments_UserProfiles_UserProfileId] FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfiles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ConfigDepartmentAssignments] (
    [Id] int NOT NULL IDENTITY,
    [ConfigId] int NOT NULL,
    [DepartmentId] int NOT NULL,
    CONSTRAINT [PK_ConfigDepartmentAssignments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ConfigDepartmentAssignments_Configs_ConfigId] FOREIGN KEY ([ConfigId]) REFERENCES [Configs] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ConfigDepartmentAssignments_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ConfigUserAssignments] (
    [Id] int NOT NULL IDENTITY,
    [ConfigId] int NOT NULL,
    [UserProfileId] int NOT NULL,
    CONSTRAINT [PK_ConfigUserAssignments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ConfigUserAssignments_Configs_ConfigId] FOREIGN KEY ([ConfigId]) REFERENCES [Configs] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ConfigUserAssignments_UserProfiles_UserProfileId] FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfiles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [DeliveryConfigs] (
    [Id] int NOT NULL IDENTITY,
    [DeliveryId] int NOT NULL,
    [ConfigId] int NOT NULL,
    CONSTRAINT [PK_DeliveryConfigs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DeliveryConfigs_Configs_ConfigId] FOREIGN KEY ([ConfigId]) REFERENCES [Configs] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DeliveryConfigs_Deliveries_DeliveryId] FOREIGN KEY ([DeliveryId]) REFERENCES [Deliveries] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ParameterQueries] (
    [Id] int NOT NULL IDENTITY,
    [ConfigId] int NOT NULL,
    [ParameterName] nvarchar(max) NOT NULL,
    [Query] nvarchar(max) NOT NULL,
    [ValueField] nvarchar(max) NOT NULL,
    [DisplayField] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ParameterQueries] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ParameterQueries_Configs_ConfigId] FOREIGN KEY ([ConfigId]) REFERENCES [Configs] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Queue] (
    [Id] int NOT NULL IDENTITY,
    [ScheduleId] int NOT NULL,
    [IsProcessed] bit NOT NULL,
    [ProcessDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Queue] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Queue_Schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [Schedules] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ExecutionHistory] (
    [Id] int NOT NULL IDENTITY,
    [QueueId] int NOT NULL,
    [ExecutionDate] datetime2 NOT NULL,
    CONSTRAINT [PK_ExecutionHistory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ExecutionHistory_Queue_QueueId] FOREIGN KEY ([QueueId]) REFERENCES [Queue] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [OutputHistory] (
    [Id] int NOT NULL IDENTITY,
    [ExecutionHistoryId] int NOT NULL,
    [EmailAddress] nvarchar(max) NOT NULL,
    [OutputFolder] nvarchar(max) NOT NULL,
    [Filename] nvarchar(max) NOT NULL,
    [IsEmail] bit NOT NULL,
    [IsPDF] bit NOT NULL,
    [IsCSV] bit NOT NULL,
    [IsFTP] bit NOT NULL,
    [FtpRemoteDirectory] nvarchar(max) NOT NULL,
    [FtpHost] nvarchar(max) NOT NULL,
    [FtpUsername] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_OutputHistory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OutputHistory_ExecutionHistory_ExecutionHistoryId] FOREIGN KEY ([ExecutionHistoryId]) REFERENCES [ExecutionHistory] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_ConfigDepartmentAssignments_ConfigId] ON [ConfigDepartmentAssignments] ([ConfigId]);
GO

CREATE INDEX [IX_ConfigDepartmentAssignments_DepartmentId] ON [ConfigDepartmentAssignments] ([DepartmentId]);
GO

CREATE INDEX [IX_Configs_DatabaseConnectionId] ON [Configs] ([DatabaseConnectionId]);
GO

CREATE INDEX [IX_ConfigUserAssignments_ConfigId] ON [ConfigUserAssignments] ([ConfigId]);
GO

CREATE INDEX [IX_ConfigUserAssignments_UserProfileId] ON [ConfigUserAssignments] ([UserProfileId]);
GO

CREATE INDEX [IX_DeliveryConfigs_ConfigId] ON [DeliveryConfigs] ([ConfigId]);
GO

CREATE INDEX [IX_DeliveryConfigs_DeliveryId] ON [DeliveryConfigs] ([DeliveryId]);
GO

CREATE INDEX [IX_DeliveryEmailRecipients_DeliveryId] ON [DeliveryEmailRecipients] ([DeliveryId]);
GO

CREATE INDEX [IX_DeliveryEmailRecipients_EmailRecipientId] ON [DeliveryEmailRecipients] ([EmailRecipientId]);
GO

CREATE INDEX [IX_ExecutionHistory_QueueId] ON [ExecutionHistory] ([QueueId]);
GO

CREATE INDEX [IX_OutputHistory_ExecutionHistoryId] ON [OutputHistory] ([ExecutionHistoryId]);
GO

CREATE INDEX [IX_ParameterQueries_ConfigId] ON [ParameterQueries] ([ConfigId]);
GO

CREATE INDEX [IX_Queue_ScheduleId] ON [Queue] ([ScheduleId]);
GO

CREATE INDEX [IX_Schedules_DeliveryId] ON [Schedules] ([DeliveryId]);
GO

CREATE INDEX [IX_UserDepartmentAssignments_DepartmentId] ON [UserDepartmentAssignments] ([DepartmentId]);
GO

CREATE INDEX [IX_UserDepartmentAssignments_UserProfileId] ON [UserDepartmentAssignments] ([UserProfileId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221005165509_initial migration', N'6.0.9');
GO

COMMIT;
GO

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

