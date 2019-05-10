using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zastavka());
        }
        public static string Login_RegPolz; //Вывод логина
        public static int Dolj_ID; //Объявление переменной для взятие значений из должности
        public static string Znach_Korzina_1; //Значение для хранения 1-ой переменной
        public static string Znach_Korzina_2; //Значение для хранения 2-рой переменной
        public static string Znach_Korzina_3; //Значение для хранения 3-ей переменной
        public static string Znach_Korzina_4; //Значение для хранения 4-ой переменной
        public static string Znach_Korzina_5; //Значение для хранения 5-ой переменной
        public static int Klient_ID; //Объявление переменной для взятие значений из клиента
        public static int Uslug_ID; //Объявление переменной для выбора ComboBox второй формы
        public static string RegPolz_ID; //Объявление переменной для взятие значений из зарегистрированных пользователей
        public static string Auth_Polz; //Объявление переменной для взятие значений после входа пользователя в программу
        public static string NachRab_RegPolz; //Объявление переменной для взятие значений начала временни у пользователей
        public static string OkonchRab_RegPolz; //Объявление переменной для взятие значений окончания времени у пользователей
        public static string TimeNow; //Объявление переменной для выявление времени
        public static int KolVoVipRab_RegPolz; //Объявление переменной для взятие значений выполненных задач
        public static string TimeZayavk; //Объявление переменной для времени заявки
        public static string DateZayavk; //Объявление переменной для даты заявки
        public static string Log_Polz; //Объявление переменной для логина в реестр
        public static string Pass_Polz; //Объявление переменной для пароля в реестр
        public static int Status_ExitSaveStat; //Изменение статуса после выхода пользователя
        public static string StatusRegPolz_Osv = "Свободен"; //Объявление переменной для статуса "Свободен"
        public static string StatusRegPolz_Zanyat = "Занят"; //Объявление переменной для статуса "Занят"
    }
}
