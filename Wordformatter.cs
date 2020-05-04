using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearning
{
    class WordFormatter
    {
        public static string ToStandart(string name)
        {
            var array = name.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsUpper(array[i]))
                {
                    array[i] = char.ToLower(array[i]);
                }
            }
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }
    }
}
