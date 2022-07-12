using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{//This is a program about multi-level inheritance.
    class Doctor
    {
        protected string name_doc;
        protected string band_doc;
        protected int salary_doc;
        protected void PrintDocInfo()
        {
            Console.WriteLine("Doctor's Name: " + name_doc);
            Console.WriteLine("Doctor's Salary: " + salary_doc);
            Console.WriteLine("Doctor's Band: " + band_doc);
        }
        
    }
    class Nurse : Doctor
    {
        protected string name_nur;
        protected string band_nur;
        protected int salary_nur;
        protected void PrintNurInfo()
        {
            Console.WriteLine("Nurse's Name: " + name_nur);
            Console.WriteLine("Nurse's Salary: " + salary_nur);
            Console.WriteLine("Nurse's Band: " + band_nur);
        }
    }
    class Nonmedic : Nurse
    {
        protected string name_nm;
        protected string band_nm;
        protected int salary_nm;
        protected void PrintNmInfo()
        {
            Console.WriteLine("Non Medic's Name: " + name_nm);
            Console.WriteLine("Non Medic's Salary: " + salary_nm);
            Console.WriteLine("Non Medic's Band: " + band_nm);
        }
    }
    class Intern : Nonmedic
    {
        protected string name_in;
        protected string band_in;
        protected int salary_in;
        protected void PrintInInfo()
        {
            Console.WriteLine("Intern's Name: " + name_in);
            Console.WriteLine("Intern's Salary: " + salary_in);
            Console.WriteLine("Intern's Band: " + band_in);
        }
        static void Main(string[] args)
        {
            Intern obj = new Intern();
            obj.name_doc = "Faustus";
            obj.salary_doc = 250000;
            obj.band_doc = "B2";
            obj.name_nur = "XX";
            obj.salary_nur = 50000;
            obj.band_nur = "AA";
            obj.name_nm = "TT";
            obj.salary_nm = 25000;
            obj.band_nm = "A";
            obj.name_in = "New Entry 1";
            obj.band_in = "No Band";
            obj.salary_in = 12500;
            Console.WriteLine("**********Information Of ABC Hospital**********");
            obj.PrintDocInfo();
            obj.PrintNurInfo();
            obj.PrintNmInfo();
            obj.PrintInInfo();
            Console.ReadLine();
        }
    }
    
}
