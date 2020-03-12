using System;
using System.Collections.Generic;

namespace TestCSharpLanguage.Base
{
    public class ArrayList
    {
        public ArrayList()
        {
            {
                Console.WriteLine("************二维数组**************");
                int[][] array = new int[2][];
                array[0] = new int[3];
                array[0][1] = 11;
                array[0][2] = 12;
                array[1] = new int[] { 1, 2, 3, 4, 5 };

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.WriteLine(array[i][j]);
                    }
                }
            }
            {
                Console.WriteLine("************二维数组List**************");

                List<List<double>> vs = new List<List<double>>();
                for (int i = 0; i < 10; i++)
                {
                    List<double> vs1 = new List<double>();
                    for (int j = 0; j < 10; j++)
                    {
                        double a = i * j;
                        vs1.Add(a);
                    }
                    vs.Add(vs1);
                }

                Console.WriteLine(vs[2][3]);
            }
        }


    }
}
