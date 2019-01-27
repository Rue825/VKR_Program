CREATE PROCEDURE [DBO].[Doljnost_DELETE] @ID_Dolj int
AS
	DELETE FROM [DBO].[Doljnost] WHERE ID_Dolj=@ID_Dolj;
GO

CREATE PROCEDURE [DBO].[Grafik_Raboti_DELETE] @ID_GrafRabot int
AS
	DELETE FROM [DBO].[Grafik_Raboti] WHERE ID_GrafRabot=@ID_GrafRabot;
GO

CREATE PROCEDURE [DBO].[Injener_DELETE] @ID_Inj int
AS
	DELETE FROM [DBO].[Injener] WHERE ID_Inj=@ID_Inj;
GO

CREATE PROCEDURE [DBO].[Instructaj_DELETE] @ID_Inst int
AS
	DELETE FROM [DBO].[Instructaj] WHERE ID_Inst=@ID_Inst;
GO

CREATE PROCEDURE [DBO].[Klient_DELETE] @ID_Kl int
AS
	DELETE FROM [DBO].[Klient] WHERE ID_Kl=@ID_Kl;
GO

CREATE PROCEDURE [DBO].[Mesto_Raboti_DELETE] @ID_Mr int
AS
	DELETE FROM [DBO].[Mesto_raboti] WHERE ID_Mr=@ID_Mr;
GO

CREATE PROCEDURE [DBO].[Pasport_DELETE] @ID_Pasp int
AS
	DELETE FROM [DBO].[Pasport] WHERE ID_Pasp=@ID_Pasp;
GO

CREATE PROCEDURE [DBO].[Prinyatie_documenta_DELETE] @ID_PrinDOC int
AS
	DELETE FROM [DBO].[Prinyatie_documenta] WHERE ID_PrinDOC=@ID_PrinDOC;
GO

CREATE PROCEDURE [DBO].[Rabotodatel_otdela_kadrov_DELETE] @ID_RabotodatelOK int
AS
	DELETE FROM [DBO].[Rabotodatel_otdela_kadrov] WHERE ID_RabotodatelOK=@ID_RabotodatelOK;
GO

CREATE PROCEDURE [DBO].[Registracia_polzovatelya_DELETE] @ID_RegPolz int
AS
	DELETE FROM [DBO].[Registracia_polzovatelya] WHERE ID_RegPolz=@ID_RegPolz;
GO

CREATE PROCEDURE [DBO].[Role_DELETE] @ID_Role int
AS
	DELETE FROM [DBO].[Role] WHERE ID_Role=@ID_Role;
GO

CREATE PROCEDURE [DBO].[Sobesedovanie_DELETE] @ID_Sobes int
AS
	DELETE FROM [DBO].[Sobesedovanie] WHERE ID_Sobes=@ID_Sobes;
GO

CREATE PROCEDURE [DBO].[Soiskatel_DELETE] @ID_Soisk int
AS
	DELETE FROM [DBO].[Soiskatel] WHERE ID_Soisk=@ID_Soisk;
GO

CREATE PROCEDURE [DBO].[Systemni_administrator_DELETE] @ID_SysAdmin int
AS
	DELETE FROM [DBO].[Systemni_administrator] WHERE ID_SysAdmin=@ID_SysAdmin;
GO

CREATE PROCEDURE [DBO].[Technika_DELETE] @ID_Tech int
AS
	DELETE FROM [DBO].[Technika] WHERE ID_Tech=@ID_Tech;
GO

CREATE PROCEDURE [DBO].[Uslugi_DELETE] @ID_Uslug int
AS
	DELETE FROM [DBO].[Uslugi] WHERE ID_Uslug=@ID_Uslug;
GO

CREATE PROCEDURE [DBO].[Vid_instructaja_DELETE] @ID_VInst int
AS
	DELETE FROM [DBO].[Vid_instructaja] WHERE ID_VInst=@ID_VInst;
GO

