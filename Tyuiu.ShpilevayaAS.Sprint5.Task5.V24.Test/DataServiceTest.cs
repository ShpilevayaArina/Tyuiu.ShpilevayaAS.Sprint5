using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShpilevayaAS.Sprint5.Task5.V24.Lib;


namespace Tyuiu.ShpilevayaAS.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint5\Tyuiu.ShpilevayaAS.Sprint5.Task5.V24\bin\Debug\InPutDataFileTask5V24.txt";

            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
