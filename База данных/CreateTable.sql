SET ANSI_PADDING ON
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
CREATE DATABASE [Melans_LLC]
GO
USE [Melans_LLC]
GO

CREATE TABLE [DBO].[Role]
(
	[ID_Role] int not null identity(1,1),
	[Name_Role] varchar(50) not null unique,
	[OtdelKadrov_Role] int not null,
	[Injener_Role] int not null,
	[SystemAdmin_Role] int not null,
	[Prosmotr_Role] int not null,
	constraint [PK_Role] primary key clustered
	([ID_Role] ASC) on [primary]
)

CREATE TABLE [DBO].[Doljnost]
(
	[ID_Dolj] int not null identity(1,1),
	[Name_Dolj] varchar(80) not null unique,
	constraint [PK_Dolj] primary key clustered
	([ID_Dolj] ASC) on [primary]
)

CREATE TABLE [DBO].[Soiskatel]
(
	[ID_Soisk] int not null identity(1,1),
	[F_Soisk] varchar(max) not null,
	[I_Soisk] varchar(max) not null,
	[O_Soisk] varchar(max) not null,
	constraint [PK_Soisk] primary key clustered
	([ID_Soisk] ASC) on [primary]
)

CREATE TABLE [DBO].[Injener]
(
	[ID_Inj] int not null identity(1,1),
	[F_Inj] varchar(max) not null,
	[I_Inj] varchar(max) not null,
	[O_Inj] varchar(max) not null,
	constraint [PK_Inj] primary key clustered
	([ID_Inj] ASC) on [primary]
)

CREATE TABLE [DBO].[Uslugi]
(
	[ID_Uslug] int not null identity(1,1),
	[Name_Uslug] varchar(max) not null,
	[Opis_Uslug] varchar(max) not null,
	[Cena_Uslug] float not null,
	[Date_Uslug] varchar(10) not null,
	[Time_Uslug] varchar(5) not null,
	constraint [PK_Uslug] primary key clustered
	([ID_Uslug] ASC) on [primary]
)

CREATE TABLE [DBO].[Rabotodatel_otdela_kadrov]
(
	[ID_RabotodatelOK] int not null identity(1,1),
	[F_RabotodatelOK] varchar(max) not null,
	[I_RabotodatelOK] varchar(max) not null,
	[O_RabotodatelOK] varchar(max) not null,
	constraint [PK_RabotodatelOK] primary key clustered
	([ID_RabotodatelOK] ASC) on [primary]
)

CREATE TABLE [DBO].[Systemni_administrator]
(
	[ID_SysAdmin] int not null identity(1,1),
	[F_SysAdmin] varchar(max) not null,
	[I_SysAdmin] varchar(max) not null,
	[O_SysAdmin] varchar(max) not null,
	constraint [PK_SysAdmin] primary key clustered
	([ID_SysAdmin] ASC) on [primary]
)

CREATE TABLE [DBO].[Klient]
(
	[ID_Kl] int not null identity(1,1),
	[F_Kl] varchar(max) not null,
	[I_Kl] varchar(max) not null,
	[O_Kl] varchar(max) not null,
	constraint [PK_Kl] primary key clustered
	([ID_Kl] ASC) on [primary]
)

CREATE TABLE [DBO].[Vid_instructaja]
(
	[ID_VInst] int not null identity(1,1),
	[Name_VInst] varchar(50) not null,
	constraint [PK_VInst] primary key clustered
	([ID_VInst] ASC) on [primary]
)

CREATE TABLE [DBO].[Instructaj]
(
	[ID_Inst] int not null identity(1,1),
	[Num_Inst] varchar(50) not null,
	[Poysn_Inst] varchar(max) not null,
	[Date_Inst] varchar(10) not null,
	[Time_Inst] varchar(5) not null,
	[Status_Inst] int null,
	[Soisk_ID] int not null,
	[Inj_ID] int not null,
	[VInst_ID] int not null,
	constraint [PK_Inst] primary key clustered
	([ID_Inst] ASC) on [primary],
	constraint [FK_Soisk_ID] foreign key ([Soisk_ID])
	references [DBO].[Soiskatel] ([ID_Soisk]),
	constraint [FK_Inj_ID] foreign key ([Inj_ID])
	references [DBO].[Injener] ([ID_Inj]),
	constraint [FK_VInst_ID] foreign key ([VInst_ID])
	references [DBO].[Vid_instructaja] ([ID_VInst])
)

CREATE TABLE [DBO].[Pasport]
(
	[ID_Pasp] int not null identity(1,1),
	[Num_Pasp] varchar(50) not null,
	[Seria_Pasp] varchar(50) not null,
	[Vid_Pasp] varchar(50) not null,
	[AdresProjiv_Pasp] varchar(max) not null,
	[Date_Pasp] varchar(10) not null,
	[Time_Pasp] varchar(5) not null,
	[Soisk_ID] int not null,
	constraint [PK_Pasp] primary key clustered
	([ID_Pasp] ASC) on [primary],
	constraint [FK_SoiskPas_ID] foreign key ([Soisk_ID])
	references [DBO].[Soiskatel] ([ID_Soisk])
)

