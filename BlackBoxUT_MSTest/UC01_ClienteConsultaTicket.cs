
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;

namespace BlackBoxUT_MSTest
{
    [TestClass]
    public class UC01_ClienteConsultaTicket : TestSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        public bool ConsultarSolicitud(string User, string Passwd, bool IsTecnico = false, string FilaSeleccionada = null)
        {
            if(LogIn(User,Passwd,IsTecnico) == false)
            {
                return false;
            }

            //Selecciona primera fila con un "doble clic"
            WindowsElement WinElem_DataGrid = null;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    if (WinElem_DataGrid != null)
                        break;
                    WinElem_DataGrid = desktopSession.FindElementByAccessibilityId("MyTable");
                    System.Threading.Thread.Sleep(100);
                }
                catch { }
            }
            if (WinElem_DataGrid != null)
            {
                WinElem_DataGrid.SendKeys(Keys.PageUp);
                if (FilaSeleccionada == "Last")
                    WinElem_DataGrid.SendKeys(Keys.PageDown);
                WinElem_DataGrid.SendKeys(Keys.Enter);

                desktopSession.FindElementByAccessibilityId("BtnCancelar")?.Click();
                desktopSession.FindElementByAccessibilityId("BtnCerrarSesion")?.Click();
            }
            else
            {
                Console.WriteLine($"La tabla no tenia ninguna fila. No hay tickets creados.");
                return false;
            }

            return true;
        }

        [TestMethod]
        public void BU_001_ConsultarSolicitud()
        {
            Assert.IsTrue(ConsultarSolicitud("kelvin1234", "1"));
        }

        [TestMethod]
        public void BU_002_ConsultarSolicitud()
        {
            Assert.IsTrue(
                ConsultarSolicitud(
                    "LnBTubThGKpIGHTJMR0gR3ToDdxjOMboQZFVFBI02eUvWZG82WsKixSJvllHOKL9TGAml2ydgENO1PNqphr6qHRC0kHhFVf9MwmBZ8FmAh5Y96hohVfftcoiCYTDbsDV7BQtzTOaVWBN7zskZsbFrItj2aTxeJaSWHLSSHtdpkUw7m24MT1Gy0BpefwNPL1PLJRjq9oyiADbDxr2pghri14LcT1LY71sSI29ugfPV952JJjkGo3p0g5jsatrMMt", 
                    "1"));
        }

        [TestMethod]
        public void BU_003_ConsultarSolicitud()
        {
            Assert.IsTrue(
                ConsultarSolicitud(
                    "a",
                    "Y60uwvarsR8I5T58YSJ2qjAXNsSs01t3stvBAQsqfpCYaviIxsACI7RHjIvRxXb7t3D4b6XyEzp5klKBf3sFgXyU3rOMadwewqik9ZNNKQbaBQ0UYoc6ynYQVRlkP8A7PdMebpnomzw04XLRbpLcEEnV3aHQaccPrsozhPfqKOSq00khbTgW1KbB0SoNg1l0eMCcefyjMMfxbqzYTz8vK5dNHMz3Emt658UFjjTD340AfPWXpjiYOvRNOqBAbIo",
                    false,
                    "Last"));
        }
    }
}
