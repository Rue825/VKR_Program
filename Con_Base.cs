﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    class Con_Base
    {
        public SqlConnection Connection() //Подключение к БД
        {
            string connectionstring = "Data Source=HELLCAT\\HELL_CAT;Initial Catalog=Melans_LLC;User ID=sa;Password=Pa$$w0rd825";
            SqlConnection cs = new SqlConnection(connectionstring);
            cs.Open();
            return (cs);
        }
        public int SearchRegPolz(string login, string pass) //Поиск логина и пароля в БД
        {
            Connection();
            SqlCommand command1 = new SqlCommand("SELECT COUNT (*) FROM [DBO].[Registracia_polzovatelya] where Log_RegPolz LIKE '" + login + "'" + " AND Pass_RegPolz LIKE '" + pass + "'", Connection());
            command1.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("Select ID_RegPolz from [DBO].[Registracia_polzovatelya] where Log_RegPolz LIKE '" + login + "'", Connection());
            Program.Auth_Polz = command2.ExecuteScalar().ToString();
            SqlCommand command3 = new SqlCommand("Select NachRab_RegPolz from [DBO].[Registracia_polzovatelya] where Log_RegPolz LIKE '" + login + "'", Connection());
            Program.NachRab_RegPolz = command3.ExecuteScalar().ToString();
            SqlCommand command4 = new SqlCommand("Select OkonchRab_RegPolz from [DBO].[Registracia_polzovatelya] where Log_RegPolz LIKE '" + login + "'", Connection());
            Program.OkonchRab_RegPolz = command4.ExecuteScalar().ToString();
            SqlCommand command5 = new SqlCommand("Select FORMAT(GETDATE(), 'HH:mm')", Connection());
            Program.TimeNow = command5.ExecuteScalar().ToString();
            int result = Convert.ToInt32(command1.ExecuteScalar());
            return result;
        }
        public int CreateDanniePolz(string f, string i, string o, string email, string telephone, string Log_RegPolz, string Pass_RegPolz, int role, int dolj, string Status_RegPolz, string NachRab_RegPolz, string OkonchRab_RegPolz, string KolVoVipRab_RegPolz, int Tech_ID) //Создание данных пользователя
        {
            Connection();
            SqlCommand command = new SqlCommand("INSERT INTO [DBO].[Registracia_polzovatelya] (F_RegPolz, I_RegPolz, O_RegPolz, Email_RegPolz, Tel_RegPolz, Log_RegPolz, Pass_RegPolz, Role_ID, Dolj_ID, Status_RegPolz, NachRab_RegPolz, OkonchRab_RegPolz, KolVoVipRab_RegPolz, Tech_ID) VALUES ('" + f + "','" + i + "','" + o + "','" + email + "','" + telephone + "','" + Log_RegPolz + "','" + Pass_RegPolz + "','" + role + "','" + dolj + "','" + Status_RegPolz + "','" + NachRab_RegPolz + "','" + OkonchRab_RegPolz + "','" + KolVoVipRab_RegPolz + "','" + Tech_ID+ "')", Connection());
            int result = Convert.ToInt32(command.ExecuteScalar());
            return result;
        }
        public int CreateZayavk(string Num_Zayavk, string Date_Zayavk, string Time_Zayavk, int Kl_ID, int Uslug_ID, int RegPolz_ID) //Формирование заявки от клиента
        {
            Connection();
            SqlCommand command = new SqlCommand("INSERT INTO [DBO].[Zayavki] (Num_Zayavk, Date_Zayavk, Time_Zayavk, Kl_ID, Uslug_ID,RegPolz_ID) VALUES ('" + Num_Zayavk + "','" + Date_Zayavk + "','" + Time_Zayavk + "','" + Kl_ID + "','" + Uslug_ID + "','" + RegPolz_ID + "')", Connection());
            int result = Convert.ToInt32(command.ExecuteScalar());
            return result;
        }
        public int CreateKlient(string F_Kl, string I_Kl, string O_Kl) //Создание данных о клиенте
        {
            Connection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [DBO].[Klient] (F_Kl, I_Kl, O_Kl) VALUES ('" + F_Kl + "','" + I_Kl+"','" + O_Kl + "')", Connection());
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT MAX (ID_Kl) FROM [DBO].[Klient]", Connection());
            Program.Klient_ID = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            int result = Convert.ToInt32(cmd2.ExecuteScalar());
            return result;
        }
        public int CreateDolj(string Dolj) //Создание добавление должности
        {
            Connection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [DBO].[Doljnost] (Name_Dolj) VALUES ('" + Dolj + "')", Connection());
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT MAX (ID_Dolj) FROM [DBO].[Doljnost]", Connection());
            Program.Dolj_ID = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            int result = Convert.ToInt32(cmd2.ExecuteScalar());
            return result;
        }
        public void EditPassAutoriz(string Log_RegPolz, string Pass_RegPolz) //Изменение пароля
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Access_RegPolz_EDIT_PASS", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Log_RegPolz", Log_RegPolz);
            StrProc.Parameters.AddWithValue("@Pass_RegPolz", Pass_RegPolz);
            StrProc.ExecuteNonQuery();
        }
        public int Log(string login) //Поиск логина в БД
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM [DBO].[Registracia_polzovatelya] where Log_RegPolz LIKE '" + login + "'", Connection());
            int result = Convert.ToInt32(command.ExecuteScalar());
            return result;
        }
        public int Email(string email) //Поиск электронной почты
        {
            Connection();
            SqlCommand command1 = new SqlCommand("SELECT COUNT (*) FROM [DBO].[Registracia_polzovatelya] WHERE Email_RegPolz LIKE '" + email + "'", Connection());
            int result = Convert.ToInt32(command1.ExecuteScalar());
            SqlCommand command2 = new SqlCommand("SELECT Log_RegPolz FROM [DBO].[Registracia_polzovatelya] WHERE Email_RegPolz= '" + email + "'", Connection());
            command2.ExecuteNonQuery();
            Program.Login_RegPolz = command2.ExecuteScalar().ToString();
            return result;
        }
        public void InsertDolj(string Name_Dolj) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Doljnost_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Dolj", Name_Dolj);
            StrProc.ExecuteNonQuery();
        }
        public void EditDolj(int ID_Dolj, string Name_Dolj) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Doljnost_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Dolj", ID_Dolj);
            StrProc.Parameters.AddWithValue("@Name_Dolj", Name_Dolj);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteDolj(int ID_Dolj) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Doljnost_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Dolj", ID_Dolj);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateDolj(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Doljnost]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertGrafRabot(string Cel_GrafRabot, string Date_GrafRabot, string TimeNach_GrafRabot, string TimeOkonch_GrafRabot, int Sobes_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Grafik_Raboti_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Cel_GrafRabot", Cel_GrafRabot);
            StrProc.Parameters.AddWithValue("@Date_GrafRabot", Date_GrafRabot);
            StrProc.Parameters.AddWithValue("@TimeNach_GrafRabot", TimeNach_GrafRabot);
            StrProc.Parameters.AddWithValue("@TimeOkonch_GrafRabot", TimeOkonch_GrafRabot);
            StrProc.Parameters.AddWithValue("@Sobes_ID", Sobes_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditGrafRabot(int ID_GrafRabot, string Cel_GrafRabot, string Date_GrafRabot, string TimeNach_GrafRabot, string TimeOkonch_GrafRabot, int Sobes_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Grafik_Raboti_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_GrafRabot", ID_GrafRabot);
            StrProc.Parameters.AddWithValue("@Cel_GrafRabot", Cel_GrafRabot);
            StrProc.Parameters.AddWithValue("@Date_GrafRabot", Date_GrafRabot);
            StrProc.Parameters.AddWithValue("@TimeNach_GrafRabot", TimeNach_GrafRabot);
            StrProc.Parameters.AddWithValue("@TimeOkonch_GrafRabot", TimeOkonch_GrafRabot);
            StrProc.Parameters.AddWithValue("@Sobes_ID", Sobes_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteGrafRabot(int ID_GrafRabot) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Grafik_Raboti_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_GrafRabot", ID_GrafRabot);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateGrafRabot(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Grafik_Raboti]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertInst(string Num_Inst, string Poysn_Inst, string Date_Inst, string Time_Inst, int Status_Inst, int Soisk_ID,  int VInst_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Instructaj_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Num_Inst", Num_Inst);
            StrProc.Parameters.AddWithValue("@Poysn_Inst", Poysn_Inst);
            StrProc.Parameters.AddWithValue("@Date_Inst", Date_Inst);
            StrProc.Parameters.AddWithValue("@Time_Inst", Time_Inst);
            StrProc.Parameters.AddWithValue("@Status_Inst", Status_Inst);
            StrProc.Parameters.AddWithValue("@Soisk_ID", Soisk_ID);
            StrProc.Parameters.AddWithValue("@VInst_ID", VInst_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditInst(int ID_Inst, string Num_Inst, string Poysn_Inst, string Date_Inst, string Time_Inst, int Status_Inst, int Soisk_ID, int VInst_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Instructaj_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Inst", ID_Inst);
            StrProc.Parameters.AddWithValue("@Num_Inst", Num_Inst);
            StrProc.Parameters.AddWithValue("@Poysn_Inst", Poysn_Inst);
            StrProc.Parameters.AddWithValue("@Date_Inst", Date_Inst);
            StrProc.Parameters.AddWithValue("@Time_Inst", Time_Inst);
            StrProc.Parameters.AddWithValue("@Status_Inst", Status_Inst);
            StrProc.Parameters.AddWithValue("@Soisk_ID", Soisk_ID);
            StrProc.Parameters.AddWithValue("@VInst_ID", VInst_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteInst(int ID_Inst) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Instructaj_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Inst", ID_Inst);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateInst(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Instructaj]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertKl(string F_Kl, string I_Kl, string O_Kl) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Klient_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@F_Kl", F_Kl);
            StrProc.Parameters.AddWithValue("@I_Kl", I_Kl);
            StrProc.Parameters.AddWithValue("@O_Kl", O_Kl);
            StrProc.ExecuteNonQuery();
        }
        public void EditKl(int ID_Kl, string F_Kl, string I_Kl, string O_Kl) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Klient_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Kl", ID_Kl);
            StrProc.Parameters.AddWithValue("@F_Kl", F_Kl);
            StrProc.Parameters.AddWithValue("@I_Kl", I_Kl);
            StrProc.Parameters.AddWithValue("@O_Kl", O_Kl);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteKl(int ID_Kl) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Klient_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Kl", ID_Kl);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateKl(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Klient]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertMr(string NameOrg_Mr, string DatePrin_Mr, string DateUvol_Mr, int Dolj_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Mesto_raboti_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@NameOrg_Mr", NameOrg_Mr);
            StrProc.Parameters.AddWithValue("@DatePrin_Mr", DatePrin_Mr);
            StrProc.Parameters.AddWithValue("@DateUvol_Mr", DateUvol_Mr);
            StrProc.Parameters.AddWithValue("@Dolj_ID", Dolj_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditMr(int ID_Mr, string NameOrg_Mr, string DatePrin_Mr, string DateUvol_Mr, int Dolj_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Mesto_raboti_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Mr", ID_Mr);
            StrProc.Parameters.AddWithValue("@NameOrg_Mr", NameOrg_Mr);
            StrProc.Parameters.AddWithValue("@DatePrin_Mr", DatePrin_Mr);
            StrProc.Parameters.AddWithValue("@DateUvol_Mr", DateUvol_Mr);
            StrProc.Parameters.AddWithValue("@Dolj_ID", Dolj_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteMr(int ID_Mr) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Mesto_Raboti_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Mr", ID_Mr);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateMr(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Mesto_raboti]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertPasp(string Num_Pasp, string Seria_Pasp, string Vid_Pasp, string AdresProjiv_Pasp, string Date_Pasp, string Time_Pasp, int Soisk_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Pasport_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Num_Pasp", Num_Pasp);
            StrProc.Parameters.AddWithValue("@Seria_Pasp", Seria_Pasp);
            StrProc.Parameters.AddWithValue("@Vid_Pasp", Vid_Pasp);
            StrProc.Parameters.AddWithValue("@AdresProjiv_Pasp", AdresProjiv_Pasp);
            StrProc.Parameters.AddWithValue("@Date_Pasp", Date_Pasp);
            StrProc.Parameters.AddWithValue("@Time_Pasp", Time_Pasp);
            StrProc.Parameters.AddWithValue("@Soisk_ID", Soisk_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditPasp(int ID_Pasp, string Num_Pasp, string Seria_Pasp, string Vid_Pasp, string AdresProjiv_Pasp, string Date_Pasp, string Time_Pasp, int Soisk_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Pasport_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Pasp", ID_Pasp);
            StrProc.Parameters.AddWithValue("@Num_Pasp", Num_Pasp);
            StrProc.Parameters.AddWithValue("@Seria_Pasp", Seria_Pasp);
            StrProc.Parameters.AddWithValue("@Vid_Pasp", Vid_Pasp);
            StrProc.Parameters.AddWithValue("@AdresProjiv_Pasp", AdresProjiv_Pasp);
            StrProc.Parameters.AddWithValue("@Date_Pasp", Date_Pasp);
            StrProc.Parameters.AddWithValue("@Time_Pasp", Time_Pasp);
            StrProc.Parameters.AddWithValue("@Soisk_ID", Soisk_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeletePasp(int ID_Pasp) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Pasport_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Pasp", ID_Pasp);
            StrProc.ExecuteNonQuery();
        }
        public void UpdatePasp(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Pasport]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertPrinDOC(string Num_PrinDOC, string Vid_PrinDOC, string Date_PrinDOC, int Mr_ID, int Sobes_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Prinyatie_documenta_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Num_PrinDOC", Num_PrinDOC);
            StrProc.Parameters.AddWithValue("@Vid_PrinDOC", Vid_PrinDOC);
            StrProc.Parameters.AddWithValue("@Date_PrinDOC", Date_PrinDOC);
            StrProc.Parameters.AddWithValue("@Mr_ID", Mr_ID);
            StrProc.Parameters.AddWithValue("@Sobes_ID", Sobes_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditPrinDOC(int ID_PrinDOC, string Num_PrinDOC, string Vid_PrinDOC, string Date_PrinDOC, int Mr_ID, int Sobes_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Prinyatie_documenta_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_PrinDOC", ID_PrinDOC);
            StrProc.Parameters.AddWithValue("@Num_PrinDOC", Num_PrinDOC);
            StrProc.Parameters.AddWithValue("@Vid_PrinDOC", Vid_PrinDOC);
            StrProc.Parameters.AddWithValue("@Date_PrinDOC", Date_PrinDOC);
            StrProc.Parameters.AddWithValue("@Mr_ID", Mr_ID);
            StrProc.Parameters.AddWithValue("@Sobes_ID", Sobes_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeletePrinDOC(int ID_PrinDOC) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Prinyatie_documenta_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_PrinDOC", ID_PrinDOC);
            StrProc.ExecuteNonQuery();
        }
        public void UpdatePrinDOC(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Prinyatie_documenta]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertRabotodatelOK(string F_RabotodatelOK, string I_RabotodatelOK, string O_RabotodatelOK) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Rabotodatel_otdela_kadrov_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@F_RabotodatelOK", F_RabotodatelOK);
            StrProc.Parameters.AddWithValue("@I_RabotodatelOK", I_RabotodatelOK);
            StrProc.Parameters.AddWithValue("@O_RabotodatelOK", O_RabotodatelOK);
            StrProc.ExecuteNonQuery();
        }
        public void EditRabotodatelOK(int ID_RabotodatelOK, string F_RabotodatelOK, string I_RabotodatelOK, string O_RabotodatelOK) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Rabotodatel_otdela_kadrov_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_RabotodatelOK", ID_RabotodatelOK);
            StrProc.Parameters.AddWithValue("@F_RabotodatelOK", F_RabotodatelOK);
            StrProc.Parameters.AddWithValue("@I_RabotodatelOK", I_RabotodatelOK);
            StrProc.Parameters.AddWithValue("@O_RabotodatelOK", O_RabotodatelOK);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteRabotodatelOK(int ID_RabotodatelOK) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Rabotodatel_otdela_kadrov_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_RabotodatelOK", ID_RabotodatelOK);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateRabotodatelOK(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Rabotodatel_otdela_kadrov]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertRegPolz(string F_RegPolz, string I_RegPolz, string O_RegPolz, string Email_RegPolz, string Tel_RegPolz, string Log_RegPolz, string Pass_RegPolz, int Role_ID, int Dolj_ID, string Status_RegPolz, string NachRab_RegPolz, string OkonchRab_RegPolz, string KolVoVipRab_RegPolz, int Tech_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Registracia_polzovatelya_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@F_RegPolz", F_RegPolz);
            StrProc.Parameters.AddWithValue("@I_RegPolz", I_RegPolz);
            StrProc.Parameters.AddWithValue("@O_RegPolz", O_RegPolz);
            StrProc.Parameters.AddWithValue("@Email_RegPolz", Email_RegPolz);
            StrProc.Parameters.AddWithValue("@Tel_RegPolz", Tel_RegPolz);
            StrProc.Parameters.AddWithValue("@Log_RegPolz", Log_RegPolz);
            StrProc.Parameters.AddWithValue("@Pass_RegPolz", Pass_RegPolz);
            StrProc.Parameters.AddWithValue("@Role_ID", Role_ID);
            StrProc.Parameters.AddWithValue("@Dolj_ID", Dolj_ID);
            StrProc.Parameters.AddWithValue("@Status_RegPolz", Status_RegPolz);
            StrProc.Parameters.AddWithValue("@NachRab_RegPolz", NachRab_RegPolz);
            StrProc.Parameters.AddWithValue("@OkonchRab_RegPolz", OkonchRab_RegPolz);
            StrProc.Parameters.AddWithValue("@KolVoVipRab_RegPolz", KolVoVipRab_RegPolz);
            StrProc.Parameters.AddWithValue("@Tech_ID", Tech_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditRegPolz(int ID_RegPolz, string F_RegPolz, string I_RegPolz, string O_RegPolz, string Email_RegPolz, string Tel_RegPolz, string Log_RegPolz, string Pass_RegPolz, int Role_ID, int Dolj_ID, string NachRab_RegPolz, string OkonchRab_RegPolz, int Tech_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Registracia_polzovatelya_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_RegPolz", ID_RegPolz);
            StrProc.Parameters.AddWithValue("@F_RegPolz", F_RegPolz);
            StrProc.Parameters.AddWithValue("@I_RegPolz", I_RegPolz);
            StrProc.Parameters.AddWithValue("@O_RegPolz", O_RegPolz);
            StrProc.Parameters.AddWithValue("@Email_RegPolz", Email_RegPolz);
            StrProc.Parameters.AddWithValue("@Tel_RegPolz", Tel_RegPolz);
            StrProc.Parameters.AddWithValue("@Log_RegPolz", Log_RegPolz);
            StrProc.Parameters.AddWithValue("@Pass_RegPolz", Pass_RegPolz);
            StrProc.Parameters.AddWithValue("@Role_ID", Role_ID);
            StrProc.Parameters.AddWithValue("@Dolj_ID", Dolj_ID);
            StrProc.Parameters.AddWithValue("@NachRab_RegPolz", NachRab_RegPolz);
            StrProc.Parameters.AddWithValue("@OkonchRab_RegPolz", OkonchRab_RegPolz);
            StrProc.Parameters.AddWithValue("@Tech_ID", Tech_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteRegPolz(int ID_RegPolz) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Registracia_polzovatelya_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_RegPolz", ID_RegPolz);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateRegPolz(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Registracia_polzovatelya]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertRole(string Name_Role, int OtdelKadrov_Role, int Injener_Role, int SystemAdmin_Role, int Prosmotr_Role) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Role_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Role", Name_Role);
            StrProc.Parameters.AddWithValue("@OtdelKadrov_Role", OtdelKadrov_Role);
            StrProc.Parameters.AddWithValue("@Injener_Role", Injener_Role);
            StrProc.Parameters.AddWithValue("@SystemAdmin_Role", SystemAdmin_Role);
            StrProc.Parameters.AddWithValue("@Prosmotr_Role", Prosmotr_Role);
            StrProc.ExecuteNonQuery();
        }
        public void InsertSobes(string Date_Sobes, string Time_Sobes, int Status_Sobes, int RabotodatelOK_ID, int Pasp_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Sobesedovanie_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Date_Sobes", Date_Sobes);
            StrProc.Parameters.AddWithValue("@Time_Sobes", Time_Sobes);
            StrProc.Parameters.AddWithValue("@Status_Sobes", Status_Sobes);
            StrProc.Parameters.AddWithValue("@RabotodatelOK_ID", RabotodatelOK_ID);
            StrProc.Parameters.AddWithValue("@Pasp_ID", Pasp_ID);
            StrProc.ExecuteNonQuery();
        }
        public void EditSobes(int ID_Sobes, string Date_Sobes, string Time_Sobes, int Status_Sobes, int RabotodatelOK_ID, int Pasp_ID) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Sobesedovanie_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Sobes", ID_Sobes);
            StrProc.Parameters.AddWithValue("@Date_Sobes", Date_Sobes);
            StrProc.Parameters.AddWithValue("@Time_Sobes", Time_Sobes);
            StrProc.Parameters.AddWithValue("@Status_Sobes", Status_Sobes);
            StrProc.Parameters.AddWithValue("@RabotodatelOK_ID", RabotodatelOK_ID);
            StrProc.Parameters.AddWithValue("@Pasp_ID", Pasp_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteSobes(int ID_Sobes) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Sobesedovanie_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Sobes", ID_Sobes);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateSobes(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Sobesedovanie]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertSoisk(string F_Soisk, string I_Soisk, string O_Soisk) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Soiskatel_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@F_Soisk", F_Soisk);
            StrProc.Parameters.AddWithValue("@I_Soisk", I_Soisk);
            StrProc.Parameters.AddWithValue("@O_Soisk", O_Soisk);
            StrProc.ExecuteNonQuery();
        }
        public void EditSoisk(int ID_Soisk, string F_Soisk, string I_Soisk, string O_Soisk) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Soiskatel_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Soisk", ID_Soisk);
            StrProc.Parameters.AddWithValue("@F_Soisk", F_Soisk);
            StrProc.Parameters.AddWithValue("@I_Soisk", I_Soisk);
            StrProc.Parameters.AddWithValue("@O_Soisk", O_Soisk);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteSoisk(int ID_Soisk) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Soiskatel_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Soisk", ID_Soisk);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateSoisk(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Soiskatel]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }

        public void InsertTech(string Name_Tech, string Date_Tech, string Time_Tech) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Technika_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Tech", Name_Tech);
            StrProc.Parameters.AddWithValue("@Date_Tech", Date_Tech);
            StrProc.Parameters.AddWithValue("@Time_Tech", Time_Tech);
            StrProc.ExecuteNonQuery();
        }
        public void EditTech(int ID_Tech, string Name_Tech, string Date_Tech, string Time_Tech) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Technika_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Tech", ID_Tech);
            StrProc.Parameters.AddWithValue("@Name_Tech", Name_Tech);
            StrProc.Parameters.AddWithValue("@Date_Tech", Date_Tech);
            StrProc.Parameters.AddWithValue("@Time_Tech", Time_Tech);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteTech(int ID_Tech) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Technika_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Tech", ID_Tech);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateTech(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Technika]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertUslug(string Name_Uslug, string Opis_Uslug, string Cena_Uslug, string Date_Uslug, string Time_Uslug) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Uslugi_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Uslug", Name_Uslug);
            StrProc.Parameters.AddWithValue("@Opis_Uslug", Opis_Uslug);
            StrProc.Parameters.AddWithValue("@Cena_Uslug", Cena_Uslug);
            StrProc.Parameters.AddWithValue("@Date_Uslug", Date_Uslug);
            StrProc.Parameters.AddWithValue("@Time_Uslug", Time_Uslug);
            StrProc.ExecuteNonQuery();
        }
        public void EditUslug(int ID_Uslug, string Name_Uslug, string Opis_Uslug, string Cena_Uslug, string Date_Uslug, string Time_Uslug) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Uslugi_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Uslug", ID_Uslug);
            StrProc.Parameters.AddWithValue("@Name_Uslug", Name_Uslug);
            StrProc.Parameters.AddWithValue("@Opis_Uslug", Opis_Uslug);
            StrProc.Parameters.AddWithValue("@Cena_Uslug", Cena_Uslug);
            StrProc.Parameters.AddWithValue("@Date_Uslug", Date_Uslug);
            StrProc.Parameters.AddWithValue("@Time_Uslug", Time_Uslug);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteUslug(int ID_Uslug) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Uslugi_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Uslug", ID_Uslug);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateUslug(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Uslugi]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertVInst(string Name_VInst) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Vid_instructaja_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_VInst", Name_VInst);
            StrProc.ExecuteNonQuery();
        }
        public void EditVInst(int ID_VInst, string Name_VInst) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Vid_instructaja_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_VInst", ID_VInst);
            StrProc.Parameters.AddWithValue("@Name_VInst", Name_VInst);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteVInst(int ID_VInst) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Vid_instructaja_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_VInst", ID_VInst);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateVInst(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Vid_instructaja]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertZayavk(string Num_Zayavk, string Date_Zayavk, string Time_Zayavk, int Kl_ID, int Uslug_ID, int RegPolz_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Zayavki_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Num_Zayavk", Num_Zayavk);
            StrProc.Parameters.AddWithValue("@Date_Zayavk", Date_Zayavk);
            StrProc.Parameters.AddWithValue("@Time_Zayavk", Time_Zayavk);
            StrProc.Parameters.AddWithValue("@Kl_ID", Kl_ID);
            StrProc.Parameters.AddWithValue("@Uslug_ID", Uslug_ID);
            StrProc.Parameters.AddWithValue("@RegPolz_ID", RegPolz_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteZayavk(int ID_Zayavk) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Zayavki_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Zayavk", ID_Zayavk);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateZayavk(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Zayavki]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void InsertZadachiZHour(string Name_Zadach, string DatePostup_Zadach, string TimePostup_Zadach, string TimeNaVip_Zadach, string Status_Zadach, int Zayavk_ID, string ZavershenieHour_Zadach, int RegPolz_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("ZadachiZHour_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Zadach", Name_Zadach);
            StrProc.Parameters.AddWithValue("@DatePostup_Zadach", DatePostup_Zadach);
            StrProc.Parameters.AddWithValue("@TimePostup_Zadach", TimePostup_Zadach);
            StrProc.Parameters.AddWithValue("@TimeNaVip_Zadach", TimeNaVip_Zadach);
            StrProc.Parameters.AddWithValue("@Status_Zadach", Status_Zadach);
            StrProc.Parameters.AddWithValue("@Zayavk_ID", Zayavk_ID);
            StrProc.Parameters.AddWithValue("@ZavershenieHour_Zadach", ZavershenieHour_Zadach);
            StrProc.Parameters.AddWithValue("@RegPolz_ID", RegPolz_ID);
            StrProc.ExecuteNonQuery();
        }
        public void InsertZadachiZMinutes(string Name_Zadach, string DatePostup_Zadach, string TimePostup_Zadach, string TimeNaVip_Zadach, string Status_Zadach, int Zayavk_ID, string ZavershenieMinutes_Zadach, int RegPolz_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("ZadachiZMinutes_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Zadach", Name_Zadach);
            StrProc.Parameters.AddWithValue("@DatePostup_Zadach", DatePostup_Zadach);
            StrProc.Parameters.AddWithValue("@TimePostup_Zadach", TimePostup_Zadach);
            StrProc.Parameters.AddWithValue("@TimeNaVip_Zadach", TimeNaVip_Zadach);
            StrProc.Parameters.AddWithValue("@Status_Zadach", Status_Zadach);
            StrProc.Parameters.AddWithValue("@Zayavk_ID", Zayavk_ID);
            StrProc.Parameters.AddWithValue("@ZavershenieMinutes_Zadach", ZavershenieMinutes_Zadach);
            StrProc.Parameters.AddWithValue("@RegPolz_ID", RegPolz_ID);
            StrProc.ExecuteNonQuery();
        }
        public void InsertZadachiZHourAndMinutes(string Name_Zadach, string DatePostup_Zadach, string TimePostup_Zadach, string TimeNaVip_Zadach, string Status_Zadach, int Zayavk_ID, string ZavershenieHour_Zadach, string ZavershenieMinutes_Zadach, int RegPolz_ID) //Добавление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("ZadachiZHourAndMinutes_ADD", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@Name_Zadach", Name_Zadach);
            StrProc.Parameters.AddWithValue("@DatePostup_Zadach", DatePostup_Zadach);
            StrProc.Parameters.AddWithValue("@TimePostup_Zadach", TimePostup_Zadach);
            StrProc.Parameters.AddWithValue("@TimeNaVip_Zadach", TimeNaVip_Zadach);
            StrProc.Parameters.AddWithValue("@Status_Zadach", Status_Zadach);
            StrProc.Parameters.AddWithValue("@Zayavk_ID", Zayavk_ID);
            StrProc.Parameters.AddWithValue("@ZavershenieHour_Zadach", ZavershenieHour_Zadach);
            StrProc.Parameters.AddWithValue("@ZavershenieMinutes_Zadach", ZavershenieMinutes_Zadach);
            StrProc.Parameters.AddWithValue("@RegPolz_ID", RegPolz_ID);
            StrProc.ExecuteNonQuery();
        }
        public void DeleteZadachi(int ID_Zadach) //Удаление данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("Zadachi_DELETE", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Zadach", ID_Zadach);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateZadachi(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("select * from [dbo].[Zadachi]", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void EditVipZadach(int ID_Zadach, string Status_Zadach) //Изменение данных задачи
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("ZadachiVip_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_Zadach", ID_Zadach);
            StrProc.Parameters.AddWithValue("@Status_Zadach", Status_Zadach);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateRegSysAdmin(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT ID_RegPolz, F_RegPolz, I_RegPolz, O_RegPolz, Status_RegPolz, NachRab_RegPolz, OkonchRab_RegPolz FROM Registracia_polzovatelya WHERE(Role_ID LIKE '4')", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void SearchKolvoVipRabRegPolz() //Поиск количества выполненных заданий по номеру
        {
            Connection();
            SqlCommand command1 = new SqlCommand("SELECT KolVoVipRab_RegPolz FROM [DBO].[Registracia_polzovatelya] where ID_RegPolz LIKE '" + Program.Auth_Polz + "'", Connection());
            Program.KolVoVipRab_RegPolz = Convert.ToInt32(command1.ExecuteScalar().ToString());
        }
        public void EditVipZadachKolvoRegPolz(int ID_RegPolz, int KolVoVipRab_RegPolz) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("ZadachiVipKolVoVipRegPolzRab_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_RegPolz", ID_RegPolz);
            StrProc.Parameters.AddWithValue("@KolVoVipRab_RegPolz", KolVoVipRab_RegPolz);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateFiltrZadachInj(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT ID_Zadach, Name_Zadach, DatePostup_Zadach, TimePostup_Zadach, TimeNaVip_Zadach, Status_Zadach, Zayavk_ID, Zavershenie_Zadach, RegPolz_ID FROM Zadachi WHERE(RegPolz_ID LIKE '"+Program.Auth_Polz+"')", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void EditStatPolz(int ID_RegPolz, string Status_RegPolz) //Изменение данных
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("StatusRegPolz_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("@ID_RegPolz", ID_RegPolz);
            StrProc.Parameters.AddWithValue("Status_RegPolz", Status_RegPolz);
            StrProc.ExecuteNonQuery();
        }
        public void UpdateFiltrRegPolzInj(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT * FROM [DBO].[Registracia_polzovatelya] where role_id like '2'", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void SortirovkaZA(DataGridView valueTable) //Сортировка от Я-А
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT * FROM [DBO].[Registracia_polzovatelya] where role_id like '2' order by KolVoVipRab_RegPolz Desc", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void SortirovkaAZ(DataGridView valueTable) //Сортировка от А-Я
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT * FROM [DBO].[Registracia_polzovatelya] where role_id like '2' order by KolVoVipRab_RegPolz Asc", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void UpdateRegInj(DataGridView valueTable) //Процедура обновления данных в таблицы
        {
            Connection();
            SqlCommand command = new SqlCommand("SELECT ID_RegPolz, F_RegPolz, I_RegPolz, O_RegPolz, Status_RegPolz, NachRab_RegPolz, OkonchRab_RegPolz FROM Registracia_polzovatelya WHERE(Role_ID LIKE '2')", Connection());
            SqlDataReader tableReader = command.ExecuteReader();
            DataTable dataValue = new DataTable();
            dataValue = new DataTable();
            dataValue.Load(tableReader);
            valueTable.DataSource = dataValue;
        }
        public void CheckStatus(int ID_RegPolz, string Status_RegPolz) //Изменение статуса пользователя в зависимости от выбранных задач
        {
            Connection();
            SqlCommand StrProc = new SqlCommand("CheckStatus_EDIT", Connection());
            StrProc.CommandType = CommandType.StoredProcedure;
            StrProc.Parameters.AddWithValue("ID_RegPolz", ID_RegPolz);
            StrProc.Parameters.AddWithValue("Status_RegPolz", Status_RegPolz);
            StrProc.ExecuteNonQuery();
        }
        public int StatusCheckPolz() //Проверка количество статусов "Занят"
        {
            Connection();
            SqlCommand command1 = new SqlCommand("Select COUNT (*) Status_Zadach from Registracia_polzovatelya inner join Zadachi on [DBO].[Registracia_polzovatelya].[ID_RegPolz]=[DBO].[Zadachi].[RegPolz_ID] where ID_RegPolz = '" + Program.Auth_Polz + "' and Status_Zadach = 'В процессе'", Connection());
            command1.ExecuteNonQuery();
            Program.Status_ExitSaveStat = Convert.ToInt32(command1.ExecuteScalar());
            int result = Convert.ToInt32(command1.ExecuteScalar());
            return result;
        }
    }
}