namespace Autotests
{
    class Locators
    {
        /// <summary>
        /// Locators for enter in Mail 
        /// </summary>
        public class LoginMailLocators
        {
            public string PageLocator { get; } = "https://mail.ru/";
            public string EnterLoginLocator { get; } = "//input[@name = 'login']";
            public string EnterPasswordLocator { get; } = "//input[@name = 'password']";
            public string EnterButtonLocator { get; } = "//*[text() = 'Войти']";
        }

        /// <summary>
        /// Locators for writing message and send it
        /// </summary>
        public class SendingMailMessageLocators
        {
            public string WritingMailButtonLocator { get; } = "//*[text() = 'Написать письмо']";
            public string AdressToLocator { get; } = "//*[@data-original-name='To']";
            public string MessageBoxLocator { get; } = "//*[@id='tinymce']";
            public string SendButtonLocator { get; } = "//*[text()='Отправить']";
        }

        /// <summary>
        /// Locators for reading and gets text of message 
        /// </summary>
        public class ReadingMailMessageLocators
        {
            public string IncomingButtonMailLocator { get; } = "//*[text()='Входящие']";
            public string MailFromGmailButtonLocator { get; } = "//*[contains(text(),'lipskaya.julia.98')]";
            public string MessageBoxLocator { get; } = "//*[@dir]";
        }

        /// <summary>
        /// Locators for entering in Gmail
        /// </summary>
        public class LoginGmailLocators
        {
            public string PageLocator { get; } = "https://accounts.google.com/AccountChooser/identifier?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=AddSession";
            public string EnterLoginLocator { get; } = "//*[contains(@name,'identifier')]";
            public string ButtonNextLocator { get; } = "//span[contains(text(),'Далее')]";
            public string EnterPasswordLocator { get; } = "//input[@name='password']";
            public string EnterButtonLocator { get; } = "//span[contains(text(),'Далее')]";
        }

        /// <summary>
        /// Locators for reading incoming messages in Gmail
        /// </summary>
        public class ReaderGmailLocators
        {
            public string IncomingButtonLocator { get; } = "//*[text()='Входящие']";
            public string MoreopportunityButtonLocator { get; } = "//div[contains(@class,'G-asx T-I-J3 J-J5-Ji') and @aria-hidden='true']";//кнопка для выбора непрочитанных сообщений
            public string UnreadButtonLocator { get; } = "//*[text()='Непрочитанные']";
            public string IncomingMailLocator { get; } = "//*[@email='{sender}']";
            public string CheckMarkTrueLocator { get; } = "//*[@aria-checked='true']";

        }

        /// <summary>
        /// Locator for checking unread message
        /// </summary>
        public class EnterInUnreadMessageLocator
        {
            public string IncomingMailLocator { get; } = "//*[@email='alekseeva.katya98@mail.ru']";
        }

        /// <summary>
        /// Locators for answer in mail
        /// </summary>
        public class TextingMessageLocator
        {
            public string AnswerButtonLocator { get; } = "//*[text()='Ответить'and @role='link']";
            public string TextBoxLocator { get; } = "//*[@aria-label='Тело письма']";
            public string SendButtonLocator { get; } = "//*[text() = 'Отправить']";
        }

        /// <summary>
        /// Locators for reading and then changing user name
        /// </summary>
        public class ChangingUserNameLocator
        {
            public string SettingsSelectionPanelLocator { get; } = "//*[@id='PH_user-email']";
            public string PersonalDataButtonLocator { get; } = "//*[contains(text(),'Личные данные')]";
            public string NickNameLocator { get; } = "//*[@id='NickName']";
            public string SaveButtonLocator { get; } = "//*[text()='Сохранить'] ";
        }
    }
}