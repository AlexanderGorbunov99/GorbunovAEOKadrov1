CREATE TABLE [dbo].[Dety] (
    [NomerSvidORozh] NVARCHAR (15) NOT NULL,
    [Imya]           NVARCHAR (50) NOT NULL,
    [GodRozh]        INT           NOT NULL,
    [Pol]            NCHAR (1)     NOT NULL,
    [TabelNomerSotr] INT           NOT NULL,
    CONSTRAINT [PK_DETY] PRIMARY KEY CLUSTERED ([NomerSvidORozh] ASC),
    CONSTRAINT [Dety_fk0] FOREIGN KEY ([TabelNomerSotr]) REFERENCES [dbo].[Sotrudnik] ([TabelNomerSotr]) ON UPDATE CASCADE
);