CREATE PROCEDURE [DBO].[Zayavki_DELETE] @ID_Zayavk int
AS
	DELETE FROM [DBO].[Zayavki] WHERE ID_Zayavk=@ID_Zayavk;
GO

CREATE PROCEDURE [DBO].[Doljnost_ADD] @Name_Dolj varchar(80)
AS
	INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES (@Name_Dolj)
GO

CREATE PROCEDURE [DBO].[Grafik_Raboti_ADD] @Cel_GrafRabot varchar(max),
										   @Date_GrafRabot varchar(10),
										   @TimeNach_GrafRabot varchar(5),
										   @TimeOkonch_GrafRabot varchar(5),
										   @Sobes_ID int
AS
	INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) 
	VALUES (@Cel_GrafRabot, @Date_GrafRabot, @TimeNach_GrafRabot, @TimeOkonch_GrafRabot, @Sobes_ID)
GO

CREATE PROCEDURE [DBO].[Injener_ADD] @F_Inj varchar(max),
								     @I_Inj varchar(max),
									 @O_Inj varchar(max)
AS
	INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES (@F_Inj, @I_Inj, @O_Inj)
GO

CREATE PROCEDURE [DBO].[Instructaj_ADD] @Num_Inst varchar(50),
										@Poysn_Inst varchar(max),
										@Date_Inst varchar(10),
										@Time_Inst varchar(5),
										@Status_Inst int,
										@Soisk_ID int,
										@Inj_ID int,
										@VInst_ID int
AS
	INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) 
	VALUES (@Num_Inst, @Poysn_Inst, @Date_Inst, @Time_Inst, @Status_Inst, @Soisk_ID, @Inj_ID, @VInst_ID)
GO

CREATE PROCEDURE [DBO].[Klient_ADD] @F_Kl varchar(max),
									@I_Kl varchar(max),
									@O_Kl varchar(max)
AS
	INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES (@F_Kl, @I_Kl, @O_Kl)
GO

CREATE PROCEDURE [DBO].[Mesto_Raboti_ADD] @NameOrg_Mr varchar(max),
										  @DatePrin_Mr varchar(10),
										  @DateUvol_Mr varchar(10),
										  @Dolj_ID int
AS
	INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES (@NameOrg_Mr, @DatePrin_Mr, @DateUvol_Mr, @Dolj_ID)
GO

CREATE PROCEDURE [DBO].[Pasport_ADD] @Num_Pasp varchar(50),
									 @Seria_Pasp varchar(50),
									 @Vid_Pasp varchar(50),
									 @AdresProjiv_Pasp varchar(max),
									 @Date_Pasp varchar(10),
									 @Time_Pasp varchar(5),
									 @Soisk_ID int
AS
	INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) 
	VALUES (@Num_Pasp, @Seria_Pasp, @Vid_Pasp, @AdresProjiv_Pasp, @Date_Pasp, @Time_Pasp, @Soisk_ID)
GO

CREATE PROCEDURE [DBO].[Prinyatie_documenta_ADD] @Num_PrinDOC varchar(max),
												 @Vid_PrinDOC varchar(50),
												 @Date_PrinDOC varchar(10),
												 @Mr_ID int,
												 @Sobes_ID int
AS
	INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID)  VALUES (@Num_PrinDOC, @Vid_PrinDOC, @Date_PrinDOC, @Mr_ID, @Sobes_ID)
GO

CREATE PROCEDURE [DBO].[Rabotodatel_otdela_kadrov_ADD] @F_RabotodatelOK varchar(max),
													   @I_RabotodatelOK varchar(max),
													   @O_RabotodatelOK varchar(max)
AS
	INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES (@F_RabotodatelOK, @I_RabotodatelOK, @O_RabotodatelOK)
GO

