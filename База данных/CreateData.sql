USE [Melans_LLC]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Внесение данных в таблицу ролей */
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('Администратор','1','1','1','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('Инженер','0','1','0','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('Отдел кадров','1','0','0','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('Системный администратор','0','0','1','1')
INSERT INTO [DBO].[Role] (Name_Role, OtdelKadrov_Role, Injener_Role, SystemAdmin_Role, Prosmotr_Role) VALUES
('Гость','0','0','0','1')

/* Внесение данных в таблицу должностей */
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('Администратор')
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('Инженер')
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('Отдел кадров')
INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('Системный администратор')

/* Внесение данных в таблицу соискателя */
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Травин', 'Игорь', 'Онисимович')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Дмитриев', 'Арсений', 'Родионович')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Устинова', 'Римма', 'Радионовна')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Якубович', 'Лариса', 'Николаевна')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Яснов', 'Мир', 'Геннадиевич')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Беломестнова', 'Ника', 'Афанасиевна')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Снегирёва', 'Галина', 'Егоровна')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Лисицына', 'Влада', 'Сергеевна')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Лунин', 'Вадим', 'Маркович')
INSERT INTO [DBO].[Soiskatel] (F_Soisk, I_Soisk, O_Soisk) VALUES ('Лунин', 'Юрий', 'Федорович')

/* Внесение данных в таблицу инженера */
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Вишнев', 'Александр', 'Сергеевич')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Захаров', 'Василий', 'Александрович')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Блинов', 'Андрей', 'Васильевич')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Якубович', 'Леонид', 'Аркадьевич')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Вишнева', 'Дарья', 'Сергеевна')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Солдатова', 'Александра', 'Дмитриевна')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Блинова', 'Юлия', 'Андреевна')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Силин', 'Игорь', 'Титович')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Цой', 'Лео', 'Петрович')
INSERT INTO [DBO].[Injener] (F_Inj, I_Inj, O_Inj) VALUES ('Мусихин', 'Евгений', 'Олегович')

/* Внесение данных в таблицу услуги */
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Обеспечение безопасности', 'Система обеспечения информационной безопасности', '1000', '20.10.2018', '10:00')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Обеспечение безопасности', 'Системы контроля и управления доступом PERCo', '1500', '20.10.2018', '15:00')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Повышение продуктивности', 'Внедрение CRM Битрикс24', '2000', '21.10.2018', '17:00')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Повышение продуктивности', 'Внедрение Office 365', '1700', '21.10.2018', '19:30')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Повышение продуктивности', 'Интеграция IP телефонии и CRM', '1400', '21.10.2018', '21:20')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Проектирование и монтаж сетей СКС и ЛВС', 'Проектирование ЛВС', '1300', '22.10.2018', '13:20')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Проектирование и монтаж сетей СКС и ЛВС', 'Обслуживание ЛВС', '2500', '22.10.2018', '14:50')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('Проектирование и монтаж сетей СКС и ЛВС', 'Монтаж ЛВС', '2200', '22.10.2018', '17:10')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('ИТ аудит', 'Аудит компьютерной сети', '2300', '23.10.2018', '14:20')
INSERT INTO [DBO].[Uslugi] (Name_Uslug, Opis_Uslug, Cena_Uslug, Date_Uslug, Time_Uslug) VALUES 
('ИТ аудит', 'Аудит IT инфраструктуры', '2400', '23.10.2018', '18:45')

/* Внесение данных в таблицу работодателя отдела кадров */
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Воронцов','Святослав','Онисимович')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Бобров', 'Карл', 'Леонидович')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Устинов', 'Илья', 'Максимович')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Зайцев', 'Вячеслав', 'Константинович')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Бобров', 'Михаил', 'Артемович')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Андреева', 'Александрина', 'Дамировна')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Полякова', 'Александра', 'Авдеевна')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Красильникова', 'Алла', 'Мироновна')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Семёнова', 'Вероника', 'Юрьевна')
INSERT INTO [DBO].[Rabotodatel_otdela_kadrov] (F_RabotodatelOK, I_RabotodatelOK, O_RabotodatelOK) VALUES ('Ильина', 'Кристина', 'Вадимовна')

