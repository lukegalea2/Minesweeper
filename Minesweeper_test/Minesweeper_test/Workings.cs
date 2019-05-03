using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper_test
{
    class Workings
    {
        public void produceOutput(char [,] grid)
        {
            int a = 0, b = 0, c= 0, d= 0;
            OtherInputs oi = new OtherInputs();
                       
            int[,] output = new int[grid.GetLength(0), grid.GetLength(1)];

            for (int l = 0; l < grid.GetLength(0); l++)
            {
                for (int k = 0; k < grid.GetLength(1); k++)
                {
                    if (grid[l, k] == '*')
                    {
                        output[l, k] = ('*');
                    }

                    else if (grid[l, k] != '*')
                    {
                        if (l != 0)
                        {
                            if (grid[l - 1, k] == '*' )
                            {
                                output[l, k] += 1;
                            }
                        }
                        if (l != grid.GetLength(0) - 1)
                        {
                            if (grid[l + 1, k] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }
                        if (k != 0)
                        {
                            if (grid[l, k - 1] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }

                        if (k < grid.GetLength(1) - 1)
                        {
                            if (grid[l, k + 1] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }
                        if (l != 0 && k!= 0)
                        {
                            if (grid[l - 1, k - 1] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }
                        if (l < grid.GetLength(0) -1 && k <grid.GetLength(1)-1)
                        {
                            if (grid[l + 1, k + 1] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }
                        if (l != 0 && k < grid.GetLength(1) - 1)
                        {
                            if (grid[l - 1, k + 1] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }

                        if (k != 0 && l < grid.GetLength(0) - 1)
                        {
                            if (grid[l + 1, k - 1] == '*')
                            {
                                output[l, k] += 1;
                            }
                        }
                    }

                   


                }
                

            }

            for (int l = 0; l < grid.GetLength(0); l++)
            {
                for (int k = 0; k < grid.GetLength(1); k++)
                {
                   
                }
            }

                    for (int l = 0; l < grid.GetLength(0); l++)
            {
                for (int k = 0; k < grid.GetLength(1); k++)
                {

                    if (grid[l, k] == '*')
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(output[l, k]);
                    }

                }
                Console.WriteLine("");

            }

            Console.WriteLine("Press any key to confirm output");
            Console.ReadKey();
            //Console.Clear();
        }


    }
}
