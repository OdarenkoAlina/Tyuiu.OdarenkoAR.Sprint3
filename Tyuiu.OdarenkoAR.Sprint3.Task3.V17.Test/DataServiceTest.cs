using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint3.Task3.V17.Lib;
namespace Tyuiu.OdarenkoAR.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string input = "*vn98n! b,";
            foreach(char c in input)
            {
                if(Char.IsDigit(c))
                {
                    ds.Append(c);
                }
            }
            string digitsOnly = ds.ToString();
            int result = int.Parse(digitsOnly);
        }
    }
}
