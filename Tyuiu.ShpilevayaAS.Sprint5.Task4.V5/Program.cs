using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShpilevayaAS.Sprint5.Task4.V5.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint5.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Шпилевая А. С. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл. Прочитать значение из файла и подставить вместо X в формулу:  *");
            Console.WriteLine("*      4.26*x                                                             *");
            Console.WriteLine("* y = --------                                                            *");
            Console.WriteLine("*      sin(x)                                                             *");
            Console.WriteLine("* Округлить до трёх знаков после запятой. Вывести результат на экран.     *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint5\Tyuiu.ShpilevayaAS.Sprint5.Task4.V5\bin\Debug\InPutDataFileTask4V5.txt";


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine($" Даннные находятся в файле: {path}");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат выражения = {res}");
            Console.ReadKey();
        }
    }
}