CREATE PROCEDURE [DBO].[Registracia_polzovatelya_ADD] @F_RegPolz varchar(max),
													  @I_RegPolz varchar(max),
													  @O_RegPolz varchar(max),
													  @Email_RegPolz varchar(50),
													  @Tel_RegPolz varchar(max),
													  @Log_RegPolz varchar(50),
													  @Pass_RegPolz varchar(max),
													  @Role_ID int,
													  @Dolj_ID int
AS
	INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID) 
	VALUES (@F_RegPolz, @I_RegPolz, @O_RegPolz, @Email_RegPolz, @Tel_RegPolz, @Log_RegPolz, @Pass_RegPolz, @Role_ID, @Dolj_ID)
GO

CREATE PROCEDURE [DBO].[Role_ADD] @Name_Role varchar(50),
								  @OtdelKadrov_Role int,
								  @Injener_Role int,
								  @SystemAdmin_Role int,
								  @Prosmotr_Role int
AS
	INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) 
	VALUES (@Name_Role, @OtdelKadrov_Role, @Injener_Role, @SystemAdmin_Role, @Prosmotr_Role)
GO

CREATE PROCEDURE [DBO].[Sobesedovanie_ADD] @Date_Sobes varchar(10),
										   @Time_Sobes varchar(5),
										   @Status_Sobes int,
										   @RabotodatelOK_ID int,
										   @Pasp_ID int
AS
	INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES (@Date_Sobes, @Time_Sobes, @Status_Sobes, @RabotodatelOK_ID, @Pasp_ID)
GO

CREATE PROCEDURE [DBO].[Soiskatel_ADD] @F_Soisk varchar(max),
									   @I_Soisk varchar(max),
									   @O_Soisk varchar(max)
AS
	INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES (@F_Soisk, @I_Soisk, @O_Soisk)
GO

CREATE PROCEDURE [DBO].[Systemni_administrator_ADD] @F_SysAdmin varchar(max),
													@I_SysAdmin varchar(max),
													@O_SysAdmin varchar(max)
AS
	INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES (@F_SysAdmin, @I_SysAdmin, @O_SysAdmin)
GO

CREATE PROCEDURE [DBO].[Technika_ADD] @Name_Tech varchar(max),
									  @Date_Tech varchar(10),
									  @Time_Tech varchar(5),
									  @SysAdmin_ID int
AS
	INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES (@Name_Tech, @Date_Tech, @Time_Tech, @SysAdmin_ID)
GO

CREATE PROCEDURE [DBO].[Uslugi_ADD] @Name_Uslug varchar(max),
									@Opis_Uslug varchar(max),
									@Cena_Uslug varchar(max),
									@Date_Uslug varchar(10),
									@Time_Uslug varchar(5)
AS
	INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) 
	VALUES (@Name_Uslug, @Opis_Uslug, @Cena_Uslug, @Date_Uslug, @Time_Uslug)
GO

CREATE PROCEDURE [DBO].[Vid_instructaja_ADD] @Name_VInst varchar(50)
AS
	INSERT INTO [DBO].[Vid_instructaja] (Name_VInst) VALUES (@Name_VInst)
GO

CREATE PROCEDURE [DBO].[Zayavki_ADD] @Num_Zayavk varchar(max),
									 @Date_Zayavk varchar(10),
									 @Time_Zayavk varchar(5),
									 @GrafRabot_ID int,
									 @Kl_ID int,
									 @SysAdmin_ID int,
									 @Uslug_ID int
AS
	INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) 
	VALUES (@Num_Zayavk, @Date_Zayavk, @Time_Zayavk, @GrafRabot_ID, @Kl_ID, @SysAdmin_ID, @Uslug_ID)
GO

CREATE PROCEDURE [DBO].[Doljnost_EDIT] @ID_Dolj int,
									   @Name_Dolj varchar(80)
AS
BEGIN
UPDATE [DBO].[Doljnost] SET Name_Dolj = @Name_Dolj
WHERE ID_Dolj = @ID_Dolj
END
GO

