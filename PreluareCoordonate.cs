using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK_Test
{
    class PreluareCoordonate
    {
        List<int> pos = new List<int>(new int[12]);

        public List<int> preluareCoordonate()
        {
            char[] delimiterChars = { ',' };
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Vittalik\source\repos\OpenTK Test\bin\Debug\coordonate.txt");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split(delimiterChars);
                int i = 0;
                foreach (string v in values)
                {
                    pos[i] = Int32.Parse(v);
                    i++;
                }
            }

            return pos;
        }

    }
}
