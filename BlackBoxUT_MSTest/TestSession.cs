using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackBoxUT_MSTest
{
    public class TestSession
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string TestApp = @"C:\Users\vmontero\Source\Repos\SIG_Tickets\SIG_Tickets\bin\Debug\SIG_Tickets.exe";
     
        protected static WindowsDriver<WindowsElement> session;
        public static WindowsDriver<WindowsElement> desktopSession;

        public static void Setup(TestContext context)
        {
            if (session == null)
            {
                // Create a new session to bring up the test application
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", TestApp);
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                options.AddAdditionalCapability("platformName", "Windows");

                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
                Assert.IsNotNull(session);
                Assert.IsNotNull(session.SessionId);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);

                AppiumOptions optionsDesktop = new AppiumOptions();
                optionsDesktop.AddAdditionalCapability("app", "Root");
                optionsDesktop.AddAdditionalCapability("deviceName", "WindowsPC");
                optionsDesktop.AddAdditionalCapability("ms:experimental-webdriver", true);
                desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), optionsDesktop);

            }
        }
    
        public static void TearDown()
        {
            if (session != null)
            {
                session.Quit();
                session = null;
            }

            if (desktopSession != null)
            {
                desktopSession.Quit();
                desktopSession = null;
            }
        }

        public static WindowsElement FindElementByAbsoluteXPath(/*this*/ WindowsDriver<WindowsElement> desktopSession, string xPath, int nTryCount = 3)
        {
            WindowsElement uiTarget = null;
            while (nTryCount-- > 0)
            {
                try
                {
                    uiTarget = desktopSession.FindElementByXPath(xPath);
                }
                catch
                {
                }
                if (uiTarget != null)
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(400);
                }
            }
            return uiTarget;
        }

        public bool LogIn(string User, string Passwd, bool IsTecnico = false)
        {
            //Click on username
            var winElem_LogIn_UserName = desktopSession.FindElementByAccessibilityId("txtUserName");

            if (winElem_LogIn_UserName != null)
            {
                winElem_LogIn_UserName.Click();
            }
            else
            {
                return false;
            }

            //Type username
            System.Threading.Thread.Sleep(100);
            winElem_LogIn_UserName.SendKeys(User);

            //Click on password
            var winElem_LogIn_Passwd = desktopSession.FindElementByAccessibilityId("txtPassword");

            if (winElem_LogIn_Passwd != null)
            {
                winElem_LogIn_Passwd.Click();
            }
            else
            {
                return false;
            }

            //Type password
            System.Threading.Thread.Sleep(100);
            winElem_LogIn_Passwd.SendKeys(Passwd);

            //Click on TipoCuenta ... SI es un Cliente, haz clic y lo marcara como cliente.
            if (IsTecnico == false)
            {
                var winElem_LogIn_TipoCuenta = desktopSession.FindElementByAccessibilityId("TipoCuenta");

                if (winElem_LogIn_TipoCuenta != null)
                {
                    winElem_LogIn_TipoCuenta.Click();
                }
                else
                {
                    return false;
                }
            }

            //Click on LogIn
            var winElem_LogIn_btnLogIn = desktopSession.FindElementByAccessibilityId("btnLogIn");

            if (winElem_LogIn_btnLogIn != null)
            {
                winElem_LogIn_btnLogIn.Click();
            }
            else
            {
                return false;
            }

            return true;
        }

    }
}