CREATE PROCEDURE [DBO].[Grafik_Raboti_EDIT] @ID_GrafRabot int,
											@Cel_GrafRabot varchar(max), 
											@Date_GrafRabot varchar(10),
											@TimeNach_GrafRabot varchar(5),
											@TimeOkonch_GrafRabot varchar(5),
											@Sobes_ID int
AS
BEGIN
UPDATE [DBO].[Grafik_Raboti] SET Cel_GrafRabot = @Cel_GrafRabot,
								 Date_GrafRabot = @Date_GrafRabot,
								 TimeNach_GrafRabot = @TimeNach_GrafRabot,
								 TimeOkonch_GrafRabot = @TimeOkonch_GrafRabot,
								 Sobes_ID = @Sobes_ID
WHERE ID_GrafRabot = @ID_GrafRabot
END
GO

CREATE PROCEDURE [DBO].[Injener_EDIT] @ID_Inj int,
									  @F_Inj varchar(max), 
									  @I_Inj varchar(max),
									  @O_Inj varchar(max)
AS
BEGIN
UPDATE [DBO].[Injener] SET F_Inj = @F_Inj,
						   I_Inj = @I_Inj,
						   O_Inj = @O_Inj
WHERE ID_Inj = @ID_Inj
END
GO

CREATE PROCEDURE [DBO].[Instructaj_EDIT] @ID_Inst int,
										 @Num_Inst varchar(50), 
										 @Poysn_Inst varchar(max),
										 @Date_Inst varchar(10),
										 @Time_Inst varchar(5),
										 @Status_Inst int,
										 @Soisk_ID int,
										 @Inj_ID int,
										 @VInst_ID int
AS
BEGIN
UPDATE [DBO].[Instructaj] SET Num_Inst = @Num_Inst,
							  Poysn_Inst = @Poysn_Inst,
							  Date_Inst = @Date_Inst,
							  Time_Inst = @Time_Inst,
							  Status_Inst = @Status_Inst,
							  Soisk_ID = @Soisk_ID,
							  Inj_ID = @Inj_ID,
							  VInst_ID = @VInst_ID
WHERE ID_Inst = @ID_Inst
END
GO

CREATE PROCEDURE [DBO].[Klient_EDIT] @ID_Kl int,
									 @F_Kl varchar(max), 
									 @I_Kl varchar(max),
									 @O_Kl varchar(max)
AS
BEGIN
UPDATE [DBO].[Klient] SET F_Kl = @F_Kl,
						  I_Kl = @I_Kl,
						  O_Kl = @O_Kl
WHERE ID_Kl = @ID_Kl
END
GO

CREATE PROCEDURE [DBO].[Mesto_raboti_EDIT] @ID_Mr int,
										   @NameOrg_Mr varchar(max), 
										   @DatePrin_Mr varchar(10),
										   @DateUvol_Mr varchar(10),
										   @Dolj_ID int
AS
BEGIN
UPDATE [DBO].[Mesto_raboti] SET NameOrg_Mr = @NameOrg_Mr,
								DatePrin_Mr = @DatePrin_Mr,
								DateUvol_Mr = @DateUvol_Mr,
								Dolj_ID = @Dolj_ID
WHERE ID_Mr = @ID_Mr
END
GO

CREATE PROCEDURE [DBO].[Pasport_EDIT] @ID_Pasp int,
									  @Num_Pasp varchar(50), 
									  @Seria_Pasp varchar(50),
									  @Vid_Pasp varchar(50),
									  @AdresProjiv_Pasp varchar(max),
									  @Date_Pasp varchar(10),
									  @Time_Pasp varchar(5),
									  @Soisk_ID int
AS
BEGIN
UPDATE [DBO].[Pasport] SET Num_Pasp = @Num_Pasp,
						   Seria_Pasp = @Seria_Pasp,
						   Vid_Pasp = @Vid_Pasp,
						   AdresProjiv_Pasp = @AdresProjiv_Pasp,
						   Date_Pasp = @Date_Pasp,
						   Time_Pasp = @Time_Pasp,
						   Soisk_ID = @Soisk_ID
