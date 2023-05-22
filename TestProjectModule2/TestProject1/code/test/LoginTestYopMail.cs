using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.page;
using TestProject1.code.session;

namespace TestProject1.code.test
{
    [TestClass]
    public class LoginTestYopMail : TestBaseYopMail
    {
        MainPageYopMail mainPage = new MainPageYopMail();
        InboxSectionYopMail inboxSection = new InboxSectionYopMail();
        IfMailSectionYopMail mailSection = new IfMailSectionYopMail();
        TopSectionYopMail topSection = new TopSectionYopMail();
        string accountName = "newtest90";
        string subjectText = "YopMail Workflow Mail test";
        
        [TestMethod]
        public void Test1_AccesToATemporaryAccount()
        {
            
            mainPage.EmailImputTextBox.SetText(accountName);
            mainPage.loginButton.Click();
            Assert.IsTrue(topSection.AccountNameIsDisplayed(),
                "ERROR !! Can not access to the Account");
                       
        }

        [TestMethod]
        public void Test2_SendAMailSuccessfully()
        {
            Test1_AccesToATemporaryAccount();
            inboxSection.newMailButton.Click();
            mailSection.ChangeToIfMailIframe();
            mailSection.toTextBox.SetText(accountName + "@yopmail.com");
            mailSection.subjectTextBox.SetText(subjectText);
            mailSection.msgBody.SetText("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla dictum tellus eget purus sollicitudin dictum. Nunc laoreet elit at metus auctor malesuada. Quisque at augue et turpis euismod gravida. Sed mollis euismod erat ac placerat. Ut viverra sapien eu justo feugiat, eu placerat odio pulvinar. Cras quis libero mauris. Sed auctor ligula sit amet mi fringilla, eget tristique arcu fringilla. Vestibulum tristique, nisl ac feugiat fermentum, metus quam blandit massa, id dictum leo nulla a mauris. Sed quis tincidunt lorem. Curabitur at tristique dui. Nullam quis neque sed dui facilisis eleifend. Fusce vulputate est a dui venenatis lobortis. Quisque eu tristique dui.");
            mailSection.sendButton.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(mailSection.ConfirmationMessageIsDisplayed(),
                "ERROR !! Mail couldn't be sent...");
                       
        }

        [TestMethod]
        public void Test3_ReceiveMailSuccessfully()
        {
            Test1_AccesToATemporaryAccount();            
            inboxSection.ClickRefreshInbox();            
            inboxSection.ChangeToInboxMailIframe();
            inboxSection.ClickMail(subjectText);
            Thread.Sleep(3000);            
            mailSection.ChangeToIfMailIframe();
            Assert.IsTrue(mailSection.SubjectMailIsDisplayed(subjectText), "Error!! The Subject Mail was not found");
            
        }
        [TestMethod]
        public void Test4_DeleteMailSuccessfully()
        {
            Test1_AccesToATemporaryAccount();
            inboxSection.ChangeToInboxMailIframe();
            inboxSection.ClickMail(subjectText);
            mailSection.ChangeToIfMailIframe();          
            mailSection.DeleteSelectedMail();
            mainPage.ChangeToMainIframe();            
            Assert.IsTrue(!topSection.MailDeletedMessageIsDisplayed(), "Error!! The Subject Mail was not found");
            Thread.Sleep(3000);

        }


    }
}
