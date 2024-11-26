using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlbashiriEH.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            string str = value.ToLower();
            string symbol1 = str.Substring(0, 1);
            string word01 = str.Substring(1);
            bool check = false;
            if (word01.Contains(symbol1)) check = true;
            else check = false;
            return check;
        }
    }
}
