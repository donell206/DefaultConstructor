using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructor
{
    public class Student
    { 
        public string Name;
        public int Age;
        public string Email;


        public override string ToString()  //over tab   ..tostring..tab
        {
            return $"{Name} {Age} {Email}"; 
        }

        public void NameAndAge()
        {
            Console.WriteLine(Name + " "+ Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            bool b = true;
            Console.WriteLine(x.ToString());
            Console.WriteLine(b.ToString());




            Student student = new Student()
            {
                Name = "Toon",
                Age = 21,
                Email = "toon@gmail.com"
            };
            //Student.Name="Toon";
            Console.WriteLine(student.ToString());

            Student student1 = new Student()
            {
                Name = "Emre",
                Age = 28,
                Email = "emrefeloz@gmail.com"
            };
            //Student.Name="Toon";
            Console.WriteLine(student1.ToString());



        }
    }
}
