CREATE TABLE [dbo].[Alapanyag] (
    [ID_Alapanyag] BIGINT     NOT NULL,
    [Megnevezes]   NCHAR (20) NOT NULL,
    [IDtermek]       BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Alapanyag] ASC),
    UNIQUE NONCLUSTERED ([Megnevezes] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_Alapanyag_Termek]
    ON [dbo].[Alapanyag]([IDtermek] ASC);