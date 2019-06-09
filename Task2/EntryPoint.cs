using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task2.GmailPage;
using System;

namespace Task2
{
    /// <summary>
    /// the main class of Program,entry point to the application.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method,which starts others methods
        /// </summary>
        static void Main()
        {
            try
            {
                IWebDriver webDriver = new ChromeDriver();
                StartingMailPage startpage = new StartingMailPage(webDriver);
                startpage.StartPage();
                startpage.EnterInMail("alekseeva.katya98", "itisapassword");

                Message message = new Message(webDriver);
                message.WriteMessage("lipskaya.julia.98@gmail.com", "Hello Julia!");

                LoginGmailPage login = new LoginGmailPage(webDriver);
                login.StartPage();
                login.EnterInGmail("lipskaya.julia.98", "1j3u5l7i9a");

                CheckUnreadMailInGmail reader = new CheckUnreadMailInGmail(webDriver);
                reader.CheckUnreadMail();

                ReaderMessageInGmail gmail = new ReaderMessageInGmail(webDriver);
                gmail.ReadingMessage();

                TextMessageToMail textMessage = new TextMessageToMail(webDriver);
                textMessage.TextingAnswerMessageToMail("Просто Катя");

                startpage.StartPage();
                startpage.EnterInMail("alekseeva.katya98", "itisapassword");

                ReadingAndGettingMessageFromGmail messageFromGmail = new ReadingAndGettingMessageFromGmail(webDriver);
                messageFromGmail.ReadingMessageFromGmail();

                NewUserNameInMail newUserName = new NewUserNameInMail(webDriver);
                newUserName.SettingsNickName(messageFromGmail.GetNewName()); 
            }
            catch(Exception)
            {
                Console.WriteLine("Something Error!");
            }
        }
    }
}
