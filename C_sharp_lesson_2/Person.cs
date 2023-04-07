using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_lesson_2
{
    internal class Person
    {
        private string name;
        //private int age;
        public string Name { /*set;*/ get { return name; }}

        public int Age { get; set; }

        public void Print() 
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}");
           // Console.WriteLine("Имя{0} возраст {1}", Name, Age);
        }

        public Person(string _name) 
        {
                name = _name;
        }

        //private int myVar;        
        /* public int MyProperty { 
             get { return myVar; }
             set 
             { 
                 if(value % 2 == 0) 
                 {
                     myVar = value;
                 }
                 else 
                 { 
                     myVar = 0; 
                 }               
             }
         }*/

    }
}