CREATE TABLE [DBO].[Sobesedovanie]
(
	[ID_Sobes] int not null identity(1,1),
	[Date_Sobes] varchar(10) not null,
	[Time_Sobes] varchar(5) not null,
	[Status_Sobes] int null,
	[RabotodatelOK_ID] int not null,
	[Pasp_ID] int not null,
	constraint [PK_Sobes] primary key clustered
	([ID_Sobes] ASC) on [primary],
	constraint [FK_RabotodatelOK_ID] foreign key ([RabotodatelOK_ID])
	references [DBO].[Rabotodatel_otdela_kadrov] ([ID_RabotodatelOK]),
	constraint [FK_Pasp_ID] foreign key ([Pasp_ID])
	references [DBO].[Pasport] ([ID_Pasp])
)

CREATE TABLE [DBO].[Grafik_Raboti]
(
	[ID_GrafRabot] int not null identity(1,1),
	[Cel_GrafRabot] varchar(max) not null,
	[Date_GrafRabot] varchar(10) not null,
	[TimeNach_GrafRabot] varchar(5) not null,
	[TimeOkonch_GrafRabot] varchar(5) not null,
	[Sobes_ID] int not null,
	constraint [PK_GrafRabot] primary key clustered
	([ID_GrafRabot] ASC) on [primary],
	constraint [FK_Sobes_ID] foreign key ([Sobes_ID])
	references [DBO].[Sobesedovanie] ([ID_Sobes])
)

CREATE TABLE [DBO].[Mesto_raboti]
(
	[ID_Mr] int not null identity(1,1),
	[NameOrg_Mr] varchar(max) not null,
	[DatePrin_Mr] varchar(10) not null,
	[DateUvol_Mr] varchar(10) not null,
	[Dolj_ID] int not null,
	constraint [PK_Mr] primary key clustered
	([ID_Mr] ASC) on [primary],
	constraint [FK_Dolj_ID] foreign key ([Dolj_ID])
	references [DBO].[Doljnost] ([ID_Dolj])
)

CREATE TABLE [DBO].[Prinyatie_documenta]
(
	[ID_PrinDOC] int not null identity(1,1),
	[Num_PrinDOC] varchar(max) not null,
	[Vid_PrinDOC] varchar(50) not null,
	[Date_PrinDOC] varchar(10) not null,
	[Mr_ID] int not null,
	[Sobes_ID] int not null,
	constraint [PK_PrinDOC] primary key clustered
	([ID_PrinDOC] ASC) on [primary],
	constraint [FK_Mr_ID] foreign key ([Mr_ID])
	references [DBO].[Mesto_raboti] ([ID_Mr]),
	constraint [FK_SobesPD_ID] foreign key ([Sobes_ID])
	references [DBO].[Sobesedovanie] ([ID_Sobes])
)

CREATE TABLE [DBO].[Registracia_polzovatelya]
(
	[ID_RegPolz] int not null identity(1,1),
	[F_RegPolz] varchar(max) not null,
	[I_RegPolz] varchar(max) not null,
	[O_RegPolz] varchar(max) not null,
	[Email_RegPolz] varchar(50) not null unique,
	[Tel_RegPolz] varchar(max) not null,
	[Log_RegPolz] varchar(50) not null unique,
	[Pass_RegPolz] varchar(max) not null,
	[Role_ID] int not null,
	[Dolj_ID] int not null,
	constraint [PK_RegPolz] primary key clustered
	([ID_RegPolz] ASC) on [primary],
	constraint [FK_Role_ID] foreign key ([Role_ID])
	references [DBO].[Role] ([ID_Role]),
	constraint [FK_DoljRP_ID] foreign key ([Dolj_ID])
	references [DBO].[Doljnost] ([ID_Dolj])
)

CREATE TABLE [DBO].[Zayavki]
(
	[ID_Zayavk] int not null identity(1,1),
	[Num_Zayavk] varchar(max) not null,
	[Date_Zayavk] varchar(10) not null,
	[Time_Zayavk] varchar(5) not null,
	[GrafRabot_ID] int not null,
	[Kl_ID] int not null,
	[SysAdmin_ID] int not null,
	[Uslug_ID] int not null,
	constraint [PK_Zayavk] primary key clustered
	([ID_Zayavk] ASC) on [primary],
	constraint [FK_GrafRabot_ID] foreign key ([GrafRabot_ID])
	references [DBO].[Grafik_Raboti] ([ID_GrafRabot]),
	constraint [FK_Kl_ID] foreign key ([Kl_ID])
	references [DBO].[Klient] ([ID_Kl]),
	constraint [FK_SysAdmin_ID] foreign key ([SysAdmin_ID])
	references [DBO].[Systemni_administrator] ([ID_SysAdmin]),
	constraint [FK_Uslug_ID] foreign key ([Uslug_ID])
	references [DBO].[Uslugi] ([ID_Uslug])
)

CREATE TABLE [DBO].[Technika]
(
	[ID_Tech] int not null identity(1,1),
	[Name_Tech] varchar(max) not null,
	[Date_Tech] varchar(10) not null,
	[Time_Tech] varchar(5) not null,
	[SysAdmin_ID] int not null,
	constraint [PK_Tech] primary key clustered
	([ID_Tech] ASC) on [primary],
	constraint [FK_SysAdminT_ID] foreign key ([SysAdmin_ID])
	references [DBO].[Systemni_administrator] ([ID_SysAdmin])
)
