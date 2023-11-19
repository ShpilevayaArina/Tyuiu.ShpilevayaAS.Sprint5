using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShpilevayaAS.Sprint5.Task3.V26.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint5\Tyuiu.ShpilevayaAS.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
