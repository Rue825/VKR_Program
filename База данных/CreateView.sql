CREATE VIEW [DBO].[Obshii_instructaj] ("Проведение инструктажа","Состояние инструктажа","Проходящий инструктаж")
AS
SELECT 'Инженер, который проводит инструктаж: '+[DBO].[Injener].[F_Inj]+' '+[DBO].[Injener].[I_Inj]+' '+[DBO].[Injener].[O_Inj], 
	   'Описание инструктажа - номер: '+[DBO].[Instructaj].[Num_Inst]+', пояснение: '+[DBO].[Instructaj].[Poysn_Inst]+', статус: '+[DBO].[Instructaj].[Status_Inst]+', вид: '+[DBO].[Vid_instructaja].[Name_VInst], 
	   'Инструктаж проходит соискатель: '+[DBO].[Soiskatel].[F_Soisk]+' '+[DBO].[Soiskatel].[I_Soisk]+' '+[DBO].[Soiskatel].[O_Soisk]
FROM [DBO].[Injener]
INNER JOIN [DBO].[Instructaj] ON [DBO].[Injener].[ID_Inj] = [DBO].[Instructaj].[Inj_ID]
INNER JOIN [DBO].[Soiskatel] ON [DBO].[Instructaj].[Soisk_ID] = [DBO].[Soiskatel].[ID_Soisk]
INNER JOIN [DBO].[Vid_instructaja] ON [DBO].[Instructaj].[VInst_ID] = [DBO].[Vid_instructaja].[ID_VInst]
GO

CREATE VIEW [DBO].[Obshya_zayavka] ("Поступление заявки"," Выбранная услуга", "Клиент", "Системный администратор")
AS
SELECT 'Номер и дата поступления заявки: '+[DBO].[Zayavki].[Num_Zayavk]+', '+[DBO].[Zayavki].[Date_Zayavk]+' '+[DBO].[Zayavki].[Time_Zayavk], 
	   'Выбранная услуга: '+[DBO].[Uslugi].[Name_Uslug]+' - '+[DBO].[Uslugi].[Opis_Uslug]+', цена: '+[DBO].[Uslugi].[Cena_Uslug], 
	   'Заявка поступила от клиента: '+[DBO].[Klient].[F_Kl]+' '+[DBO].[Klient].[I_Kl]+' '+[DBO].[Klient].[O_Kl], 
       'Назначенный системный администратор: '+[DBO].[Systemni_administrator].[F_SysAdmin]+' '+[DBO].[Systemni_administrator].[I_SysAdmin]+' '+[DBO].[Systemni_administrator].[O_SysAdmin]
FROM [DBO].[Klient] 
INNER JOIN [DBO].[Zayavki] ON [DBO].[Klient].[ID_Kl] = [DBO].[Zayavki].[Kl_ID] 
INNER JOIN [DBO].[Systemni_administrator] ON [DBO].[Zayavki].[SysAdmin_ID] = [DBO].[Systemni_administrator].[ID_SysAdmin] 
INNER JOIN [DBO].[Uslugi] ON [DBO].[Zayavki].[Uslug_ID] = [DBO].[Uslugi].[ID_Uslug]
GO

CREATE VIEW [DBO].[Oshee_sobesedovanie] ("Собеседование","Принятие документа","Паспорт", "Соискатель", "График работы")
AS
SELECT 'Назначенное собеседование: '+[DBO].[Sobesedovanie].[Date_Sobes]+' '+[DBO].[Sobesedovanie].[Time_Sobes]+', статус собеседования: '+[DBO].[Sobesedovanie].[Status_Sobes]+', участвующий работодатель: '+[DBO].[Rabotodatel_otdela_kadrov].[F_RabotodatelOK]+' '+[DBO].[Rabotodatel_otdela_kadrov].[I_RabotodatelOK]+' '+[DBO].[Rabotodatel_otdela_kadrov].[O_RabotodatelOK], 
	   'Принятие документа - номер: '+[DBO].[Prinyatie_documenta].[Num_PrinDOC]+', вид документа: '+[DBO].[Prinyatie_documenta].[Vid_PrinDOC]+', дата принятия: '+[DBO].[Prinyatie_documenta].[Date_PrinDOC], 
	   'Паспортные данные - номер: '+[DBO].[Pasport].[Num_Pasp]+', серия: '+[DBO].[Pasport].[Seria_Pasp]+', вид: '+[DBO].[Pasport].[Vid_Pasp]+', адрес проживания: '+[DBO].[Pasport].[AdresProjiv_Pasp]+', дата и время получения: '+[DBO].[Pasport].[Date_Pasp]+' '+[DBO].[Pasport].[Time_Pasp], 
	   'Соискатель: '+[DBO].[Soiskatel].[F_Soisk]+' '+[DBO].[Soiskatel].[I_Soisk]+' '+[DBO].[Soiskatel].[O_Soisk],
	   'График работы, в случае если соискатель прошел собеседование - цель: '+ [DBO].[Grafik_Raboti].[Cel_GrafRabot]+', дата работы: '+[DBO].[Grafik_Raboti].[Date_GrafRabot]+', '+[DBO].[Grafik_Raboti].[TimeNach_GrafRabot]+' - '+[DBO].[Grafik_Raboti].[TimeOkonch_GrafRabot]
FROM [DBO].[Grafik_Raboti] 
INNER JOIN [DBO].[Sobesedovanie] ON [DBO].[Grafik_Raboti].[Sobes_ID] = [DBO].[Sobesedovanie].[ID_Sobes] 
INNER JOIN [DBO].[Pasport] ON [DBO].[Sobesedovanie].[Pasp_ID] = [DBO].[Pasport].[ID_Pasp] 
INNER JOIN [DBO].[Prinyatie_documenta] ON [DBO].[Sobesedovanie].[ID_Sobes] = [DBO].[Prinyatie_documenta].[Sobes_ID] 
INNER JOIN [DBO].[Rabotodatel_otdela_kadrov] ON [DBO].[Sobesedovanie].[RabotodatelOK_ID] = [DBO].[Rabotodatel_otdela_kadrov].[ID_RabotodatelOK] 
INNER JOIN [DBO].[Soiskatel] ON [DBO].[Pasport].[Soisk_ID] = [DBO].[Soiskatel].[ID_Soisk]