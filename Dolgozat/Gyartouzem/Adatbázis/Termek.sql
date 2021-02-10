CREATE TABLE [dbo].[Termek] (
    [ID_Termek]  BIGINT     NOT NULL,
    [Megnevezes] NCHAR (20) NOT NULL,
    [IDme]       BIGINT     NOT NULL,
    [Keszlet]    NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Termek] ASC),
    UNIQUE NONCLUSTERED ([Megnevezes] ASC),
    CONSTRAINT [FK_Termek_ME_ID_ME] FOREIGN KEY ([IDme]) REFERENCES [dbo].[ME] ([ID_ME])
);


GO
CREATE NONCLUSTERED INDEX [IDX_Termek_IDme]
    ON [dbo].[Termek]([IDme] ASC);

