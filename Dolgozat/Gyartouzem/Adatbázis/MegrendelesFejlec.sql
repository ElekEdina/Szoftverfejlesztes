CREATE TABLE [dbo].[MegrendelesFejlec] (
    [ID_MegrendelesFejlec] BIGINT     NOT NULL,
    [MegrendelesSzam]      BIGINT NOT NULL,
    [MegrendelesDatuma]    DATE       NOT NULL,
    [SzallitasNapja]       DATE       NOT NULL,
    [IDvevo]               BIGINT     NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_MegrendelesFejlec] ASC),
    UNIQUE NONCLUSTERED ([MegrendelesSzam] ASC)
);