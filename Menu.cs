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

namespace WindowsFormsApplication1
{
    partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string now_date = DateTime.Today.ToString("dd.MM.yyyy");
            thisdate.Text = now_date;
            string path = @"D:\Data\date.txt";
            string last_date = "";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    last_date = s;
                }
            }
            while (last_date != now_date)
            {
                last_date = Work_File.Next_Day(last_date);
            }
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(now_date);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registry newform = new Registry(thisdate.Text);
            newform.Show();
        }

        private void Next_day_Click(object sender, EventArgs e)
        {
            thisdate.Text=Work_File.Next_Day(thisdate.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation newform = new Operation(thisdate.Text);
            newform.ShowDialog();
        }
    }
}
