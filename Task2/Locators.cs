using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Locators
    {
        public class LoginMailLocators
        {
            public string PageLocator { get; } = "https://mail.ru/";
            public string EnterLoginLocator { get; } = "//input[@name = 'login']";
            public string EnterPasswordLocator { get; } = "//input[@name = 'password']";
            public string EnterButtonLocator { get; } = "//*[text() = 'Войти']";
        }

        public class SendingMailMessageLocators
        {
            public string WritingMailButtonLocator { get; } = "//*[text() = 'Написать письмо']";//кнопка написать письмо
            public string AdressToLocator { get; } = "//*[contains(@name,'To') and @id='compose_to']";//кому отправить
            public string MessageBoxLocator { get; } = "//*[@id='tinymce']}";//поле для ввода текста сообщения
            public string SendButtonLocator { get; } = "//*[text()='Отправить']";//кнопка отправить сообщение
        }
        public class ReadingMailMessageLocators
        {
            public string IncomingButtonMailLocator { get; } = "//*[text()='Входящие']";
            public string MailFromGmailButtonLocator { get; } = "//*[contains(text(),'lipskaya.julia.98')]";
            public string MessageBoxLocator { get; } = "//*[@dir]";
        }
        public class LoginGmailLocators
        {
            public string PageLocator { get; } = "https://accounts.google.com/AccountChooser/identifier?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=AddSession";
            public string EnterLoginLocator { get; } = "//*[contains(@name,'identifier')]";//окошко для ввода логина или телефона
            public string ButtonNextLocator { get; } = "//span[contains(text(),'Далее')]";//кнопка далее,после ввода логина
            public string EnterPasswordLocator { get; } = "//input[@name='password']";//ввод пароля в окошко
            public string EnterButtonLocator { get; } = "//span[contains(text(),'Далее')]";//кнопка после ввода пароля
        }
        public class ReaderGmailLocators
        {
            public string IncomingButtonLocator { get; } = "//*[text()='Входящие']";//кнопка входящие сообщ
            public string MoreopportunityButtonLocator { get; } = "//div[contains(@class,'G-asx T-I-J3 J-J5-Ji') and @aria-hidden='true']";//кнопка для выбора непрочитанных сообщений
            public string UnreadButtonLocator { get; } = "//*[text()='Непрочитанные']";//кнопка непрочитанных сообще
                                                                                       //  public string IncomingMailLocator { get; } = $"//*[@email='{sender}']";
            public string CheckMarkTrueLocator { get; } = "//*[@aria-checked='true']";

        }

        public class EnterInUnreadMessageLocator
        {
            //  public void kgk(string sender)
            // {
            public string IncomingMailLocator { get; } = "//*[@email='alekseeva.katya98@mail.ru']";
            //  return $"//*[@email='{sender}']";
            // }
        }

        public class TextingMessageLocator
        {
            public string AnswerButtonLocator { get; } = "//*[text()='Ответить'and @role='link']";
            public string TextBoxLocator { get; } = "//*[@aria-label='Тело письма']";
            public string SendButtonLocator { get; } = "  //*[text() = 'Отправить']";
        }


        public class ChangingUserNameLocator
        {
            public string SettingsSelectionPanelLocator { get; } = " //*[@id='PH_user-email']";//РАЗВОРАЧИВАЕМ ПАНЕЛЛЬ
            public string PersonalDataButtonLocator { get; } = "//*[contains(text(),'Личные данные')]";
            public string NickNameLocator { get; } = "//*[@id='NickName']";//поле с псевдонимом
            public string SaveButtonLocator { get; } = "//*[text()='Сохранить'] ";
        }
    }
}