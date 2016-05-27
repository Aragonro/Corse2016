using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
