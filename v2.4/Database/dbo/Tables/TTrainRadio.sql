CREATE TABLE [dbo].[TTrainRadio]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainRadioId]SMALLINT			NOT NULL,
	[OnBoardUnitID]NVARCHAR(MAX)	NOT NULL,
	[SoftwareVersion]	NVARCHAR(MAX)	NOT NULL,
	[Modulation]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainRadioId] PRIMARY KEY CLUSTERED ([TTrainRadioId] ASC)
);
