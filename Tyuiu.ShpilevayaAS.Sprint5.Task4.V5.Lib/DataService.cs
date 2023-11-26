using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShpilevayaAS.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string x_str = File.ReadAllText(path);
            double x = Convert.ToDouble(x_str);
            double res = Math.Round(((4.26*x)/Math.Sin(x)), 3);
            return res;
        }
    }
}
