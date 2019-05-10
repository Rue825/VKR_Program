using Microsoft.Win32;
using RS_Shift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melans_LLC
{
    class Reg_Info
    {
        public RS_Shift_Class _RS = new RS_Shift_Class();
        public static string log;
        public static string pass;
        public void Reg_Shifr(string LogValue, string PassValue)
        {
            RegistryKey currentConfigKey = Registry.CurrentConfig; //Создание экземпляра класса Registry 
            RegistryKey RS_Shift_Melans_LLC = currentConfigKey.CreateSubKey("RS_Shift_Melans_LLC"); //Создание раздела в реестре в HKEY_CURRENT_KEY 
            RS_Shift_Melans_LLC.SetValue("log_shifr", LogValue);
            RS_Shift_Melans_LLC.SetValue("pass_shifr", PassValue);
        }
        public void Reg_Get()
        {
            try
            {
                RegistryKey currentConfigKey = Registry.CurrentConfig; //Создание экземпляра класса Registry 
                RegistryKey RS_Shift_Melans_LLC = currentConfigKey.CreateSubKey("RS_Shift_Melans_LLC"); //Создание раздела в реестре в HKEY_CURRENT_KEY 
                log = _RS.Decrypt(RS_Shift_Melans_LLC.GetValue("log").ToString());
                pass = _RS.Decrypt(RS_Shift_Melans_LLC.GetValue("pass").ToString());
            }
            catch
            {
                RegistryKey currentConfigKey = Registry.CurrentConfig; //Создание экземпляра класса Registry 
                RegistryKey RS_Shift_Melans_LLC = currentConfigKey.CreateSubKey("RS_Shift_Melans_LLC"); //Создание раздела в реестре в HKEY_CURRENT_KEY 
                RS_Shift_Melans_LLC.SetValue("log", "Empty");
                RS_Shift_Melans_LLC.SetValue("pass", "Empty");
            }
        }
        public void Reg_Set(string LogValue, string PassValue)
        {
            RegistryKey currentConfigKey = Registry.CurrentConfig; //Создание экземпляра класса Registry 
            RegistryKey RS_Shift_Melans_LLC = currentConfigKey.CreateSubKey("RS_Shift_Melans_LLC"); //Создание раздела в реестре в HKEY_CURRENT_KEY 
            RS_Shift_Melans_LLC.SetValue("log", _RS.Encrypt(LogValue));
            RS_Shift_Melans_LLC.SetValue("pass", _RS.Encrypt(PassValue));
            Reg_Get();
        }

        public void Reg_Del(string name, string source) //удаление записи в реестре
        {
            RegistryKey currentConfigKey = Registry.CurrentConfig;//Создание экземпляра класса Registry 
            RegistryKey RS_Shift_Melans_LLC = currentConfigKey.OpenSubKey("RS_Shift_Melans_LLC", true); //Открытие раздела
            RS_Shift_Melans_LLC.DeleteValue("log"); // удаляем значение из ключа
            RS_Shift_Melans_LLC.DeleteValue("pass");// удаляем значение из ключа
            RS_Shift_Melans_LLC.Close(); //Закрытие раздела 
        }
    }
}
