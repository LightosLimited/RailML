CREATE TABLE [dbo].[TTractionMotor]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTractionMotorId]						BIGINT			NOT NULL,
	[Count]								NVARCHAR(MAX)	NOT NULL,
	[AssemblyName]							NVARCHAR(MAX)	NOT NULL,
	[NominalPowerValue]					DECIMAL(18, 6)	NOT NULL,
	[NominalPowerValueSpecified]			BIT				NOT NULL,
	[NominalVoltageValue]					DECIMAL(18, 6)	NOT NULL,
	[NominalVoltageValueSpecified]			BIT				NOT NULL,
	[NominalCurrentValue]					DECIMAL(18, 6)	NOT NULL,
	[NominalCurrentValueSpecified]			BIT				NOT NULL,
	[NominalFrequencyValue]				DECIMAL(18, 6)	NOT NULL,
	[NominalFrequencyValueSpecified]		BIT				NOT NULL,
	[NominalFluxValue]						DECIMAL(18, 6)	NOT NULL,
	[NominalFluxValueSpecified]			BIT				NOT NULL,
	[NominalPhiValue]						DECIMAL(18, 6)	NOT NULL,
	[NominalPhiValueSpecified]				BIT				NOT NULL,
	[NumberPolePairs]						NVARCHAR(MAX)	NOT NULL,
	[StatorResistanceValue]				DECIMAL(18, 6)	NOT NULL,
	[StatorResistanceValueSpecified]		BIT				NOT NULL,
	[RotorResistanceValue]					DECIMAL(18, 6)	NOT NULL,
	[RotorResistanceValueSpecified]		BIT				NOT NULL,
	[FerrumResistanceValue]				DECIMAL(18, 6)	NOT NULL,
	[FerrumResistanceValueSpecified]		BIT				NOT NULL,
	[AdditionalResistanceValue]			DECIMAL(18, 6)	NOT NULL,
	[AdditionalResistanceValueSpecified]	BIT				NOT NULL,
	[MainInductanceValue]					DECIMAL(18, 6)	NOT NULL,
	[MainInductanceValueSpecified]			BIT				NOT NULL,
	[StatorLeakageInductanceValue]			DECIMAL(18, 6)	NOT NULL,
	[StatorLeakageInductanceValueSpecified]	BIT				NOT NULL,
	[RotorLeakageInductanceValue]			DECIMAL(18, 6)	NOT NULL,
	[RotorLeakageInductanceValueSpecified]	BIT				NOT NULL,
	[NominalRevolutions]					NVARCHAR(MAX)	NOT NULL,
	[MeanEfficiencyValue]					DECIMAL(18, 6)	NOT NULL,
	[MeanEfficiencyValueSpecified]			BIT				NOT NULL,

	CONSTRAINT [PK_TTractionMotorId] PRIMARY KEY CLUSTERED ([TTractionMotorId] ASC)
);
