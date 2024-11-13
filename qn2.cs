using System;
using First;
using Second;

namespace First{
    class Person{
        public string name;
        public int age;
        public void PersonDetails(){
            Console.WriteLine("Name: {0}\nAge:{1}", name, age);
        }
    }
}

namespace Second{
    class Student{
        public int id;
        public string name;
        public void StudentDetails(){
            Console.WriteLine("Name: {0}\nID:{1}", name, id);
        }
    }
}

namespace Program{
    class MainProgram{
        static void Main(){
            Person p = new Person();
            p.name = "Urmila";
            p.age = 21;
            p.PersonDetails();
            Student std = new Student();
            std.name = "Urmila Shrestha";
            std.id = 100;
            std.StudentDetails();
        }
    }
}