WHERE ID_Pasp = @ID_Pasp
END
GO

CREATE PROCEDURE [DBO].[Prinyatie_documenta_EDIT] @ID_PrinDOC int,
												  @Num_PrinDOC varchar(max), 
												  @Vid_PrinDOC varchar(50),
												  @Date_PrinDOC varchar(10),
												  @Mr_ID int,
												  @Sobes_ID int
AS
BEGIN
UPDATE [DBO].[Prinyatie_documenta] SET Num_PrinDOC = @Num_PrinDOC,
									   Vid_PrinDOC = @Vid_PrinDOC,
									   Date_PrinDOC = @Date_PrinDOC,
									   Mr_ID = @Mr_ID,
									   Sobes_ID = @Sobes_ID
WHERE ID_PrinDOC = @ID_PrinDOC
END
GO

CREATE PROCEDURE [DBO].[Rabotodatel_otdela_kadrov_EDIT] @ID_RabotodatelOK int,
														@F_RabotodatelOK varchar(max), 
														@I_RabotodatelOK varchar(max),
														@O_RabotodatelOK varchar(max)
AS
BEGIN
UPDATE [DBO].[Rabotodatel_otdela_kadrov] SET F_RabotodatelOK = @F_RabotodatelOK,
											 I_RabotodatelOK = @I_RabotodatelOK,
											 O_RabotodatelOK = @O_RabotodatelOK
WHERE ID_RabotodatelOK = @ID_RabotodatelOK
END
GO

CREATE PROCEDURE [DBO].[Registracia_polzovatelya_EDIT] @ID_RegPolz int,
													   @F_RegPolz varchar(max), 
													   @I_RegPolz varchar(max),
													   @O_RegPolz varchar(max),
													   @Email_RegPolz varchar(50),
													   @Tel_RegPolz varchar(max),
													   @Log_RegPolz varchar(50),
													   @Pass_RegPolz varchar(max),
													   @Role_ID int,
													   @Dolj_ID int
AS
BEGIN
UPDATE [DBO].[Registracia_polzovatelya] SET F_RegPolz = @F_RegPolz,
											I_RegPolz = @I_RegPolz,
											O_RegPolz = @O_RegPolz,
											Email_RegPolz = @Email_RegPolz,
											Tel_RegPolz = @Tel_RegPolz,
											Log_RegPolz = @Log_RegPolz,
											Pass_RegPolz = @Pass_RegPolz,
											Role_ID = @Role_ID,
											Dolj_ID = @Dolj_ID
WHERE ID_RegPolz = @ID_RegPolz
END
GO

CREATE PROCEDURE [DBO].[Role_EDIT] @ID_Role int,
								   @Name_Role varchar(50), 
								   @OtdelKadrov_Role int,
								   @Injener_Role int,
								   @SystemAdmin_Role int,
								   @Prosmotr_Role int
AS
BEGIN
UPDATE [DBO].[Role] SET Name_Role = @Name_Role,
					    OtdelKadrov_Role = @OtdelKadrov_Role,
					    Injener_Role = @Injener_Role,
						SystemAdmin_Role = @SystemAdmin_Role,
						Prosmotr_Role = @Prosmotr_Role
WHERE ID_Role = @ID_Role
END
GO

CREATE PROCEDURE [DBO].[Sobesedovanie_EDIT] @ID_Sobes int,
											@Date_Sobes varchar(10), 
											@Time_Sobes varchar(5),
											@Status_Sobes int,
											@RabotodatelOK_ID int,
											@Pasp_ID int
AS
BEGIN
UPDATE [DBO].[Sobesedovanie] SET Date_Sobes = @Date_Sobes,
								 Time_Sobes = @Time_Sobes,
								 Status_Sobes = @Status_Sobes,
								 RabotodatelOK_ID = @RabotodatelOK_ID,
								 Pasp_ID = @Pasp_ID
