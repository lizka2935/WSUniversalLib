using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using WSUniversalLib;

namespace WSUniversalLibTests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        private void ReadInputData(string fileName, out int productType, out int materialType, out int count, out float width, out float length)
        {
            string path = "C:\\Users\\Student\\source\\repos\\WSUniversalLib\\WSUniversalLibTests\\bin\\Debug\\TestingData" + fileName;
            string[] data = File.ReadAllLines(path);
            productType =  int.Parse(data[0]);
            materialType= int.Parse(data[1]);
            count = int.Parse(data[2]);
            width = int.Parse(data[3]);
            length = int.Parse(data[4]);

        }
        private int ReadOutrupData(string fileName)
        {
            string path = "C:\\Users\\Student\\source\\repos\\WSUniversalLib\\WSUniversalLibTests\\bin\\Debug\\TestingData" + fileName;
            string data = File.ReadAllText(path);
            return int.Parse(data);
        }
    }
}
