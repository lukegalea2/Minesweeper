using System;

namespace Minesweeper_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;

            for (int j =1 ; j != 0; j++)
            {
               

               
                //Console.Clear();

                UserInput ui = new UserInput();
                var i = ui.getInput();

                a = i.M;
                b = i.N;

                if (a == 0 && b == 0)
                {
                    break;
                }
                

                char[,] grid = new char[a, b];
                OtherInputs oi = new OtherInputs();
                grid = oi.LastInputs(a, b);

                Workings w = new Workings();
                w.produceOutput(grid);


                
            }
        }
    }
}
