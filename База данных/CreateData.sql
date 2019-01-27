USE [Melans_LLC]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* �������� ������ � ������� ����� */
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('�������������','1','1','1','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('�������','0','1','0','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('����� ������','1','0','0','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('��������� �������������','0','0','1','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('�����','0','0','0','1')

/* �������� ������ � ������� ���������� */
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('�������������')
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('�������')
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('����� ������')
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('��������� �������������')

/* �������� ������ � ������� ���������� */
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('������', '�����', '����������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('��������', '�������', '����������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('��������', '�����', '����������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('��������', '������', '����������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('�����', '���', '�����������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('������������', '����', '�����������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('��������', '������', '��������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('��������', '�����', '���������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('�����', '�����', '��������')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('�����', '����', '���������')

/* �������� ������ � ������� �������� */
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('������', '���������', '���������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('�������', '�������', '�������������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('������', '������', '����������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('��������', '������', '����������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('�������', '�����', '���������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('���������', '����������', '����������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('�������', '����', '���������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('�����', '�����', '�������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('���', '���', '��������')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('�������', '�������', '��������')

/* �������� ������ � ������� ������ */
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('����������� ������������', '������� ����������� �������������� ������������', '1000', '20.10.2018', '10:00')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('����������� ������������', '������� �������� � ���������� �������� PERCo', '1500', '20.10.2018', '15:00')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('��������� ��������������', '��������� CRM �������24', '2000', '21.10.2018', '17:00')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('��������� ��������������', '��������� Office 365', '1700', '21.10.2018', '19:30')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('��������� ��������������', '���������� IP ��������� � CRM', '1400', '21.10.2018', '21:20')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('�������������� � ������ ����� ��� � ���', '�������������� ���', '1300', '22.10.2018', '13:20')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('�������������� � ������ ����� ��� � ���', '������������ ���', '2500', '22.10.2018', '14:50')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('�������������� � ������ ����� ��� � ���', '������ ���', '2200', '22.10.2018', '17:10')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('�� �����', '����� ������������ ����', '2300', '23.10.2018', '14:20')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('�� �����', '����� IT ��������������', '2400', '23.10.2018', '18:45')

/* �������� ������ � ������� ������������ ������ ������ */
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('��������','���������','����������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('������', '����', '����������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('�������', '����', '����������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('������', '��������', '��������������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('������', '������', '���������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('��������', '������������', '���������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('��������', '����������', '��������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('�������������', '����', '���������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('�������', '��������', '�������')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('������', '��������', '���������')

/* �������� ������ � ������� ���������� �������������� */
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('��������', '��������', '��������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('���������', '������', '�����������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('�����������', '������', '���������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('�������', '������', '����������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('�������', '�����', '����������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('������������', '�������', '��������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('������', '����', '������������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('�������', '������', '�����������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('�������', '��������', '����������')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('�����', '������', '������������')

/* �������� ������ � ������� ������� */
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('�������','�������','����������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('�������','�������','��������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('������','�����','����������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('�������','�����','������������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('���������','����','��������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('��������','����','�������������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('�������','�������','������������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('�������','�������','��������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('�������','�������','����������')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('������������','����','���������')

/* �������� ������ � ������� ��� ����������� */
INSERT INTO [DBO].[Vid_instructaja] (Name_VInst) VALUES ('���������')
INSERT INTO [DBO].[Vid_instructaja] (Name_VInst) VALUES ('���������')

/* �������� ������ � ������� ����������� */
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00001','���������� �� ������� ������������','20.10.2018','12:00','0','1','1','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00002','���������� � ������� �����','21.10.2018','13:30','0','2','2','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00003','���������� �� ������� ������������','22.10.2018','15:40','0','3','3','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00004','���������� � ������� �����','23.10.2018','11:00','0','4','4','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00005','���������� �� ������� ������������','24.10.2018','11:20','0','5','5','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00006','���������� � ������� �����','25.10.2018','09:00','0','6','6','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00007','���������� � ������� �����','26.10.2018','08:00','0','7','7','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00008','���������� �� ������� ������������','27.10.2018','12:30','0','8','8','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00009','���������� � ������� �����','28.10.2018','13:00','0','9','9','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00010','���������� �� ������� ������������','29.10.2018','14:00','0','10','10','1')

/* �������� ������ � ������� �������� */
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('40','00154587','��������','��. ���������, �. 7, �.12, �. ������','10.05.1985','08:00', '1')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('41','00158754','�����������','������������ �����, �. 40, �.14, �. ������','20.01.1993','16:00', '2')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('42','00158956','�������������','��. ������������, �. 31, �.20, �. ������','15.04.1995','10:00', '3')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('43','00161808','���������������','��. ���������, �. 40, �.10, �. ������','12.06.1988','14:00', '4')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('44','00165452','���������������','��. ���������, �. 1, �.32, �. ������','13.12.1999','19:00', '5')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('45','00174547','�������������','��������� ��������, �. 8, �.5, �. ������','10.05.2005','14:30', '6')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('46','00178957','�����������','������������ ��������, �. 4, �.6, �. ������','10.05.1985','16:45', '7')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('47','00183254','��������','������������� ��������, �. 20, �.2, �. ������','23.10.1987','12:00', '8')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('48','00187568','�����������','����������� ��������, �. 16, �.4, �. ������','18.12.1994','13:40', '9')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('49','00197856','��������','��. ����� ���������, �. 13, �.16, �. ������','28.07.1985','14:40', '10')

/* �������� ������ � ������� ������������� */
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('20.10.2018','10:00','0','1','1')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('21.10.2018','15:00','0','2','2')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('22.10.2018','08:00','0','3','3')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('23.10.2018','16:00','0','4','4')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('24.10.2018','13:00','0','5','5')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('25.10.2018','12:30','0','6','6')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('26.10.2018','11:00','0','7','7')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('27.10.2018','11:30','0','8','8')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('28.10.2018','14:00','0','9','9')
INSERT INTO [DBO].[Sobesedovanie] (Date_Sobes, Time_Sobes, Status_Sobes, RabotodatelOK_ID, Pasp_ID) VALUES ('29.10.2018','14:30','0','10','10')

/* �������� ������ � ������� ������ ������ */
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('���������� ���','21.10.2018','08:00','16:00','1')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('��������������� IP ���������','22.10.2018','08:00','16:00','2')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('���������� ������������ ���������������','23.10.2018','08:00','16:00','3')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('��������� ������','24.10.2018','08:00','16:00','4')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('��������� ���� ��������� ������������ ������� � ��������','25.10.2018','08:00','16:00','5')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('������������� ��������� � �������','26.10.2018','08:00','16:00','6')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('���������� ���','27.10.2018','08:00','16:00','7')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('������� ������� ������������ ������������','28.10.2018','08:00','16:00','8')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('�������� ������ ������������ �����','29.10.2018','08:00','16:00','9')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('���������� ������������ �����','30.10.2018','08:00','16:00','10')

/* �������� ������ � ������� ����� ������ */
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('MVideo','20.10.2008','20.10.2018','1')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Household','21.10.2006','21.10.2018','2')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Bingo Boom','22.10.2009','22.10.2018','2')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('BAON','23.10.2010','23.10.2017','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Enter �������','24.10.2004','24.10.2018','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Globus','25.10.2005','25.10.2018','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('INCITY','26.10.2012','26.10.2018','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Leroy Merlin','27.10.2013','27.10.2018','4')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('METRO','28.10.2014','28.10.2018','4')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Tommy Hilfiger','29.10.2015','29.10.2018','4')

/* �������� ������ � ������� �������� ��������� */
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('1','�������','20.10.2018','1','1')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('2','�������','21.10.2018','2','2')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('3','�������','22.10.2018','3','3')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('4','�������','23.10.2018','4','4')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('5','�������','24.10.2018','5','5')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('6','�������','25.10.2018','6','6')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('7','�������','26.10.2018','7','7')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('8','�������','27.10.2018','8','8')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('9','�������','28.10.2018','9','9')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('10','�������','29.10.2018','10','10')

/* �������� ������ � ������� ����������� ������������ */
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('������','C�����','��������','v_i.admin@mail.ru','+7(903)564-78-48','administrator','administrator','1','1')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('������','���������','����������','p_e.inj@gmail.com','+7(903)780-99-59','injener','injener','2','2')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('������','����','����������','sh_m.mangzak@yandex.ru','+7(903)480-15-37','systemadmin','systemadmin','3','3')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('��������','�����','����������','b_i.dir@rambler.ru','+7(903)650-49-29','andrey','andrey','4','4')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('��������','������','���������','f_r.mast@mail.ru','+7(903)180-59-33','ilya','ilya','2','2')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('���������','������','���������','d_z.inj@inbox.ru','+7(903)234-27-15','otdelkadrov','otdelkadrov','2','2')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('�����������','����','����������','ya_i.mangzak@bk.ru','+7(903)741-55-47','sergei','sergei','3','3')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('�������','���','�������','s_i.dir@rambler.ru','+7(903)687-02-09','probnik','probnik','4','4')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('���������','������','����������','i_s.mast@mail.ru','+7(903)652-19-49','probnik1','test1','3','3')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('�������','����������','����������','u_n.inj@list.ru','+7(903)945-20-19','test1','probnik1','4','4')

/* �������� ������ � ������� ������ */
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00001','22.10.2018','10:30','1','1','1','1')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00002','23.10.2018','12:30','2','2','2','2')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00003','24.10.2018','10:00','3','3','3','3')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00004','25.10.2018','14:30','4','4','4','4')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00005','26.10.2018','13:00','5','5','5','5')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00006','27.10.2018','11:20','6','6','6','6')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00007','28.10.2018','10:45','7','7','7','7')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00008','29.10.2018','16:45','8','8','8','8')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('00009','30.10.2018','10:55','9','9','9','9')
INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, GrafRabot_ID, Kl_ID, SysAdmin_ID, Uslug_ID) VALUES ('000010','31.10.2018','11:50','10','10','10','10')

/* �������� ������ � ������� ������� */
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('IP-���������','23.10.2018','10:40','1')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('���������������','24.10.2018','12:00','2')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('���','25.10.2018','14:20','3')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('������','26.10.2018','11:55','4')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('�������','27.10.2018','13:30','5')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('������������ ������� � ������','28.10.2018','15:40','6')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('���','29.10.2018','16:00','7')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('������������ ����','30.10.2018','15:00','8')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('����','31.10.2018','14:00','9')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('�������� ������','01.11.2018','10:00','10')