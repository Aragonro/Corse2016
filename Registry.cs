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
        private void button1_Click(object sender, EventArgs e)//регистрация
        {
            depositor dep = new depositor();
            string f_name = this.f_name.Text;
            if (f_name == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            string s_name = this.s_name.Text;
            if (s_name == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            int phone;
            if (!(int.TryParse(this.phone.Text, out phone)) || this.phone.Text.Length!=10)
            {
                MessageBox.Show("Неправильно введён номер телефона!");
                return;
            }
            string party_passport = this.party_passport.Text;
            if (party_passport.Length != 2)
            {
                MessageBox.Show("Неправильно введена партия паспорта");
                return;
            }
            int number_pasport;
            if (this.number_pasport.Text == "" || !(int.TryParse(this.number_pasport.Text, out number_pasport)) || this.number_pasport.Text.Length!=6)
            {
                MessageBox.Show("Неправильно номер паспорта!");
                return;
            }
            int bank_book;
            if (this.bank_book.Text == "" || !(int.TryParse(this.bank_book.Text, out bank_book)))
            {
                MessageBox.Show("Неправильно введён лицевой счёт!");
                return;
            }
            double money;
            if (!(double.TryParse(this.money.Text, out money)) || money < 0)
            {
                MessageBox.Show("Неправильно введена сумма");
                return;
            }
            if (valuta.Text == "")
            {
                MessageBox.Show("Выбирите валюту");
                return;
            }
            double procent;
            if (!(double.TryParse(this.procent.Text, out procent)) || procent <= 0)
            {
                MessageBox.Show("Неправильно введены проценты");
                return;
            }
            if (name_procent.Text == "")
            {
                MessageBox.Show("Выбирите вид процентов");
                return;
            }
            bool error = true;
            string path = @"D:\Data\" + date + ".txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == "DEP")
                    {
                        dep.FirstName = sr.ReadLine();
                        dep.SecondName = sr.ReadLine();
                        dep.Bank_Book = sr.ReadLine();
                        dep.Pasport = sr.ReadLine();
                        dep.Phone = sr.ReadLine();
                        dep.Pasport_Party = sr.ReadLine();
                        dep.Dep_Money = double.Parse(sr.ReadLine());
                        dep.Procent_Money = double.Parse(sr.ReadLine());
                        dep.Procent = double.Parse(sr.ReadLine());
                        dep.Procent_Name = sr.ReadLine();
                        dep.Valuta = sr.ReadLine();
                        dep.ChangeDate = sr.ReadLine();
                        if (this.bank_book.Text == dep.Bank_Book)
                        {
                            error = false;
                            break;
                        }
                    }
                }
            }
            path = @"D:\Data\Change_" + date + ".txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == "Add" && error)
                    {
                        dep.FirstName = sr.ReadLine();
                        dep.SecondName = sr.ReadLine();
                        dep.Bank_Book = sr.ReadLine();
                        dep.Pasport = sr.ReadLine();
                        dep.Phone = sr.ReadLine();
                        dep.Pasport_Party = sr.ReadLine();
                        dep.Dep_Money = double.Parse(sr.ReadLine());
                        dep.Procent = double.Parse(sr.ReadLine());
                        dep.Procent_Name = sr.ReadLine();
                        dep.Valuta = sr.ReadLine();
                        dep.ChangeDate = sr.ReadLine();
                        dep.Procent_Money = 0;
                        if (this.bank_book.Text == dep.Bank_Book)
                        {
                            error = false;
                        }
                    }
                    if(s=="Del" && !error)
                    {
                        s = sr.ReadLine();
                        if (s == this.bank_book.Text)
                        {
                            error = true;
                        }
                    }
                }
            }
            if (!error)
            {
                MessageBox.Show("Такой вкладчик уже существует");
                return;
            }
            Work_File.Add(f_name, s_name, this.bank_book.Text, this.phone.Text, party_passport, this.number_pasport.Text, money, valuta.Text, procent, name_procent.Text,date);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
