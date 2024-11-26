using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlbashiriEH.Sprint1.Task7.V5.LIb
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double schet = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2));
            double res = Math.Round(schet, 3);
            return res;

        }
    }
}
