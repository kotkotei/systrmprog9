using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace systeemprog9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var screen in System.Windows.Forms.Screen.AllScreens)
            {
                listBox1.Items.Add("Имя дисплея: " + screen.DeviceName);
                listBox1.Items.Add("Границы области отображения: " +
                    screen.Bounds.ToString());
                listBox1.Items.Add("Тип: " +
                    screen.GetType().ToString());
                listBox1.Items.Add("Рабочая область : " +
                    screen.WorkingArea.ToString());
                listBox1.Items.Add("Главный экран: " +
                    screen.Primary.ToString());
            }
        }
    }
}
