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
    public partial class Registry : Form
    {
        Menu form = new Menu();
        string date;
        
        public Registry(string date)
        {
            InitializeComponent();
            this.date = date;
        }
        
        private void Registry_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            depositor dep = new depositor();
            int bank_book;
            if(!(int.TryParse(this.bank_book.Text,out bank_book)))
            {
                MessageBox.Show("Не правильно введён лицевой счёт!");
                return;
            }
            int phone;
            if(!(int.TryParse(this.phone.Text,out phone)) || phone<100000000 || phone>999999999)
            {
                MessageBox.Show("Не правильно введён номер телефона!");
                return;
            }
            int number_pasport = int.Parse(this.number_pasport.Text);
            double money = double.Parse(this.money.Text);
            double procent = double.Parse(this.procent.Text);
            Work_File.Add(f_name.Text, s_name.Text, this.bank_book.Text, this.phone.Text, party_passport.Text, this.number_pasport.Text, money, value.Text, procent, name_procent.Text,date);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
