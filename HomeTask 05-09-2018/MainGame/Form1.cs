using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using GameDevelopmentExtension;

namespace MainGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // evvelce Directory.GetCurrentDirectory() ile oldugumuz directory0ni aliriq
            var directory = Directory.GetCurrentDirectory();
            // sonra Path.Combine methodu ile axtardigimiz papkaya olan yolu tapiriq
            string absolutepath = Path.Combine(directory, "Extensions");
            // DirectoryInfo ile hemin papkaya gedirik
            DirectoryInfo directoryinfo = new DirectoryInfo(absolutepath);
            // FileInfo massivi ne axtardigimiz papkanin ichindeki filtrasiya olunmush fayllari atiriq
            FileInfo[] fileInfos = directoryinfo.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
            // foreach ile fileInfos massivinde dovr edirik
            foreach (FileInfo file in fileInfos)
            {
                // Assembly yaradiri     ve Assembly.LoadFile methodu ile hemin zborkani aliri  
                Assembly assembly = Assembly.LoadFile(file.FullName);
                if (assembly != null)
                {
                    // eger assembly null deyilse onun tipini Type classinin komeyi ile aliriq
                    Type[] types = assembly.GetTypes();

                    foreach (Type type in types)
                    {

                        Type interfacetype = type.GetInterface("IGameDevelopment");

                        if (interfacetype != null)
                        {
                            IGameDevelopment instance = Activator.CreateInstance(type) as IGameDevelopment;
                            Button btn = new Button();
                            btn.Text = instance.ButtonName;
                            btn.Click += instance.Click;
                            btn.Location = new Point(70, 260);
                            this.Controls.Add(btn);

                        }
                    }
                }
            }
        }
    }
}
