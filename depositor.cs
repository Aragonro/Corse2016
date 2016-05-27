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
        public string Bank_Book
        {
            get; set;
        }
        public string Phone
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string SecondName
        {
            get; set;
        }
        public string Valuta
        {
            get; set;
        }
        public double Procent
        {
            get; set;
        }
        public string Procent_Name
        {
            get; set;
        }
        public string Pasport
        {
            get; set;
        }
        public string Pasport_Party
        {
            get; set;
        }
        public double Procent_Money
        {
            get; set;
        }
        public double All_Money
        {
            get { return Procent_Money + Dep_Money; }
        }
        public double Dep_Money
        {
            get; set;
        }
        public string ChangeDate
        {
            get; set;
        }
        public void receiving(double money)
        {
            Dep_Money += Math.Round(money, 2);
        }
        public bool dispensing(double money)
        {

            if (Procent_Money >= money)
            {
                Procent_Money -= money;
                return true;
            }
            if (Procent_Money + Dep_Money >= money)
            {
                Dep_Money += Procent_Money - money;
                Procent_Money = 0;
                return true;
            }
            MessageBox.Show("Не достаточно денег на счету!");
            return false;
        }

        
    }
}
