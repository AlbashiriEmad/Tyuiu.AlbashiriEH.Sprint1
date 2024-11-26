using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlbashiriEH.Sprint1.Task3.V5.Lib;

namespace Tyuiu.AlbashiriEH.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 5;
            var rez = ds.DistanceLength(x, y);
            Assert.AreEqual(rez, 15);


        }
    }
}
