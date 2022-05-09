using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace GameLibrary
{
    public class Class1
    {
        public char[,] field = new char[3, 3];
        public int counter = 1;
        public int player = 1;
        bool flag = true;
        public void Create_Field()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j] = '*';
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Текущее состояние поля:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(field[i, j] + "   ");
                }
                Console.Write("\n");
            }
        }

        public void Game_State()
        {
            Console.WriteLine("Ход: " + counter + " " + " Игрок номер: " + player);
            counter++;
            if (player == 1) player++;
            else player--;
        }

        public void Insert_Element(char elem, int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[y - 1, x - 1] == '*')
                    {
                        field[y - 1, x - 1] = elem;
                    }
                    else { };
                }
            }
        }
    }
}
