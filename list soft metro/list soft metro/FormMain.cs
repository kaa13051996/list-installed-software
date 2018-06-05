using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_soft_metro
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
            string name_current_user = Environment.UserName.ToString();
            label_name_user.Text = name_current_user;            
            roundedPicBox.Image = get_picture_current_user(name_current_user);
            Regedit();
        }
        
        public void Regedit()
        {            
            bool admin = check_admin();
            if (admin == true) label_name_user.Text += " Admin";
            string[] path = list_path(admin);
            RegistryKey[] localKey = list_localkey(admin);            

            string[][] names_key = list_names_key_path(localKey, path);

            //общий список ПО
            Dictionary<string[], RegistryKey> list_softwares = new Dictionary<string[], RegistryKey>();
            for (int i = 0; i < localKey.Count(); i++) list_softwares.Add(list_software(names_key[i], localKey[i], path[i]), localKey[i]);
                        
            Dictionary<string, string> list = list_parameters(list_softwares);            
            if (list.Count == 0) MessageBox.Show("Программ в заданных ветках реестра не обнаружено!", "Пусто!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);            
            cout_db(list);
        }

        static bool check_admin()
        {
            bool admin = false;
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            IdentityReferenceCollection group_current_user = windowsIdentity.Groups;
            string userName = windowsIdentity.Name;
            string sid_admin = "S-1-5-32-544";

            foreach (IdentityReference ir in group_current_user)
            {
                if (ir.Value == sid_admin) admin = true;
            }
            return admin;
        }

        static string[] list_software(String[] names_dir, RegistryKey localKey, string path)
        {            
            string[] list = new string[names_dir.Length];
            int count = 0;
            int no_display_name = 0;

            for (int i = 0; i < names_dir.Length; i++)
            {
                try
                {
                    string value = localKey.OpenSubKey(path + names_dir[i]).GetValue("DisplayName").ToString();
                    if (value == "") throw new System.NullReferenceException();       
                    list[count] = path + names_dir[i];
                    count++;
                }
                catch (System.NullReferenceException)
                {
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

        static Dictionary<string, string> list_parameters(Dictionary<string[], RegistryKey> names_dir)
        {
            //List<string> mass = new List<string>();
            Dictionary<string, string> mass = new Dictionary<string, string>();
            int no_parameters = 0;
            string display_name = null, date_install = null;
            foreach (var key in names_dir.Keys)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    try
                    {
                        display_name = names_dir[key].OpenSubKey(key[i]).GetValue("DisplayName").ToString();
                        //mass.Add(display_name);                        
                        date_install = check_date(names_dir[key], key[i]);
                        //mass.Add(date_install);
                        mass[display_name] = date_install;
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        date_install = "null";
                        //mass.Add(date_install);
                        mass[display_name] = date_install;
                    }
                }
            }
            return mass;
        }

        //проверка наличия даты
        static string check_date(RegistryKey names_dir, string key)
        {
            string date_install = null, install_location = null;

            char[] trim = { ',', '0', '\"' };
            try
            {
                if (names_dir.OpenSubKey(key).GetValue("InstallDate") == null || names_dir.OpenSubKey(key).GetValue("InstallDate").ToString() == "")
                {
                    //проверка InstallLocation
                    if (names_dir.OpenSubKey(key).GetValue("InstallLocation") == null || names_dir.OpenSubKey(key).GetValue("InstallLocation").ToString() == "")
                    {
                        //проверка DislpayIcon
                        if (names_dir.OpenSubKey(key).GetValue("DisplayIcon") == null || names_dir.OpenSubKey(key).GetValue("DisplayIcon").ToString() == "")
                        {
                            //дальнейшие проверки
                            date_install = "null";
                        }
                        else
                        {
                            install_location = names_dir.OpenSubKey(key).GetValue("DisplayIcon").ToString().Trim(trim);
                            date_install = (System.IO.File.GetCreationTime(install_location).ToString()).Substring(0, 10);
                        }
                    }
                    else
                    {
                        install_location = names_dir.OpenSubKey(key).GetValue("InstallLocation").ToString().Trim(trim);
                        date_install = (System.IO.File.GetCreationTime(install_location).ToString()).Substring(0, 10);
                    }
                }
                else
                {
                    date_install = names_dir.OpenSubKey(key).GetValue("InstallDate").ToString();
                    string year = date_install.Substring(0, 4);
                    string month = date_install.Substring(4, 2);
                    string day = date_install.Substring(6, 2);
                    date_install = day + "." + month + "." + year;
                }
            }
            catch (System.NullReferenceException)
            {
                date_install = "null";
                return date_install;
            }

            return date_install;
        }

        //если появился новый путь
        static string[] list_path(bool admin)
        {
            if (admin == true)
            {
                string path_HKLM = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\";
                string path_HKLM_2 = @"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\";
                string path_HKCU = @"Software\Microsoft\Windows\CurrentVersion\Uninstall\";
                string path_HKU = @".DEFAULT\Software\Microsoft\Windows\CurrentVersion\Uninstall\";
                string[] list = { path_HKLM, path_HKLM_2, path_HKCU, path_HKU };
                return list;
            }
            else
            {
                string path_HKCU = @"Software\Microsoft\Windows\CurrentVersion\Uninstall\";
                string[] list = { path_HKCU };
                return list;
            }
        }

        static string[][] list_names_key_path(RegistryKey[] localKey, string[] path)
        {
            int count_localKey = localKey.Count();
            string error = null;
            string[][] list = new string[count_localKey][];
            int current = 0;
            for (int i = 0; i < count_localKey; i++)
            {
                try
                {                    
                    list[i] = localKey[i].OpenSubKey(path[i]).GetSubKeyNames();                    
                }
                catch (Exception ex)
                {
                    error += localKey[i] + path[i] + "\n";                    
                    list[i] = new string[0];
                }
                //current++;
            }
            if (!String.IsNullOrEmpty(error)) MessageBox.Show("Такой ветки(-ок) в вашем реестре не существует:\n" + error, "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //String[] names_key_HKU = localKey[2].OpenSubKey(path[3]).GetSubKeyNames();
            //string[][] list = { names_key_HKLM, names_key_HKLM_2, names_key_HKCU, names_key_HKU };
            //Array.Resize(ref list, current);
            return list;
        }

        //если добавилась ветка реестра
        static RegistryKey[] list_localkey(bool admin)
        {
            if (admin == true)
            {
                RegistryKey[] localKey = new RegistryKey[4];

                if (Environment.Is64BitOperatingSystem)
                {
                    localKey[0] = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                    localKey[1] = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                    localKey[2] = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                    localKey[3] = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64);
                }
                else
                {
                    localKey[0] = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                    localKey[1] = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                    localKey[2] = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
                    localKey[3] = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry32);
                }
                return localKey;
            }
            else
            {
                RegistryKey[] localKey = new RegistryKey[1];

                if (Environment.Is64BitOperatingSystem)
                {
                    localKey[0] = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                }
                else
                {
                    localKey[0] = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
                }
                return localKey;
            }
        }

        void cout_db(Dictionary<string, string> mass)
        {
            dataGridView.RowHeadersVisible = false;   
            DataTable dt = new DataTable();            
            dt.Columns.AddRange(new DataColumn[]{
                new DataColumn("name", typeof(string)),
                new DataColumn("install date", typeof(DateTime))
            });        

            foreach (var pair in mass)
            {
                DataRow row = dt.NewRow();
                if (pair.Value == "null") row.ItemArray = new object[] { pair.Key, Convert.ToDateTime(null) };
                else
                {
                    try
                    {
                        row.ItemArray = new object[] { pair.Key, Convert.ToDateTime(pair.Value) };
                    }
                    catch
                    {
                        row.ItemArray = new object[] { pair.Key, Convert.ToDateTime(null) };
                    }
                }
                dt.Rows.Add(row);
            }
            dataGridView.DataSource = dt;
            dataGridView.ClearSelection();
            dataGridView.EnableHeadersVisualStyles = false;
            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(107, 210, 242);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8); 
        }

        public static Bitmap get_picture_current_user(string name)
        {
            string[] args = new string[1];
            try
            {
                args[0] = Directory.GetFiles(@"C:\Users\" + name + @"\AppData\Roaming\Microsoft\Windows\AccountPictures", "*.accountpicture-ms")[0];
                string filename = Path.GetFileNameWithoutExtension(args[0]);                
            }
            catch
            {
                args[0] = @".\guest.png";
                Bitmap image = new Bitmap( Image.FromFile(@"..\..\..\guest.png"));
                return image;
            }
            Bitmap image96 = GetImage96(args[0]);
            return image96;
        }

        //преобразование FileStream в BitmapImage
        public static Bitmap GetImage96(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            long position = Seek(fs, "JFIF", 0);
            byte[] b = new byte[Convert.ToInt32(fs.Length)];
            fs.Seek(position - 6, SeekOrigin.Begin);
            fs.Read(b, 0, b.Length);
            fs.Close();
            fs.Dispose();
            return GetBitmapImage(b);
        }

        //этот метод позволяет начать чтение байтов из выбранного байта. Метод поиска:
        public static long Seek(System.IO.FileStream fs, string searchString, int startIndex)
        {
            char[] search = searchString.ToCharArray();
            long result = -1, position = 0, stored = startIndex,
            begin = fs.Position;
            int c;
            while ((c = fs.ReadByte()) != -1)
            {
                if ((char)c == search[position])
                {
                    if (stored == -1 && position > 0 && (char)c == search[0])
                    {
                        stored = fs.Position;
                    }
                    if (position + 1 == search.Length)
                    {
                        result = fs.Position - search.Length;
                        fs.Position = result;
                        break;
                    }
                    position++;
                }
                else if (stored > -1)
                {
                    fs.Position = stored + 1;
                    position = 1;
                    stored = -1;
                }
                else
                {
                    position = 0;
                }
            }

            if (result == -1)
            {
                fs.Position = begin;
            }
            return result;
        }

        //Преобразование массива байтов в BitmapImage:
        public static Bitmap GetBitmapImage(byte[] imageBytes)
        {
            //var bitmapImage = new Bitmap();
            //bitmapImage.BeginInit();
            //bitmapImage.StreamSource = new MemoryStream(imageBytes);
            //bitmapImage.EndInit();
            //return bitmapImage;
            var ms = new MemoryStream(imageBytes);
            var bitmapImage = new Bitmap(ms);
            return bitmapImage;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            string info = @"Программа 'ListSoft' предназначена для просмотра списка установленного ПО. 
Разработчик: студент 724 группы, Крупина А.А. 
Год создания:2018. 
Кнопка 'main' вернет Вас в главное меню. Некоторые моменты:
    -если столбец даты пуст, то это значит, что в реестре не нашлось информации, которую можно было бы использовать;
    -если каких - то веток реестра нет, то программа будет исправно работать с тем, что есть;
    -если все необходимые ветки реестра отсутствуют, то это странно, поэтому напишите на почту example @gmail.com.";            
            textBox_info.Visible = true;
            panel_search.Visible = false;
            panel_info.Visible = false;
            textBox_info.Text = info;
        }           

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("Name like '{0}%'", textBox_search.Text);
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            textBox_info.Visible = false;
            panel_search.Visible = true;
            panel_info.Visible = true;
        }
    }
}
