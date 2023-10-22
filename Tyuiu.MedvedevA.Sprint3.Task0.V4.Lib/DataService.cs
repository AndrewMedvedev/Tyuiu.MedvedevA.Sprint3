using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvedevA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double mul = 1;
            while (startValue <= stopValue)
            {
                double st1 = startValue;
                double rr = 3 / st1;
                mul = mul * Math.Pow(rr, -2);
                startValue++;
            }
            return Math.Round(mul, 3);
        }
    }
}
