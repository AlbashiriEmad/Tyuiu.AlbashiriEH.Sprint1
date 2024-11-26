using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlbashiriEH.Sprint1.Task2.V2.Lib;

namespace Tyuiu.AlbashiriEH.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            var rez = ds.ConvertAngleToRad(x);
            Assert.AreEqual(rez, (Math.PI / 180));
        }
    }
}
