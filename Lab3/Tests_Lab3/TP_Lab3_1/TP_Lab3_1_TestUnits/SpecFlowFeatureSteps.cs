using System;
using TechTalk.SpecFlow;

namespace TP_Lab3_1....TP_Lab3_1_TestUnits
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        [Given(@"I write path ""(.*)""")]
        public void GivenIWritePath(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am not writing path")]
        public void GivenIAmNotWritingPath()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am selecting listItem in the first list")]
        public void GivenIAmSelectingListItemInTheFirstList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am selecting listItem in the second list")]
        public void GivenIAmSelectingListItemInTheSecondList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Delete in the first list")]
        public void WhenIPressDeleteInTheFirstList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Delete in the second list")]
        public void WhenIPressDeleteInTheSecondList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Slide in the first list")]
        public void WhenIPressSlideInTheFirstList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press return in the second list")]
        public void WhenIPressReturnInTheSecondList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press retirn in the second list")]
        public void WhenIPressRetirnInTheSecondList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be path ""(.*)"" in the listBox(.*)")]
        public void ThenTheResultShouldBePathInTheListBox(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be messageBox")]
        public void ThenTheResultShouldBeMessageBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be selected item have to be deleted")]
        public void ThenTheResultShouldBeSelectedItemHaveToBeDeleted()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result item deleted in the fitst list and aded to the second list")]
        public void ThenTheResultItemDeletedInTheFitstListAndAdedToTheSecondList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result item deleted in the second list and aded to the textbox")]
        public void ThenTheResultItemDeletedInTheSecondListAndAdedToTheTextbox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result message box with error")]
        public void ThenTheResultMessageBoxWithError()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
