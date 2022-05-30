using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Taskman;

namespace TaskmanTest
{
    [TestClass]
    public class FileAccessTest
    {
        [TestMethod]
        public void CanFileCreate()
        {
            FileAccess fa = new FileAccess();
            Assert.AreEqual(Const.RESULT_SUCCESS, fa.CreateFileOnCurrentDirectory("test1.txt", "test"));
        }
    }
}
