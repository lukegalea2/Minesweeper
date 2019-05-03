using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper_test
{
    class OtherInputs
    {
        public char [,] LastInputs(int row, int coloumn)
        {
            int a = 0, b = 0;

            //UserInput ui = new UserInput();
            //var i = ui.getInput();

            //a = i.M;
            //b = i.N;

            a = row;
            b = coloumn;

            char[,] grid = new char[a,b];

            Console.WriteLine("Insert either a '*' or a '.' for {0} coloumns and {1} rows", a, b);

            for(int l = 0; l < a; l++)
            {
                for(int k = 0; k < b; k++)
                {
                    grid[l,k] = Convert.ToChar(Console.Read());


                }
                Console.Write("");
            }

            Console.Clear();

            for (int l = 0; l < a; l++)
            {
                for (int k = 0; k < b; k++)
                {
                    Console.Write(grid[l, k]);


                }
                Console.WriteLine("");

            }

            Console.WriteLine("Press any key to confirm input");
            Console.ReadKey();
            Console.Clear();
            
            return grid;
            }
        }
}
