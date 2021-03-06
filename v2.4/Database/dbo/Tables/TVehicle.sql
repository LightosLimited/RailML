CREATE TABLE [dbo].[TVehicle]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TVehicleId]						SMALLINT			NOT NULL,
	[VehicleFamilyRef]					NVARCHAR(MAX)	NOT NULL,
	[VehicleCategory]					NVARCHAR(MAX)	NOT NULL,
	[AxleSequence]						NVARCHAR(MAX)	NOT NULL,
	[NumberDrivenAxles]				NVARCHAR(MAX)	NOT NULL,
	[NumberNonDrivenAxles]				NVARCHAR(MAX)	NOT NULL,
	[TrackGaugeValue]					DECIMAL(18, 6)	NOT NULL,
	[TrackGaugeValueSpecified]			BIT				NOT NULL,
	[TrackGaugeAlternativeValue]		DECIMAL(18, 6)	NOT NULL,
	[TrackGaugeAlternativeValueSpecified]	BIT				NOT NULL,
	[AdjustableWheelSetValue]			BIT				NOT NULL,
	[AdjustableWheelSetValueSpecified]	BIT				NOT NULL,
	[LengthValue]						DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]				BIT				NOT NULL,
	[SpeedValue]						DECIMAL(18, 6)	NOT NULL,
	[SpeedValueSpecified]				BIT				NOT NULL,
	[TowingSpeedValue]					DECIMAL(18, 6)	NOT NULL,
	[TowingSpeedValueSpecified]		BIT				NOT NULL,
	[BruttoWeightValue]				DECIMAL(18, 6)	NOT NULL,
	[BruttoWeightValueSpecified]		BIT				NOT NULL,
	[NettoWeightValue]					DECIMAL(18, 6)	NOT NULL,
	[NettoWeightValueSpecified]		BIT				NOT NULL,
	[TareWeightValue]					DECIMAL(18, 6)	NOT NULL,
	[TareWeightValueSpecified]			BIT				NOT NULL,
	[BruttoAdhesionWeightValue]		DECIMAL(18, 6)	NOT NULL,
	[BruttoAdhesionWeightValueSpecified]BIT				NOT NULL,
	[TareAdhesionWeightValue]			DECIMAL(18, 6)	NOT NULL,
	[TareAdhesionWeightValueSpecified]	BIT				NOT NULL,
	[NettoAdhesionWeightValue]			DECIMAL(18, 6)	NOT NULL,
	[NettoAdhesionWeightValueSpecified]BIT				NOT NULL,
	[AxleLoadValue]					DECIMAL(18, 6)	NOT NULL,
	[AxleLoadValueSpecified]			BIT				NOT NULL,
	[ResistanceFactorValue]			DECIMAL(18, 6)	NOT NULL,
	[ResistanceFactorValueSpecified]	BIT				NOT NULL,
	[OnTrainHeadValue]					BIT				NOT NULL,
	[OnTrainHeadValueSpecified]		BIT				NOT NULL,
	[OnTrainTailOnlyValue]				BIT				NOT NULL,
	[OnTrainTailOnlyValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TVehicleId] PRIMARY KEY CLUSTERED ([TVehicleId] ASC)
);
