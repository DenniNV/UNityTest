using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string e = "Невозможно пострить прямоугольник";
       
        private StringFormatter _stringFormatter = new StringFormatter();
        private ArrayProcessor _arrayProcessor = new ArrayProcessor();

       
        [TestMethod]
        public void TestMethod1()
        {
            double[] ArrayX = { 1, 4, 1, 4 };
            double[] ArrayY = { 2, 6, 2, 6 };
            Rectangle rectangle = new Rectangle(ArrayX, ArrayY);
            Assert.AreEqual(rectangle.Diagonal(), 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double[] ArrayX = { -1, 4, 1, 4 };
            double[] ArrayY = { 2, 6, 2, 6 };
            Rectangle rectangle = new Rectangle(ArrayX, ArrayY);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => rectangle.Diagonal());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(_stringFormatter.WebString(""), "");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(_stringFormatter.WebString("DenniNV.git"), "git://DenniNV.git");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(_stringFormatter.WebString("DenniNV"), "http://DenniNV");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(_stringFormatter.WebString("http://DenniNV"), "http://DenniNV");
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.ThrowsException<NullReferenceException>(() => _stringFormatter.WebString(null));
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] a = { 1,5,11111,0,-4850 };
            int[] c = _arrayProcessor.SortAndFilter(a);
            Assert.AreEqual(c[0] , 11111);
        }
        // Task 2;
        [TestMethod]
        public void TestMethod9()
        {
            IFileService fileService = new FileServerStub();
            Assert.AreEqual(fileService.MergeTemporaryFiles("D:/Test"), 4);

        }

        [TestMethod]
        public void TestMethod10()
        {
            IFileService fileService = new FileServerStubExeption();
            Assert.ThrowsException<NullReferenceException>(() => fileService.MergeTemporaryFiles("dasdasgfqa"));
        }

        [TestMethod]
        public void TestMethod11()
        {
            IFileService fileService = new FileServerStubStopMetod();
            Assert.AreEqual(fileService.MergeTemporaryFiles("D:/Test"), 0);
        }

        [TestMethod]
        public void TestMethod12()
        {
            IFileService fileService = new FileServerStub();
            //fileService.CreateTempFileForDelete("D:\\Lab2TESTPO\\");
            int deletedBytes =  fileService.RemoveTemporaryFiles("D:\\Lab2TESTPO\\");
            Assert.AreEqual(3, deletedBytes);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod13()
        {
            IFileService fileService = new FileServerStubExeption();
            fileService.RemoveTemporaryFiles("dsda");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod14()
        {
            IFileService fileService = new FileServerStubExeption();
            fileService.RemoveTemporaryFiles("aassd");
        }

        [TestMethod]
        public void TestMethod15()
        {
            IFileService fileService = new FileServerStub();
           // fileService.CreateTempFileForDelete("D:\\Lab2TESTPO\\");
           // ReportViewer reportViewer = new ReportViewer();
            // reportViewer.Clean("D:\\Lab2TESTPO\\");
            int deletedBytes = fileService.RemoveTemporaryFiles("dsadasad");
            Assert.AreEqual(3, deletedBytes);
        }
    }
}
