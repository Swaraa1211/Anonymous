using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class LambaClass
    {
        public static void Main(string[] args)
        {
            List<Student> StuList = new List<Student>();
            StuList.Add(new Student(){ Rollno = 1, Name = "Swara", Age = 20, Dept = "ECE", Place = "Mdu"});
            StuList.Add(new Student() { Rollno = 2, Name = "S", Age = 40, Dept = "IT", Place = "Mdu" });
            StuList.Add(new Student() { Rollno = 3, Name = "SS", Age = -26, Dept = "EEE", Place = "Mdu" });
            StuList.Add(new Student() { Rollno = 4, Name = "Hi", Age = -70, Dept = "CSE", Place = "Mdu" });
            StuList.Add(new Student() { Rollno = 8, Name = "Hello", Age = 60, Dept = "CSE", Place = "Mdu" });
            StuList.Add(new Student() { Rollno = 7, Name = "Hola", Age = 74, Dept = "ECE", Place = "Mdu" });
            StuList.Add(new Student() { Rollno = 6, Name = "Six", Age = 28, Dept = "CSE", Place = "Mdu" });
            StuList.Add(new Student() { Rollno = 5, Name = "Five", Age = 37, Dept = "ECE", Place = "Mdu" });
            //StuList.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));

            //StuList.ForEach(student => student.Rollno += 10);

            StuList.Sort((s1, s2) => s1.Age);

            foreach (var student in StuList)
            {
                Console.WriteLine($"{student.Rollno} Name {student.Name} Age {student.Age} Dept {student.Dept} Place {student.Place}");
            }

            /*
            foreach (var student in StuList.FindAll(student => student.Dept.Equals("ECE") && student.Age < 25))
            {
                Console.WriteLine($"{student.Rollno} Name {student.Name} Age {student.Age} Dept {student.Dept} Place {student.Place}");
            }*/

            //List<Student> newStuList = StuList.OrderBy(stud => stud.Age).ToList();
            /*List<Student> newStuList = StuList.FindAll(stud => stud.Age >=50).ToList();

            
            Console.WriteLine();
            foreach (var student in newStuList)
            {
                Console.WriteLine($"{student.Rollno} Name {student.Name} Age {student.Age} Dept {student.Dept} Place {student.Place}");
            }*/
        }
    }
    public class Student
    {
        string name;
        int rollno;
        int dept;
        int age;
        string place;
        public string Name { set; get; }
        public int Rollno { set; get; }
        public string Dept { set; get; }
        public int Age { set; get; }
        public string Place { set; get; }

        /*public void get()
        {
            //Console.Write("Your Name: ");
            name = Console.ReadLine();
        }*/
    }
}
