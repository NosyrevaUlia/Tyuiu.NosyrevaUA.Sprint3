using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NosyrevaUA.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18

    {
        public string ReplaceNumOnChar(string value, char item)
        {
            
            foreach(char c in value)
            {
                if (Char.IsDigit(c))
                {
                    value = value.Replace(c, item);
                }
            }
            return value;
        }
    }
}
