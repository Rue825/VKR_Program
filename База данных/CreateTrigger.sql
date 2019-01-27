CREATE TRIGGER [DBO].[Len_RegPass] ON [DBO].[Registracia_polzovatelya] 
FOR INSERT, UPDATE
AS
BEGIN
	if EXISTS(select[DBO].[Registracia_polzovatelya].[Pass_RegPolz] from [DBO].[Registracia_polzovatelya] 
	WHERE [DBO].[Registracia_polzovatelya].[Pass_RegPolz] in (select[DBO].[Registracia_polzovatelya].[Pass_RegPolz] from inserted)
	group by [DBO].[Registracia_polzovatelya].[Pass_RegPolz] having len([DBO].[Registracia_polzovatelya].[Pass_RegPolz])<5)
		begin
			raiserror('Пароль не должен быть короче чем 5 символов!',16,1)
			rollback tran
		end
end 
GO

CREATE TRIGGER [DBO].[Delete_Role] on [DBO].[Role]
FOR DELETE
AS
DECLARE @ID_Role int
select @ID_Role=deleted.ID_Role
from [DBO].[Role], deleted
if (select count (ID_Role) from [DBO].[Role])<1
	begin
	rollback tran
	raiserror('Нельзя удалить все записи! База не должна быть пустой',16,10)
end
GO

CREATE TRIGGER [DBO].[Len_RegLog] ON [DBO].[Registracia_polzovatelya] 
FOR INSERT, UPDATE
AS
BEGIN
	if EXISTS(select[DBO].[Registracia_polzovatelya].[Log_RegPolz] from [DBO].[Registracia_polzovatelya]
	WHERE [DBO].[Registracia_polzovatelya].[Log_RegPolz] in (select[DBO].[Registracia_polzovatelya].[Log_RegPolz] from inserted)
	group by [DBO].[Registracia_polzovatelya].[Log_RegPolz] having len([DBO].[Registracia_polzovatelya].[Log_RegPolz])<3)
		begin
			raiserror('Логин не должен быть короче чем 3 символа!',16,1)
			rollback tran
		end
end 
GO
