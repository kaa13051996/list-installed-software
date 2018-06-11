using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_soft_metro
{
    public partial class FormInfo : MetroFramework.Forms.MetroForm
    {
        public FormInfo()
        {
            InitializeComponent();
            string name_current_user = Environment.UserName.ToString();
            label_name_user.Text = name_current_user;            
            roundedPicBox.Image = get_picture_current_user(name_current_user);            
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

        //Вызов окна FormInfo из главного меню
        private static FormInfo f;
        public static FormInfo fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormInfo();
                return f;
            }
        }
        //чтобы возвращаться к уже открытой вкладке
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
