using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearning
{
    [Serializable]
    class Word
    {
        public string Name { get; set; }

        public string Value { get; set; }
        public Word(string name, string value)
        {

            Name = WordFormatter.ToStandart(name);
            Value = WordFormatter.ToStandart(value);
        }

        public override string ToString()
        {
            return $"{Name} - {Value}";
        }
    }
}
