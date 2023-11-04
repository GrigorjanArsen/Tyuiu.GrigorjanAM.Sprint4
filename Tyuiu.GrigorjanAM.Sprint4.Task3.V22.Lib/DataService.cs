using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GrigorjanAM.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int m = 0;

            for (int j = 0; j < columns; j++)
            {
                if (array[0, j] > m)
                {
                    m = array[0, j];
                }
            }
            return m;

        }
    }
}
