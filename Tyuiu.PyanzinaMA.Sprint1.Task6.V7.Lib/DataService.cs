using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PyanzinaMA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            char[] p = { ' ', ',', '.', ';', ':', '!', '?', '-' };
            
            value = value + " ";
            int l = value.Length;
            int i = 0;
            while (i < l)
            {
                if ((!p.Contains(value[i])) && (p.Contains(value[i + 1])))
                {
                    value = value.Remove(i, 1);
                    l--;
                    i--;
                }
                i++;
            }
            value = value.Trim();
            return value;

        }
    }
}
