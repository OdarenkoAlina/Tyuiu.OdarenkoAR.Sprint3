﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint3.Task5.V16.Lib;
namespace Tyuiu.OdarenkoAR.Sprint3.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
