﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NosyrevaUA.Sprint3.Task0.V19.Lib
{
    public class DataService : ISprint3Task0V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumser = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumser = sumser + (Math.Pow(1 / (Math.Cos(i) + 2), 2));
            }
            return (Math.Round(sumser, 3));
        }
    }
}
