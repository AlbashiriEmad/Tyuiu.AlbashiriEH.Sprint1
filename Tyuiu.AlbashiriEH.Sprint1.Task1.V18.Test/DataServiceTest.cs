using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlbashiriEH.Sprint1.Task1.V18.Lib;

namespace Tyuiu.AlbashiriEH.Sprint1.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, -2);
        }
    }
}
