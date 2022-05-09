using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace Lab4_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            bool f = true;
            bool f1 = true;
            Field.Display();
            while (f)
            {
                Field.Game_State();
                Console.Write("Введите Элемент: ");
                string element = Console.ReadLine();
                char Element = Convert.ToChar(element);
                Console.Write("Введите столбец: ");
                string x = Console.ReadLine();
                Console.Write("Введите строку: ");
                string y = Console.ReadLine();
                int X = Convert.ToInt32(x);
                int Y = Convert.ToInt32(y);
                Field.Insert_Element(Element, X, Y);
                Field.Display();
                f1 = Field.Game_End();
                f = Field.Flag_Check();
                if (f1 != f && f1 == false) f = f1;
                Console.WriteLine();
            }
            Console.WriteLine("Игра окончена!");
        }
    }
}
