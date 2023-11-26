using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShpilevayaAS.Sprint5.Task6.V6.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint5.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint5\Tyuiu.ShpilevayaAS.Sprint5.Task6.V6\bin\Debug\InPutDataFileTask6V6.txt";

            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint5\Tyuiu.ShpilevayaAS.Sprint5.Task6.V6\bin\Debug\InPutDataFileTask6V6.txt";

            var res2 = ds.LoadFromDataFile(path);
            int wait = 22;
            Assert.AreEqual(wait, res2);
        }
    }
}
