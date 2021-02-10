CREATE TABLE [dbo].[Vevok] (
    [ID_Vevo] BIGINT     NOT NULL,
    [Nev]     NCHAR (20) NOT NULL,
    [Helyseg] NCHAR (20) NOT NULL,
    [Cim]     NCHAR (50) NOT NULL,
    [IRSZ]    NCHAR (4)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Vevo] ASC),
    UNIQUE NONCLUSTERED ([Nev] ASC)
);

