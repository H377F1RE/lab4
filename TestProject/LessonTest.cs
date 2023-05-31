using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class LessonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime TestDate = DateTime.Now.Date;
            Lesson L = new Lesson(TestDate, null, null, null, null, null, null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Lesson L = new Lesson(null, null, null, null, null, null);
        }
    }
}
