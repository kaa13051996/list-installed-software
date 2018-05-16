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
            Dictionary <string[], RegistryKey> list_softwares = new Dictionary<string[], RegistryKey>();
            
            list_softwares.Add(list_software(names_key_HKLM, localKey[0], path_HKLM), localKey[0]);
            list_softwares.Add(list_software(names_key_HKCU, localKey[1], path_HKCU), localKey[1]);
            list_softwares.Add(list_software(names_key_HKU, localKey[2], path_HKU), localKey[2]);

            //удалить одинаковые имена программ
            //list_softwares = list_softwares.Distinct().ToList();

            List<string> list = list_parameters(list_softwares, path_HKLM);

            Console.WriteLine("\n--- All programm ---");

            foreach (KeyValuePair<string[], RegistryKey> kvp in list_softwares)
            {
                foreach(var i in kvp.Key)
                {
                    Console.WriteLine("Key = {0}, Value = {1}",
                    i, kvp.Value);
                }                
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
                    list[count] = names_dir[i];
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

        static List<string> list_parameters(Dictionary<string[], RegistryKey> names_dir, string path)
        {
            List<string> mass = new List<string>();            
            int no_parameters = 0;
            string display_name = null, install_location = null, date_install = null;
            foreach (var key in names_dir.Keys)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    try
                    {
                        display_name = names_dir[key].OpenSubKey(path + key[i]).GetValue("DisplayName").ToString();
                        mass.Add(display_name);
                        char[] trim = { ',', '0', '\"' };
                        if (names_dir[key].OpenSubKey(path + key[i]).GetValue("InstallLocation") == null)
                        {
                            install_location = names_dir[key].OpenSubKey(path + key[i]).GetValue("DisplayIcon").ToString().Trim(trim);
                            date_install = System.IO.File.GetCreationTime(install_location).ToString();
                        }
                        else
                        {
                            if (names_dir[key].OpenSubKey(path + key[i]).GetValue("InstallLocation").ToString() == "")
                            {
                                install_location = names_dir[key].OpenSubKey(path + key[i]).GetValue("DisplayIcon").ToString().Trim(trim);
                                date_install = System.IO.File.GetCreationTime(install_location).ToString();
                            }
                            else
                            {
                                install_location = names_dir[key].OpenSubKey(path + key[i]).GetValue("InstallLocation").ToString();
                                date_install = System.IO.File.GetCreationTime(install_location).ToString();
                            }
                        }                       
                        mass.Add(date_install);                        
                    }                
                    catch (System.NullReferenceException)
                    {
                        mass.Add("null");
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return mass;
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
