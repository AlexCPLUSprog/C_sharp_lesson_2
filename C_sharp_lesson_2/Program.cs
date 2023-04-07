using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_lesson_2
{
    internal class Program
    {
      static List<Person> Ask_N_Times(int n)
        {
            var ans = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(CreatePerson());
            }
            return ans;
        }
        static Person CreatePerson()
        {            
            string name;
            int age = 0;
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            
            do {
                try
                {
                    Console.WriteLine("Введите возраст:");
                    age = int.Parse(Console.ReadLine());
                    if (age <= 0)
                    {
                        Console.WriteLine("Возраст не может быть 0 и ниже");
                    }
                    else if (age > 120)
                    {
                        Console.WriteLine("Слишком большой возраст");
                    }
                }
                catch (Exception)
                {                    
                    Console.WriteLine("Возраст введен некорректно");
                }                
            } while (age <= 0 || age > 120);

            var person = new Person(name);
            person.Age = age;
            return person;
        }
        static void Main(string[] args)
        {
            int r;
            // 3 задание из дз
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=======");               
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }*/

            /* person.MyProperty = 1;
           Console.WriteLine(person.MyProperty);*/

            /* Person person = new Person("Bilbo Baggins");                   
            person.Age = 21;
            person.Print();*/
            Console.WriteLine("Введите количество людей: ");
            r = int.Parse(Console.ReadLine());
            var PersonList = Ask_N_Times(r);
                                                                 //PersonList.Sort();    // тут должна быть сортировка
            foreach(Person person in PersonList) 
            {
                Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
            }



        }        
    }
}
