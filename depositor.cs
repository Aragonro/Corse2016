using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class depositor
    {
        string bank_book;
        public string Bank_Book
        {
            get { return bank_book; }
            set { bank_book = value; }
        }
        string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        string secondname;
        public string SecondName
        {
            get { return secondname; }
            set { secondname = value; }
        }
        string valuta;
        public string Valuta
        {
            get { return valuta; }
            set { valuta = value; }
        }
        double procent;
        public double Procent
        {
            get { return procent; }
            set { procent = value; }
        }
        string procent_name;
        public string Procent_Name
        {
            get { return procent_name; }
            set { procent_name = value; }
        }
        string pasport;
        public string Pasport
        {
            get { return pasport; }
            set { pasport = value; }
        }
        string pasport_party;
        public string Pasport_Party
        {
            get { return pasport_party; }
            set { pasport_party = value; }
        }
        double all_money;
        public double All_Money
        {
            get { return all_money; }
            set { all_money = value; }
        }
        double dep_money;
        public double Dep_Money
        {
            get { return dep_money; }
            set { dep_money = value; }
        }
        string changedate;
        public string ChangeDate
        {
            get { return changedate; }
            set { changedate = value; }
        }
        public void receiving(double money)
        {
            All_Money += Math.Round(money, 2);
        }
        public void dispensing(double money)
        {
            if (procent_name == "Умные")
            {
                if (All_Money >= money)
                {
                    All_Money -= money;
                }
                else
                {
                    MessageBox.Show("Не достаточно денег на счету!");
                }
            }
            else
            {
                if (dep_money + All_Money < money)
                {
                    MessageBox.Show("Не достаточно денег на счету!");
                    return;
                }
                if (dep_money < money)
                {
                    All_Money += dep_money - money;
                    return;
                }
                if (dep_money >= money)
                {
                    dep_money -= money;
                    return;
                }

            }
        }

        internal static void Add(depositor dep)
        {
            throw new NotImplementedException();
        }

        internal static int Count()
        {
            throw new NotImplementedException();
        }

        internal static void Remove(depositor i)
        {
            throw new NotImplementedException();
        }
    }
}
