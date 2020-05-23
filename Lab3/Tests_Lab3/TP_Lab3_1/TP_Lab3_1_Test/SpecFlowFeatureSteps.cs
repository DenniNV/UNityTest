using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
using TechTalk.SpecFlow;

namespace TP_Lab3_1_Test
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        private Application _application;
        private Window _window;
        private TextBox _pathWriter;
        private Button _addPath;
        private Button _deleteFirst;
        private Button _deleteSecond;
        private Button _slide;
        private Button _return;
        [BeforeScenario]
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
        [AfterScenario]
        public void End()
        {
            _window.Close();
        }
        [Given(@"I write path d:")]
        public void GivenIWritePathD()
        {
            _pathWriter.Text = "d:";
            
        }
        
        [Given(@"I write bad path d:/")]
        public void GivenIWriteBadPathD()
        {
            _pathWriter.Text = "d:/";
        }
        
        [Given(@"I am not writing path")]
        public void GivenIAmNotWritingPath()
        {

        }
        
        [Given(@"I am selecting listItem in the first list")]
        public void GivenIAmSelectingListItemInTheFirstList()
        {
            _pathWriter.Text = "d:";
            _addPath.Click();
            _window.Get<ListBox>("listBox1").Select("d:");
        }
        
        [Given(@"I am selecting listItem in the second list")]
        public void GivenIAmSelectingListItemInTheSecondList()
        {
            _pathWriter.Text = "d:/";
            _addPath.Click();
            _window.Get<ListBox>("listBox2").Select("d:/");
        }
        
        [When(@"I press Add")]
        public void WhenIPressAdd()
        {
            _addPath.Click();
        }
        
        [When(@"I press Delete in the first list")]
        public void WhenIPressDeleteInTheFirstList()
        {
            _deleteFirst.Click();
        }
        
        [When(@"I press Delete in the second list")]
        public void WhenIPressDeleteInTheSecondList()
        {
            _deleteSecond.Click();
        }
        
        [When(@"I press Slide in the first list")]
        public void WhenIPressSlideInTheFirstList()
        {

            _slide.Click();
        }
        
        [When(@"I press return in the second list")]
        public void WhenIPressReturnInTheSecondList()
        {
            _return.Click();
        }
        
        [When(@"I press retirn in the second list")]
        public void WhenIPressRetirnInTheSecondList()
        {
            _return.Click();
        }
        
        [Then(@"the result should be path d: in the first listBox")]
        public void ThenTheResultShouldBePathDInTheFirstListBox()
        {
            Assert.AreEqual(_window.Get<ListBox>("listBox1").Items.Count, 1);
        }
        
        [Then(@"the result should be path d:/ in the second listBox")]
        public void ThenTheResultShouldBePathDInTheSecondListBox()
        {
            Assert.AreEqual(_window.Get<ListBox>("listBox2").Items.Count, 1);
        }
        
        [Then(@"the result should be messageBox")]
        public void ThenTheResultShouldBeMessageBox()
        {
            var messageBox = _window.MessageBox("Ошибка");
            Assert.AreEqual(messageBox.IsModal, true);
        }
        
        [Then(@"the result should be selected item have to be deleted")]
        public void ThenTheResultShouldBeSelectedItemHaveToBeDeleted()
        {
            Assert.AreEqual(_window.Get<ListBox>("listBox1").Items.Count, 0);
        }
        
        [Then(@"the result item deleted in the fitst list and aded to the second list")]
        public void ThenTheResultItemDeletedInTheFitstListAndAdedToTheSecondList()
        {
            Assert.AreEqual(_window.Get<ListBox>("listBox2").Items.Count, 1);
        }
        
        [Then(@"the result item deleted in the second list and aded to the textbox")]
        public void ThenTheResultItemDeletedInTheSecondListAndAdedToTheTextbox()
        {
            Assert.AreEqual(_pathWriter.Text, "d:/");
        }
        
        [Then(@"the result message box with error")]
        public void ThenTheResultMessageBoxWithError()
        {
            var messageBox = _window.MessageBox("Ошибка");

            Assert.AreEqual(messageBox.IsModal, true);
        }
    }
}