/* Внесение данных в таблицу системного администратора */
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Дьячкова', 'Василиса', 'Евсеевна')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Молчанова', 'Марина', 'Альбертовна')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Лаврентьева', 'Аврора', 'Семеновна')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Мышкина', 'Полина', 'Витальевна')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Орехова', 'Дания', 'Васильевна')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Константинов', 'Никифор', 'Петрович')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Павлов', 'Марк', 'Вячеславович')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Абрамов', 'Андрей', 'Парфеньевич')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Денисов', 'Мстислав', 'Эдуардович')
INSERT INTO [DBO].[Systemni_administrator] (F_SysAdmin, I_SysAdmin, O_SysAdmin) VALUES ('Фомин', 'Богдан', 'Митрофанович')

/* Внесение данных в таблицу клиента */
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Федоров','Дмитрий','Максимович')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Лазарев','Василий','Игоревич')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Блинов','Игорь','Эдуардович')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Крылаев','Давид','Всеволодович')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Черникова','Дина','Олеговна')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Матизова','Алла','Ростиславовна')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Малинин','Аскольд','Мирославович')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Мамонов','Николай','Ипатович')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Рубанов','Никанор','Родионович')
INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('Александрова','Кира','Федоровна')

/* Внесение данных в таблицу вид инструктажа */
INSERT INTO [DBO].[Vid_instructaja] (Name_VInst) VALUES ('Первичный')
INSERT INTO [DBO].[Vid_instructaja] (Name_VInst) VALUES ('Вторичный')

/* Внесение данных в таблицу инструктажа */
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00001','Инструктаж по технике безопасности','20.10.2018','12:00','0','1','1','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00002','Инструктаж о рабочем месте','21.10.2018','13:30','0','2','2','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00003','Инструктаж по технике безопасности','22.10.2018','15:40','0','3','3','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00004','Инструктаж о рабочем месте','23.10.2018','11:00','0','4','4','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00005','Инструктаж по технике безопасности','24.10.2018','11:20','0','5','5','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00006','Инструктаж о рабочем месте','25.10.2018','09:00','0','6','6','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00007','Инструктаж о рабочем месте','26.10.2018','08:00','0','7','7','2')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00008','Инструктаж по технике безопасности','27.10.2018','12:30','0','8','8','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00009','Инструктаж о рабочем месте','28.10.2018','13:00','0','9','9','1')
INSERT INTO [DBO].[Instructaj] (Num_Inst, Poysn_Inst, Date_Inst, Time_Inst, Status_Inst, Soisk_ID, Inj_ID, VInst_ID) VALUES 
('00010','Инструктаж по технике безопасности','29.10.2018','14:00','0','10','10','1')

/* Внесение данных в таблицу паспорта */
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('40','00154587','Семейный','ул. Кравченко, д. 7, к.12, г. Москва','10.05.1985','08:00', '1')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('41','00158754','Официальный','Давыдковская улица, д. 40, к.14, г. Москва','20.01.1993','16:00', '2')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('42','00158956','Туристический','ул. Лобачевского, д. 31, к.20, г. Москва','15.04.1995','10:00', '3')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('43','00161808','Дипломатический','ул. Коштоянца, д. 40, к.10, г. Москва','12.06.1988','14:00', '4')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('44','00165452','Дипломатический','ул. Панфёрово, д. 1, к.32, г. Москва','13.12.1999','19:00', '5')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('45','00174547','Туристический','Ленинский проспект, д. 8, к.5, г. Москва','10.05.2005','14:30', '6')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('46','00178957','Официальный','Толмачёвский переулок, д. 4, к.6, г. Москва','10.05.1985','16:45', '7')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('47','00183254','Семейный','Волгоградский проспект, д. 20, к.2, г. Москва','23.10.1987','12:00', '8')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('48','00187568','Официальный','Нахимовский проспект, д. 16, к.4, г. Москва','18.12.1994','13:40', '9')
INSERT INTO [DBO].[Pasport] (Num_Pasp, Seria_Pasp, Vid_Pasp, AdresProjiv_Pasp, Date_Pasp, Time_Pasp, Soisk_ID) VALUES 
('49','00197856','Семейный','ул. Марии Ульяновой, д. 13, к.16, г. Москва','28.07.1985','14:40', '10')

/* Внесение данных в таблицу собеседование */
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

