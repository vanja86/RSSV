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

namespace rssv_lv2_1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        string inputFile = "numbers.txt";
        private int critVal;
        StreamReader reader;

        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer(1000);
            //Dodavanje događaja timer-u; izvršava se periodno
            t.Elapsed += new System.Timers.ElapsedEventHandler(loadFile);
            reader = new StreamReader(inputFile); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                int.TryParse(critValueTB.Text, out critVal); 
                //Pokretanje timer-a.
                t.Start(); //Odgovara: t.Enabled = true;
                startButton.Text = "Stop ucitavanja";
            }
            else
            {
                //Zaustavljanje timer-a
                t.Stop(); //Odgovara: t.Enabled = false;
                startButton.Text = "Start ucitavanja";
            }  
        }

        private void loadFile(object sender, System.Timers.ElapsedEventArgs e)
        {
            string numberString;
            int number;
            
            Invoke((MethodInvoker)delegate //Anonimna metoda
            {
                numberString = reader.ReadLine();
                if (numberString == "")
                    return;
                int.TryParse(numberString, out number);
                if (number > critVal)
                    MessageBox.Show("Broj je veci od kriticne vrijednosti!");
                numbersTB.Text += number + "\r\n";
            }); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reader.Close();
        } 
    }
}
