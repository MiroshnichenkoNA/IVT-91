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
    }
}