/* Внесение данных в таблицу график работы */
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Обеспечить ЛВС','21.10.2018','08:00','16:00','1')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Отремониторвать IP телефонию','22.10.2018','08:00','16:00','2')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Обеспечить обслуживание видеонаблюдения','23.10.2018','08:00','16:00','3')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Настроить сервер','24.10.2018','08:00','16:00','4')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Обслужить офис поставкой компьютерной техники и серверов','25.10.2018','08:00','16:00','5')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Ремонтировать компьютер и принтер','26.10.2018','08:00','16:00','6')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Обеспечить АТС','27.10.2018','08:00','16:00','7')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Обучить клиента компьютерной безопасности','28.10.2018','08:00','16:00','8')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Провести монтаж компьютерных сетей','29.10.2018','08:00','16:00','9')
INSERT INTO [DBO].[Grafik_Raboti] (Cel_GrafRabot, Date_GrafRabot, TimeNach_GrafRabot, TimeOkonch_GrafRabot, Sobes_ID) VALUES 
('Обеспечить обслуживание сетей','30.10.2018','08:00','16:00','10')

/* Внесение данных в таблицу место работы */
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('MVideo','20.10.2008','20.10.2018','1')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Household','21.10.2006','21.10.2018','2')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Bingo Boom','22.10.2009','22.10.2018','2')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('BAON','23.10.2010','23.10.2017','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Enter Связной','24.10.2004','24.10.2018','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Globus','25.10.2005','25.10.2018','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('INCITY','26.10.2012','26.10.2018','3')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Leroy Merlin','27.10.2013','27.10.2018','4')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('METRO','28.10.2014','28.10.2018','4')
INSERT INTO [DBO].[Mesto_raboti] (NameOrg_Mr, DatePrin_Mr, DateUvol_Mr, Dolj_ID) VALUES ('Tommy Hilfiger','29.10.2015','29.10.2018','4')

/* Внесение данных в таблицу принятия документа */
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('1','Паспорт','20.10.2018','1','1')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('2','Паспорт','21.10.2018','2','2')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('3','Паспорт','22.10.2018','3','3')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('4','Паспорт','23.10.2018','4','4')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('5','Паспорт','24.10.2018','5','5')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('6','Паспорт','25.10.2018','6','6')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('7','Паспорт','26.10.2018','7','7')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('8','Паспорт','27.10.2018','8','8')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('9','Паспорт','28.10.2018','9','9')
INSERT INTO [DBO].[Prinyatie_documenta] (Num_PrinDOC, Vid_PrinDOC, Date_PrinDOC, Mr_ID, Sobes_ID) VALUES ('10','Паспорт','29.10.2018','10','10')

/* Внесение данных в таблицу регистрации пользователя */
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Власов','Cергей','Игоревич','v_i.admin@mail.ru','+7(903)564-78-48','administrator','administrator','1','1')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Петров','Александр','Эдуардович','p_e.inj@gmail.com','+7(903)780-99-59','injener','injener','2','2')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Щедрин','Олег','Максимович','sh_m.mangzak@yandex.ru','+7(903)480-15-37','systemadmin','systemadmin','3','3')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Быстрова','Алиса','Ираклиевна','b_i.dir@rambler.ru','+7(903)650-49-29','andrey','andrey','4','4')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Фомичева','Марина','Романовна','f_r.mast@mail.ru','+7(903)180-59-33','ilya','ilya','2','2')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Дубровина','Любава','Захаровна','d_z.inj@inbox.ru','+7(903)234-27-15','otdelkadrov','otdelkadrov','2','2')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Ядренникова','Майя','Ираклиевна','ya_i.mangzak@bk.ru','+7(903)741-55-47','sergei','sergei','3','3')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Симакин','Ким','Ильевич','s_i.dir@rambler.ru','+7(903)687-02-09','probnik','probnik','4','4')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Ивашечкин','Андрей','Самуилович','i_s.mast@mail.ru','+7(903)652-19-49','probnik1','test1','3','3')
INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID)
VALUES ('Уголева','Владислава','Несторовна','u_n.inj@list.ru','+7(903)945-20-19','test1','probnik1','4','4')

/* Внесение данных в таблицу заявки */
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

/* Внесение данных в таблицу техники */
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('IP-телефония','23.10.2018','10:40','1')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Видеонаблюдения','24.10.2018','12:00','2')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('ЛВС','25.10.2018','14:20','3')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Сервер','26.10.2018','11:55','4')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Принтер','27.10.2018','13:30','5')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Компьютерная техника и сервер','28.10.2018','15:40','6')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('АТС','29.10.2018','16:00','7')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Компьютерная сеть','30.10.2018','15:00','8')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Сайт','31.10.2018','14:00','9')
INSERT INTO [DBO].[Technika] (Name_Tech, Date_Tech, Time_Tech, SysAdmin_ID) VALUES ('Облачный сервер','01.11.2018','10:00','10')