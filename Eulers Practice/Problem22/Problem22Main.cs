using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers_Practice.Problem22
{
    class Problem22Main
    {
        public void Run()
        {
            List<string> names = new List<string>();

            string[] lines = File.ReadAllLines(@"C:\Users\kohl.meister\Desktop\p022_names.txt");

            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });
                names = col.ToList();
            }

            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i].Replace("\"", "");
            }

            names.Sort();
            var total = 0;
            for (int i = 0; i < names.Count; i++)
            {
                var nameValue = 0;
                foreach (char j in names[i])
                {
                    nameValue += char.ToUpper(j) - 64;
                }
                total += nameValue * (i + 1);
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
