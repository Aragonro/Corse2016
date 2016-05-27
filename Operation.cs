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
    partial class Operation : Form
    {
        string date;
        bool error;
        depositor search_dep = new depositor();
        public Operation()
        {
            InitializeComponent();
        }
        public Operation(string date)
        {
            InitializeComponent();
            this.date = date;

        }
        private void Operation_Load(object sender, EventArgs e)
        {

        }

        private void chose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)//поиск вкладчика
        {
            if (chose_filter.Text == "")
            {
                MessageBox.Show("Выбирите фильтр");
                return;
            }
            if (chose_filter.Text == "Паспортные данные")
            {
                error = false;
                string path = @"D:\Data\" + date + ".txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        depositor dep = new depositor();
                        if (s == "DEP")
                        {
                            dep.FirstName = sr.ReadLine();
                            dep.SecondName = sr.ReadLine();
                            dep.Bank_Book = sr.ReadLine();
                            dep.Pasport = sr.ReadLine();
                            dep.Phone = sr.ReadLine();
                            dep.Pasport_Party = sr.ReadLine();
                            dep.Dep_Money = double.Parse(sr.ReadLine());
                            dep.Procent_Money = dep.Dep_Money;
                            dep.Procent = double.Parse(sr.ReadLine());
                            dep.Procent_Name = sr.ReadLine();
                            dep.Valuta = sr.ReadLine();
                            dep.ChangeDate = sr.ReadLine();

                        }
                        if (dep.Pasport_Party == depositor.Text.Substring(0, 2) && dep.Pasport==depositor.Text.Substring(2))
                        {
                            error = true;
                            search_dep = dep;
                            break;
                        }
                    }
                }
                path = @"D:\Data\Change_" + date + ".txt";
                using(StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        depositor dep = new depositor();
                        if(s=="Add" && error)
                        {
                            for(int i = 0; i < 11; i++)
                            {
                                s = sr.ReadLine();
                            }
                        }
                        if (s == "Add" && !error)
                        {
                            dep.FirstName = sr.ReadLine();
                            dep.SecondName = sr.ReadLine();
                            dep.Bank_Book = sr.ReadLine();
                            dep.Pasport = sr.ReadLine();
                            dep.Phone = sr.ReadLine();
                            dep.Pasport_Party = sr.ReadLine();
                            dep.Dep_Money = double.Parse(sr.ReadLine());
                            dep.Procent_Money = 0;
                            dep.Procent = double.Parse(sr.ReadLine());
                            dep.Procent_Name = sr.ReadLine();
                            dep.Valuta = sr.ReadLine();
                            dep.ChangeDate = sr.ReadLine();


                            if (dep.Pasport_Party == depositor.Text.Substring(0, 2) && dep.Pasport == depositor.Text.Substring(2))
                            {
                                error = true;
                                search_dep = dep;
                            }
                        }
                        if(s=="Money_up" && error)
                        {
                            s = sr.ReadLine();
                            if (s == search_dep.Bank_Book)
                            {
                                s = sr.ReadLine();
                                search_dep.receiving(double.Parse(s));
                            }
                        }
                        if(s=="Money_down" && error)
                        {
                            s = sr.ReadLine();
                            if (s == search_dep.Bank_Book)
                            {
                                s = sr.ReadLine();
                                search_dep.receiving((-1) * double.Parse(s));
                            }
                        }
                        if(s=="Del" && error)
                        {
                            s = sr.ReadLine();
                            if (s == search_dep.Bank_Book)
                            {
                                error = false;
                            }
                        }
                    }
                }

            }
            if (chose_filter.Text == "Лицевой счёт")
            {
                error = false;
                string path = @"D:\Data\" + date + ".txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        depositor dep = new depositor();
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

                        }
                        if (dep.Bank_Book == depositor.Text)
                        {
                            error = true;
                            search_dep = dep;
                            break;
                        }
                    }
                }
                path = @"D:\Data\Change_" + date + ".txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        depositor dep = new depositor();
                        if (s == "Add" && error)
                        {
                            for (int i = 0; i < 11; i++)
                            {
                                s = sr.ReadLine();
                            }
                        }
                        if (s == "Add" && !error)
                        {
                            dep.FirstName = sr.ReadLine();
                            dep.SecondName = sr.ReadLine();
                            dep.Bank_Book = sr.ReadLine();
                            dep.Pasport = sr.ReadLine();
                            dep.Phone = sr.ReadLine();
                            dep.Pasport_Party = sr.ReadLine();
                            dep.Dep_Money = double.Parse(sr.ReadLine());
                            dep.Procent_Money = 0;
                            dep.Procent = double.Parse(sr.ReadLine());
                            dep.Procent_Name = sr.ReadLine();
                            dep.Valuta = sr.ReadLine();
                            dep.ChangeDate = sr.ReadLine();


                            if (dep.Bank_Book == depositor.Text)
                            {
                                error = true;
                                search_dep = dep;
                            }
                        }
                        if (s == "Money_up" && error)
                        {
                            s = sr.ReadLine();
                            if (s == search_dep.Bank_Book)
                            {
                                s = sr.ReadLine();
                                search_dep.receiving(double.Parse(s));
                            }
                        }
                        if (s == "Money_down" && error)
                        {
                            s = sr.ReadLine();
                            if (s == search_dep.Bank_Book)
                            {
                                s = sr.ReadLine();
                                search_dep.dispensing(double.Parse(s));
                            }
                        }
                        if (s == "Del" && error)
                        {
                            s = sr.ReadLine();
                            if (s == search_dep.Bank_Book)
                            {
                                error = false;
                            }
                        }
                    }
                }
            }
            if (error)
            {
                name.Text = search_dep.FirstName;
                s_name.Text = search_dep.SecondName;
                bank_book.Text = search_dep.Bank_Book;
                pasport.Text = search_dep.Pasport;
                pasport_party.Text = search_dep.Pasport_Party;
                phone.Text = search_dep.Phone;
                dep_money.Text = Convert.ToString(search_dep.Dep_Money);
                all_money.Text = Convert.ToString(search_dep.All_Money);
                procent.Text = Convert.ToString(search_dep.Procent);
                procent_name.Text = Convert.ToString(search_dep.Procent_Name);
                valuta.Text = search_dep.Valuta;
                chose_operation.Visible = true;
                money.Visible = true;
                ok_operation.Visible = true;
            }
            else
            {
                MessageBox.Show("Такого вкладчика не существует");
            }
        }

        private void ok_operation_Click(object sender, EventArgs e)//снятие денег и пополнение счёта
        {
            if (chose_operation.Text == "")
            {
                MessageBox.Show("Выбирите операцию");
                return;
            }
            if(chose_operation.Text=="Снять деньги")
            {
                double money = 0;
                if (this.money.Text=="" || !(double.TryParse(this.money.Text, out money)))
                {
                    MessageBox.Show("Некорректный ввод денег");
                    return;
                }
                if (search_dep.dispensing(money))
                {
                    dep_money.Text = Convert.ToString(search_dep.Dep_Money);
                    all_money.Text = Convert.ToString(search_dep.All_Money);
                    string path = @"D:\Data\Change_" + date + ".txt";
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Money_down");
                        sw.WriteLine(search_dep.Bank_Book);
                        sw.WriteLine(money);
                    }
                }
                return;
                
            }
            if (chose_operation.Text == "Вложить деньги")
            {
                double money = 0;
                if (!(double.TryParse(this.money.Text, out money)))
                {
                    MessageBox.Show("Некорректный ввод денег");
                    return;
                }
                search_dep.receiving(money);
                dep_money.Text = Convert.ToString(search_dep.Dep_Money);
                all_money.Text = Convert.ToString(search_dep.All_Money);
                string path = @"D:\Data\Change_" + date + ".txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Money_up");
                    sw.WriteLine(search_dep.Bank_Book);
                    sw.WriteLine(money);
                }
                return;
            }
        }
    }
}
