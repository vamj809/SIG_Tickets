using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackBoxUT
{
    public class TestSession
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string TestApp = @"C:\Users\vmontero\Source\Repos\SIG_Tickets\SIG_Tickets\bin\Debug\SIG_Tickets.exe";
     
        protected static WindowsDriver<WindowsElement> session;
     
        [SetUp]
        public static void Setup(TestContext context)
        {
            if (session == null)
            {
                // Create a new session to bring up the test application
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", TestApp);
                options.AddAdditionalCapability("deviceName", "WindowsPC");
     
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
            }
        }
    
        [TearDown]
        public static void TearDown()
        {
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }
    }
}
