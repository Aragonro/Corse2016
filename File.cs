using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    class Work_File
    {
        private static IEnumerable<depositor> depositors;

        public static void work_date(string date)
        {
            string path = @"D:\Data\date.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(date);
            }


        }

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
                    sw.WriteLine(d.All_Money);
                    sw.WriteLine(d.Procent);
                    sw.WriteLine(d.Procent_Name);
                    sw.WriteLine(d.Valuta);
                    sw.WriteLine(d.ChangeDate);
                }
            }
        }

        public static void money_up(List<depositor> dep,string date)
        {
            DateTime dt = DateTime.Parse(date);
            int day = dt.DayOfYear;

            foreach (depositor d in dep)
            {
                if (d.Procent_Name == "Умные")
                {
                    d.All_Money += d.All_Money * d.Procent / (100+ day);
                }
                else
                {
                    d.All_Money += d.Dep_Money * d.Procent / (100+ day);
                }
            }
        }

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

        public static void Delete(string bank_book,string date)
        {
            string path = @"D:\Data\Change_" + date+".txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Delete");
                sw.WriteLine(bank_book);
            }
         }
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
                        dep.All_Money = dep.Dep_Money;
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
                        dep.All_Money= dep.Dep_Money;

                        depositors.Add(dep);

                    }
                    if (s == "Delete")
                    {
                        s = sr.ReadLine();
                        foreach(depositor i in depositors)
                        {
                            if (i.Bank_Book == s)
                            {
                                depositors.Remove(i);
                                break;
                            }
                        }
                    }
                }

            }
            money_up(depositors, date);
            date = DateTime.Parse(date).AddDays(1).ToString();
            work_dep(depositors, date);
            return date;
        }

        private static void work_dep(IEnumerable<depositor> depositors, string date)
        {
            throw new NotImplementedException();
        }

        private static void money_up(IEnumerable<depositor> depositors, string date)
        {
            throw new NotImplementedException();
        }
    }
}
