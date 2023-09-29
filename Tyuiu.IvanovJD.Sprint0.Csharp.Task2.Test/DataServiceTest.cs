using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint0.Csharp.Task2.Lib;

namespace Tyuiu.IvanovJD.Sprint0.Csharp.Task2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ярослав";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Ярослав", res);
        }
    }
}
