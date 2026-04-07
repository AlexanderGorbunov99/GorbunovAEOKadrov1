CREATE TABLE [dbo].[Dety] (
    [NomerSvidORozh] NVARCHAR (15) NOT NULL,
    [Imya]           NVARCHAR (50) NOT NULL,
    [GodRozh]        INT           NOT NULL,
    [Pol]            NCHAR (1)     NOT NULL,
    [TabelNomerSotr] INT           NOT NULL,
    CONSTRAINT [PK_DETY] PRIMARY KEY CLUSTERED ([NomerSvidORozh] ASC),
    CONSTRAINT [Dety_fk0] FOREIGN KEY ([TabelNomerSotr]) REFERENCES [dbo].[Sotrudnik] ([TabelNomerSotr]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[Otdel] (
    [nomerOtdela]    INT            NOT NULL,
    [nazvanieOtdela] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_OTDEL] PRIMARY KEY CLUSTERED ([nomerOtdela] ASC)
);
CREATE TABLE [dbo].[Sotrudnik] (
    [TabelNomerSotr] INT           NOT NULL,
    [Familiya]       NVARCHAR (50) NOT NULL,
    [Imya]           NVARCHAR (50) NOT NULL,
    [Otchestvo]      NVARCHAR (50) NOT NULL,
    [StazhRaboty]    INT           NOT NULL,
    [PolSortudnika]  NCHAR (1)     NOT NULL,
    [nomerOtdela]    INT           NOT NULL,
    CONSTRAINT [PK_SOTRUDNIK] PRIMARY KEY CLUSTERED ([TabelNomerSotr] ASC),
    CONSTRAINT [Sotrudnik_fk0] FOREIGN KEY ([nomerOtdela]) REFERENCES [dbo].[Otdel] ([nomerOtdela]) ON UPDATE CASCADE
);

