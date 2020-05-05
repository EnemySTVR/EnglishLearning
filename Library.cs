using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearning
{
    class Library : IEnumerable
    {


        List<Word> lib = new List<Word>();

        public Word this[int index]
        {
            get
            {
                return lib[index];
            }
        }


        public Library()
        {

        }

        public void Load()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();

            using (var file = new FileStream("Library.bin", FileMode.OpenOrCreate))
            {
                List<Word> words = null;

                try
                {
                    words = binFormatter.Deserialize(file) as List<Word>;
                }
                catch (SerializationException)
                {
                    var key = new Word("English", "Русский");
                    lib.Add(key);
                }
                

                
                if (words != null)
                {
                    lib = words as List<Word>;
                }
                return;

            }
        }
        public void Save()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();

            using (var file = new FileStream("Library.bin", FileMode.OpenOrCreate))
            {

                binFormatter.Serialize(file, lib);
            }
        }
        public void Add(Word word)
        {
            lib.Add(word);
        }
        public void Remove(Word word)
        {
            lib.Remove(word);
        }
        public int Count()
        { return lib.Count - 1; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lib.GetEnumerator();
        }

        public IEnumerator<Word> GetEnumerator()
        {
            return lib.GetEnumerator();
        }
    }
}
