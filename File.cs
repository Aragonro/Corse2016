using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    static class Work_File
    {
        //запись последней даты
        public static void work_date(string date)
        {
            string path = @"D:\Data\date.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(date);
            }


        }
        //создание файла со вкладчиками которые существуют на момент наступление даты date.
        public static void work_dep(List<depositor> dep,string date)
        {
            string path = @"D:\Data\" + date+".txt";


            using (StreamWriter sw = File.AppendText(path))
            {
                foreach(depositor d in dep)
                {
                    sw.WriteLine("DEP");
                    sw.WriteLine(d.FirstName);
                    sw.WriteLine(d.SecondName);
                    sw.WriteLine(d.Bank_Book);
                    sw.WriteLine(d.Pasport);
                    sw.WriteLine(d.Phone);
                    sw.WriteLine(d.Pasport_Party);
                    sw.WriteLine(d.Dep_Money);
                    sw.WriteLine(d.Procent_Money);
                    sw.WriteLine(d.Procent);
                    sw.WriteLine(d.Procent_Name);
                    sw.WriteLine(d.Valuta);
                    sw.WriteLine(d.ChangeDate);
                }
            }
            path = @"D:\Data\Change_" + date + ".txt";
            using (StreamWriter sw = File.AppendText(path))
            {

            }
        }
        //получение денег за день.
        public static void money_up(List<depositor> dep,string date)
        {
            DateTime dt = DateTime.Parse(date);
            int day=365;
            if (DateTime.IsLeapYear(dt.Year))
            {
                day = 366;
            }
            

            foreach (depositor d in dep)
            {
                if (d.Procent_Name == "Умные")
                {
                    d.Procent_Money += Math.Round((d.Procent_Money+d.Dep_Money) * d.Procent / 100/ day,2);
                }
                else
                {
                    d.Procent_Money += Math.Round(d.Dep_Money * d.Procent / 100/ day,2);
                }
            }
        }
        //добавление вкладчика
        public static void Add(string f_name,string s_name,string bank_book,string phone,string p_pasport,string pasport,double sum,string value,double procent,string name_procent,string date)
        {
            depositor dep = new depositor();
            string path = @"D:\Data\Change_" + date+".txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Add");
                sw.WriteLine(dep.FirstName = f_name);
                sw.WriteLine(dep.SecondName = s_name);
                sw.WriteLine(dep.Bank_Book = bank_book);
                sw.WriteLine(dep.Pasport = pasport);
                sw.WriteLine(dep.Phone = phone);
                sw.WriteLine(dep.Pasport_Party = p_pasport);
                sw.WriteLine(dep.Dep_Money = sum);
                sw.WriteLine(dep.Procent = procent);
                sw.WriteLine(dep.Procent_Name = name_procent);
                sw.WriteLine(dep.Valuta = value);
                sw.WriteLine(dep.ChangeDate = date);
            }
        }
        //удаление вкладчика
        public static void Delete(string bank_book,string date)
        {
            string path = @"D:\Data\Change_" + date+".txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Delete");
                sw.WriteLine(bank_book);
            }
         }
        //наступление следующего дня.
        public static string Next_Day(string date)
        {
            string path = @"D:\Data\" +date+".txt";
            List<depositor> depositors = new List<depositor>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == "DEP")
                    {
                        depositor dep = new depositor();
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

                        depositors.Add(dep);

                    }
                }
            }
            path = @"D:\Data\Change_" + date+".txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == "Add")
                    {
                        depositor dep = new depositor();
                        dep.FirstName = sr.ReadLine();
                        dep.SecondName = sr.ReadLine();
                        dep.Bank_Book = sr.ReadLine();
                        dep.Pasport= sr.ReadLine();
                        dep.Phone= sr.ReadLine();
                        dep.Pasport_Party= sr.ReadLine(); 
                        dep.Dep_Money= double.Parse(sr.ReadLine());
                        dep.Procent= double.Parse(sr.ReadLine());
                        dep.Procent_Name= sr.ReadLine();
                        dep.Valuta= sr.ReadLine();
                        dep.ChangeDate= sr.ReadLine();
                        dep.Procent_Money= 0;

                        depositors.Add(dep);

                    }
                    if (s == "Delete")
                    {
                        s = sr.ReadLine();
                        foreach(depositor dep in depositors)
                        {
                            if (dep.Bank_Book == s)
                            {
                                depositors.Remove(dep);
                                break;
                            }
                        }
                    }
                    if (s == "Money_up")
                    {
                        s = sr.ReadLine();
                        foreach(depositor dep in depositors)
                        {
                            if (dep.Bank_Book == s)
                            {
                                s = sr.ReadLine();
                                dep.receiving(double.Parse(s));
                                dep.ChangeDate = date;
                                break;
                            }
                        }
                    }
                    if (s == "Money_down")
                    {
                        s = sr.ReadLine();
                        foreach (depositor dep in depositors)
                        {
                            if (dep.Bank_Book == s)
                            {
                                s = sr.ReadLine();
                                dep.dispensing(double.Parse(s));
                                dep.ChangeDate = date;
                                break;
                            }
                        }
                    }
                }

            }
            money_up(depositors, date);
            string date1 = DateTime.Parse(date).AddDays(1).ToString();
            date = date1.Substring(0, 10);
            work_dep(depositors, date);
            return date;
        }

    }
}
