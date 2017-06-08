using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rssv_lv2_2
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;

        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(alarm); 
        }

        private void alarm(object sender, System.Timers.ElapsedEventArgs e)
        {
            int hours;
            int minutes;
            Invoke((MethodInvoker)delegate 
            {
                int.TryParse(hoursTB.Text, out hours);
                int.TryParse(minutesTB.Text, out minutes);
                DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
                timeLbl.Text = DateTime.Now.ToLongTimeString();

                if (alarmTime <= DateTime.Now)
                {
                    MessageBox.Show("ALARM!");
                    Console.Beep(330, 2000);
                    t.Stop(); 
                }
            }); 
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                t.Start(); 
                startBtn.Text = "Zaustavi alarm";
                hoursTB.ReadOnly = true;
                minutesTB.ReadOnly = true;
            }
            else
            {
                t.Stop(); 
                startBtn.Text = "Pokreni alarm";
                hoursTB.ReadOnly = false;
                minutesTB.ReadOnly = false;
            } 
        }
    }
}
