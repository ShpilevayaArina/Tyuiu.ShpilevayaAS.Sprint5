using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShpilevayaAS.Sprint5.Task7.V9.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint5.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Шпилевая А. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Итоговый проект                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask7V9.txt (файл взять из архива    *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и копир. *");
            Console.WriteLine("* в неё файл) в котором есть набор символьных данных.                     *");
            Console.WriteLine("* Удалить все заглавные латинские буквы из файла.                         *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V9.txt.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V9.txt";

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V9.txt";


            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Исходные данные находятся в файле: " + path);
            Console.WriteLine("Конечные данные находятся в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.ReadLine();
        }
    }
}
