using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NosyrevaUA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double mulser = 1;
            while (startValue <= stopValue)
            {
                mulser = mulser * (Math.Pow(value, startValue) + (1 / 2));
                startValue++;
            }
            return Math.Round(mulser, 3);
        }
    }
}
