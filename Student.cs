using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_assignment
{
    internal class Student
    {
        private string name;
        private int age;
        private string major;

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public void Introduce()
        {
            Console.WriteLine($"This is {name}, {age} years old. And majoring in {major}");
        }
    }
}
