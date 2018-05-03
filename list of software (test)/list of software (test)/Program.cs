using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace list_of_software__test_
{
    class Reg
    {
        public static void Main()
        {
            string path_HKLM = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\";
            string path_HKCU = @"Software\Microsoft\Windows\CurrentVersion\Uninstall\";
            string path_HKU = @".DEFAULT\Software\Microsoft\Windows\CurrentVersion\Uninstall\";

            RegistryKey[] localKey = new RegistryKey[3];
            
            if (Environment.Is64BitOperatingSystem)
            {
                localKey[0] = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                localKey[1] = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                localKey[2] = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64);
            }                
            else
            {
                localKey[0] = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                localKey[1] = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
                localKey[2] = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry32);
            }

            String[] names_key_HKLM = localKey[0].OpenSubKey(path_HKLM).GetSubKeyNames();
            String[] names_key_HKCU = localKey[1].OpenSubKey(path_HKCU).GetSubKeyNames();
            String[] names_key_HKU = localKey[2].OpenSubKey(path_HKU).GetSubKeyNames();            
            
            //общий список ПО
            List<string> list_softwares = new List<string>();
            
            list_softwares.AddRange(list_software(names_key_HKLM, localKey[0], path_HKLM));
            list_softwares.AddRange(list_software(names_key_HKCU, localKey[1], path_HKCU));
            list_softwares.AddRange(list_software(names_key_HKU, localKey[2], path_HKU));

            //удалить одинаковые имена программ
            list_softwares = list_softwares.Distinct().ToList();

            Console.WriteLine("\n--- All programm ---");

            for (int i = 0; i < list_softwares.Count; i++)
            {
                Console.WriteLine(list_softwares[i]);
            }           
        }

        static void PrintKeys(RegistryKey rkey)
        {
            String[] names = rkey.GetSubKeyNames();

            int icount = 0;

            Console.WriteLine("Subkeys of " + rkey.Name);
            Console.WriteLine("-----------------------------------------------");
            
            foreach (String s in names)
            {
                Console.WriteLine(s);               
                icount++;                
            }
        }

        static string[] list_software(String[] names_dir, RegistryKey localKey, string path)
        {
            //Console.WriteLine("\n--- " + path + " ---");
            string[] list = new string[names_dir.Length];
            int count = 0;
            int no_display_name = 0;

            for (int i = 0; i < names_dir.Length; i++)
            {
                try
                {
                    string value = localKey.OpenSubKey(path + names_dir[i]).GetValue("DisplayName").ToString();
                    //Console.WriteLine(value);
                    list[count] = value;
                    count++;
                }
                catch (System.NullReferenceException)
                {
                    //Console.WriteLine("-" + names_dir[i] + " no name DispalyName!");
                    no_display_name++;
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Array.Resize(ref list, list.Length - no_display_name);
            return list;
        }

        static string[] list_path()
        {
            string[] list = new string[3];

            //рекурсивный поиск в реестре по маске
            //REG QUERY HKEY_USERS / s / k / c / f Uninstall | find "\Windows\CurrentVersion\Uninstall" > REESTR.LIST
            //REG QUERY HKLM / s / k / c / f Uninstall | find "\Windows\CurrentVersion\Uninstall" >> REESTR.LIST
            //REG QUERY HKCU / s / k / c / f Uninstall | find "\Windows\CurrentVersion\Uninstall" >> REESTR.LIST
            //TYPE NUL > LIST.TXT

            return list;
        }
    }
}
