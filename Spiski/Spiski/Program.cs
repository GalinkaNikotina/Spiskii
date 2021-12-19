using System;
using System.Collections.Generic;

namespace Spiski
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };
            numbers.Add(6); // добавление элемента
            numbers.AddRange(new int[] { 7, 8, 9 });
            numbers.Insert(0, 666); // вставляем на первое место в списке число 666
            numbers.RemoveAt(1); //  удаляем второй элемент
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            List<Net> people = new List<Net>(3);
            people.Add(new Net() { Name = "Том" });
            people.Add(new Net() { Name = "Билл" });
            foreach (Net p in people)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
        class Net
        {
            public string Name { get; set; }
        }
    }
    
}
