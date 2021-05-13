CREATE TABLE [dbo].[MillingMachine]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[MachineName] VARCHAR(100) NOT NULL,
	[MachineNumber] SMALLINT NOT NULL,
	[MachineTypeId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_MillingMachine_ToTable] FOREIGN KEY ([MachineTypeId]) REFERENCES [MachineType]([Id]),

)