WHERE ID_Sobes = @ID_Sobes
END
GO

CREATE PROCEDURE [DBO].[Soiskatel_EDIT] @ID_Soisk int,
										@F_Soisk varchar(max), 
										@I_Soisk varchar(max),
										@O_Soisk varchar(max)
AS
BEGIN
UPDATE [DBO].[Soiskatel] SET F_Soisk = @F_Soisk,
							 I_Soisk = @I_Soisk,
							 O_Soisk = @O_Soisk
WHERE ID_Soisk = @ID_Soisk
END
GO

CREATE PROCEDURE [DBO].[Systemni_administrator_EDIT] @ID_SysAdmin int,
													 @F_SysAdmin varchar(max), 
													 @I_SysAdmin varchar(max),
													 @O_SysAdmin varchar(max)
AS
BEGIN
UPDATE [DBO].[Systemni_administrator] SET F_SysAdmin = @F_SysAdmin,
										  I_SysAdmin = @I_SysAdmin,
										  O_SysAdmin = @O_SysAdmin
WHERE ID_SysAdmin = @ID_SysAdmin
END
GO

CREATE PROCEDURE [DBO].[Technika_EDIT] @ID_Tech int,
									   @Name_Tech varchar(max), 
									   @Date_Tech varchar(10),
									   @Time_Tech varchar(5),
									   @SysAdmin_ID int
AS
BEGIN
UPDATE [DBO].[Technika] SET Name_Tech = @Name_Tech,
							Date_Tech = @Date_Tech,
							Time_Tech = @Time_Tech,
							SysAdmin_ID = @SysAdmin_ID
WHERE ID_Tech = @ID_Tech
END
GO

CREATE PROCEDURE [DBO].[Uslugi_EDIT]  @ID_Uslug int,
									  @Name_Uslug varchar(max), 
									  @Opis_Uslug varchar(max),
									  @Cena_Uslug varchar(max),
									  @Date_Uslug varchar(10),
									  @Time_Uslug varchar(5)
AS
BEGIN
UPDATE [DBO].[Uslugi] SET Name_Uslug = @Name_Uslug,
						  Opis_Uslug = @Opis_Uslug,
						  Cena_Uslug = @Cena_Uslug,
						  Date_Uslug = @Date_Uslug,
						  Time_Uslug = @Time_Uslug
WHERE ID_Uslug = @ID_Uslug
END
GO

CREATE PROCEDURE [DBO].[Vid_instructaja_EDIT] @ID_VInst int,
											  @Name_Vinst varchar(50)
AS
BEGIN
UPDATE [DBO].[Vid_instructaja] SET Name_VInst = @Name_VInst
WHERE ID_VInst = @ID_VInst
END
GO

CREATE PROCEDURE [DBO].[Zayavki_EDIT] @ID_Zayavk int,
									  @Num_Zayavk varchar(max),
									  @Date_Zayavk varchar(10),
									  @Time_Zayavk varchar(5),
									  @GrafRabot_ID int,
									  @Kl_ID int,
									  @SysAdmin_ID int,
									  @Uslug_ID int
AS
BEGIN
UPDATE [DBO].[Zayavki] SET Num_Zayavk = @Num_Zayavk,
						   Date_Zayavk = @Date_Zayavk,
						   Time_Zayavk = @Time_Zayavk,
						   GrafRabot_ID = @GrafRabot_ID,
						   Kl_ID = @Kl_ID,
						   SysAdmin_ID = @SysAdmin_ID,
						   Uslug_ID = @Uslug_ID
WHERE ID_Zayavk = @ID_Zayavk
END
GO

CREATE PROCEDURE [DBO].[Access_RegPolz_EDIT_PASS] @Log_RegPolz varchar(50), 
												  @Pass_RegPolz varchar(max)
AS
BEGIN
UPDATE [DBO].[Registracia_polzovatelya] SET Pass_RegPolz = @Pass_RegPolz 
WHERE Log_RegPolz = @Log_RegPolz
END
GO
