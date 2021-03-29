using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Здравствуй, {name}, сегодня [{DateTime.Now}]");
           
        }
        
    }
}
