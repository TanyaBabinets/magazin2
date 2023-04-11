using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin2
{
        class Program
        {
            static void Main(string[] args)
            {
                Magazin mag = new Magazin("Cosmo", "1997", "for strong and beautiful women", "05033344455", "cosmo@gmail.com", 15);
                Magazin mag1 = new Magazin("Vogue", "1965", "fashion and style", "06033344400", "vogue@gmail.com", 25);

                Console.WriteLine(mag.GetYear());
                Console.WriteLine(mag1.GetContecst());
                Console.WriteLine(mag1.GetName());
                Console.WriteLine();
                Console.WriteLine(mag);
                Console.WriteLine("На какое количество сотрудников увеличить штат?");
                int n = Convert.ToInt32(Console.ReadLine());
                mag = mag + n;
                Console.WriteLine($"Станет { mag.employee} сотрудников");
                Console.WriteLine();
                Console.WriteLine(mag1);
                Console.WriteLine($"Сравнение количества сотрудников 2-х журналов через metod Equals = {mag.Equals(mag1)}");

                Console.WriteLine($"Сравнение количества сотрудников 2-х журналов через operator \'>\' = { mag > mag1}");
                Console.WriteLine("На какое количество количество сотрудников уменьшить штат?");
                n = Convert.ToInt32(Console.ReadLine());
                mag1 = mag1 - n;
                Console.WriteLine($"Станет { mag1.employee} сотрудников");
                Console.WriteLine($"Сравнение количества сотрудников 2-х журналов через operator \'==\' = { mag == mag1}");


            }

        }

        class Magazin
        {
            public string name;
            public string year;
            public string about;
            public string tel;
            public string email;
            public int employee;

            public Magazin(string n, string y, string ab, string t, string em, int emp)//main constructor
            {
                Console.WriteLine("Main constructor");
                name = n;
                year = y;
                about = ab;
                tel = t;
                email = em;
                employee = emp;

            }
            public Magazin() { Console.WriteLine("default const"); }


            public void SetName(string n)
            {
                name = n;
                Console.WriteLine(name);
            }

            public string GetName() { return name; }
            public void SetYear(string Y) { year = Y; }
            public string GetYear() { return year; }
            public void SetContecst(string ab) { about = ab; }
            public string GetContecst() { return about; Console.WriteLine(about); }
            public void SetTel(string t) { tel = t; }
            public string GetTel() { return tel; }
            public void SetEmail(string em) { email = em; }

            public static Magazin operator +(Magazin ob, int n)
            {
                return new Magazin(ob.name, ob.year, ob.about, ob.tel, ob.email, ob.employee + n);
            }

            public static Magazin operator -(Magazin ob, int n)
            {
                return new Magazin(ob.name, ob.year, ob.about, ob.tel, ob.email, ob.employee - n);
            }

            public static bool operator >(Magazin ob1, Magazin ob2)
            {
                return ob1.employee > ob2.employee;
            }

            public static bool operator <(Magazin ob1, Magazin ob2)
            {
                return !(ob1 > ob2);
            }

            public static bool operator ==(Magazin ob1, Magazin ob2)
            {
                return ob1.employee == ob2.employee;
            }

            public static bool operator !=(Magazin ob1, Magazin ob2)
            {
                return !(ob1 == ob2);
            }

            public override bool Equals(object obj)
            {

                if (obj == null)
                    return false;

                Magazin mag = (Magazin)obj;

                if (employee == mag.employee)
                    return true;

                return false;
            }

            public override string ToString()
            {
                string result = "";
                result += $"Magazin { name} was issued in { year} and publishes { about }\n";
                result += $"Contacts are: {tel} e-mail {email}\n";
                result += $"We have {employee} employees as our regular staff ";
                return result;
            }


        }

    }
    //ИТОГ:
    //Magazin Cosmo was issued in 1997 and publishes for strong and beautiful women
    //Contacts are: 05033344455 e - mail cosmo @gmail.com
    //  We have 15 employees as our regular staff
    //  На какое количество сотрудников увеличить штат?
    //  5
    //Main constructor
    //  Станет 20 сотрудников

    //  Magazin Vogue was issued in 1965 and publishes fashion and style
    //  Contacts are: 06033344400 e-mail vogue@gmail.com
    //  We have 25 employees as our regular staff
    //  Сравнение количества сотрудников 2-х журналов через metod Equals = False
    //  Сравнение количества сотрудников 2-х журналов через operator '>' = False
    //  На какое количество количество сотрудников уменьшить штат?
    //5
    //Main constructor
    //  Станет 20 сотрудников
    //  Сравнение количества сотрудников 2-х журналов через operator '==' = True


}
