using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShpilevayaAS.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int cnt = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char i in line)
                    {
                        if (alf.Contains(i))
                        {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }
    }
}
