using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShpilevayaAS.Sprint5.Task4.V5.Lib;


namespace Tyuiu.ShpilevayaAS.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint5\Tyuiu.ShpilevayaAS.Sprint5.Task4.V5\bin\Debug\InPutDataFileTask4V5.txt";

            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
