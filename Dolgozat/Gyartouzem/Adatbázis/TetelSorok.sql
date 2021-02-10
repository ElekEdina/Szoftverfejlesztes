CREATE TABLE [dbo].[Tetelsorok] (
    [ID_Tetelsorok] BIGINT     NOT NULL,
    [IDtermek]      BIGINT     NOT NULL,
    [Mennyiseg]     NCHAR (10) NOT NULL,
    [IDme]          BIGINT     NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Tetelsorok] ASC),
    CONSTRAINT [FK_Tetelsorok_Termek_ID_Termek] FOREIGN KEY ([IDtermek]) REFERENCES [dbo].[Termek] ([ID_Termek]),
    CONSTRAINT [FK_Tetelsorok_ME_ID_ME] FOREIGN KEY ([IDme]) REFERENCES [dbo].[ME] ([ID_ME])
);


GO
CREATE NONCLUSTERED INDEX [IDX_Tetelsorok_IDtermek]
    ON [dbo].[Tetelsorok]([IDtermek] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_Tetelsorok_IDme]
    ON [dbo].[Tetelsorok]([IDme] ASC);

