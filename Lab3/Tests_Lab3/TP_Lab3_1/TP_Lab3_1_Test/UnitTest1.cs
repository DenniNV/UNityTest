using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;

namespace TP_Lab3_1_Test
{
    [TestClass]
    public class UnitTest1
    {
        private Application _application;
        private Window _window;
        private TextBox _pathWriter;
        private Button _addPath;
        private Button _deleteFirst;
        private Button _deleteSecond;
        private Button _slide;
        private Button _return;

        public void Initial()
        {
            _application = Application.Launch(@"C:\Users\Vinniko\source\repos\TP_Lab3_1\TP_Lab3_1\bin\Debug\TP_Lab3_1.exe");
            _window = _application.GetWindow("Form1");
            _pathWriter = _window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));
            _addPath = _window.Get<Button>(SearchCriteria.ByAutomationId("button1"));
            _deleteFirst = _window.Get<Button>(SearchCriteria.ByAutomationId("button2"));
            _deleteSecond = _window.Get<Button>(SearchCriteria.ByAutomationId("button4"));
            _slide = _window.Get<Button>(SearchCriteria.ByAutomationId("button3"));
            _return = _window.Get<Button>(SearchCriteria.ByAutomationId("button5"));
        }

        public void End()
        {
            _window.Close();
        }
        [TestMethod]
        public void RightPathTest()
        {
            Initial();

            _pathWriter.Text = "d:";
            _addPath.Click();


            Assert.AreEqual(_window.Get<ListBox>("listBox1").Items.Count, 1);
            End();
        }

        [TestMethod]
        public void BadPathTest()
        {
            Initial();

            _pathWriter.Text = "d:/";
            _addPath.Click();


            Assert.AreEqual(_window.Get<ListBox>("listBox2").Items.Count, 1);
            End();
        }

        [TestMethod]
        public void EmptyPathTest()
        {
            Initial();

            _addPath.Click();

            var messageBox = _window.MessageBox("Ошибка");

            Assert.AreEqual(messageBox.IsModal, true);
            End();
        }

        [TestMethod]
        public void DeletePathInFirstListTest()
        {
            Initial();

            _pathWriter.Text = "d:";
            _addPath.Click();
            _window.Get<ListBox>("listBox1").Select("d:");
            _deleteFirst.Click();


            Assert.AreEqual(_window.Get<ListBox>("listBox1").Items.Count, 0);
            End();
        }

        [TestMethod]
        public void DeletePathInSecondListTest()
        {
            Initial();

            _pathWriter.Text = "d:/";
            _addPath.Click();
            _window.Get<ListBox>("listBox2").Select("d:/");
            _deleteSecond.Click();


            Assert.AreEqual(_window.Get<ListBox>("listBox2").Items.Count, 0);
            End();
        }

        [TestMethod]
        public void SlidePathTest()
        {
            Initial();

            _pathWriter.Text = "d:";
            _addPath.Click();
            _window.Get<ListBox>("listBox1").Select("d:");
            _slide.Click();

            Assert.AreEqual(_window.Get<ListBox>("listBox2").Items.Count, 1);
            End();
        }

        [TestMethod]
        public void ReturnPathTest()
        {
            Initial();

            _pathWriter.Text = "d:/";
            _addPath.Click();
            _pathWriter.Text = string.Empty;
            _window.Get<ListBox>("listBox2").Select("d:/");
            _return.Click();

            Assert.AreEqual(_pathWriter.Text, "d:/");
            End();
        }

        [TestMethod]
        public void ReturnPathEmptyTest()
        {
            Initial();

            _pathWriter.Text = "d:/";
            _addPath.Click();
            _pathWriter.Text = string.Empty;
            _return.Click();

            var messageBox = _window.MessageBox("Ошибка");

            Assert.AreEqual(messageBox.IsModal, true);
            End();
        }


    }
}
