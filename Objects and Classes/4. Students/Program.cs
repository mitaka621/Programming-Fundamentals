using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Class clas1 = new Class();
            for (int i = 0; i < n; i++)
            {

                string[] a = Console.ReadLine().Split().ToArray();
                clas1.AddStud(a[0], a[1], float.Parse(a[2]));
            }           
            Console.WriteLine(clas1.ToString());
            
        }
        public class Student
        {
            public Student(string firstName, string lastName, float grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get;private set; }
            public string LastName { get;private set; }
            public float Grade { get; private set; }
        }
        public class Class
        {
            List<Student> students;
            public Class()
            {
                students = new List<Student>();
            }
            public void AddStud(string firstName, string lastName, float grade)
            {
                this.students.Add(new Student(firstName, lastName, grade));
            }
            private void SortDesc()
            {
                this.students=students.OrderByDescending(x => x.Grade).ToList();
            }
            public override string ToString()
            {
                SortDesc();
                string str=string.Empty;
                foreach (Student item in students)
                {
                    str += $"{item.FirstName} {item.LastName} {item.Grade:F2}" + "\n";
                }
                return str;
            }
        }
    }
}
