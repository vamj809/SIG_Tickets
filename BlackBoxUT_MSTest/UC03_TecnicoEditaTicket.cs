using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;

namespace BlackBoxUT_MSTest
{
    [TestClass]
    public class UC03_TecnicoEditaTicket : TestSession
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

        public bool EditarSolicitud(string User, string Passwd, bool IsTecnico = false, string Categoria = "", string Estado = "", string Comentario = "")
        {
            if (LogIn(User, Passwd, IsTecnico) == false)
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
                //Selecciona el primero del datagrid.
                WinElem_DataGrid.SendKeys(Keys.PageUp);
                WinElem_DataGrid.SendKeys(Keys.Enter);

                //Abre ventana Editar Solicitud
                WindowsElement WinElem_Categoria = null;
                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        if (WinElem_Categoria != null)
                            break;
                        WinElem_Categoria = desktopSession.FindElementByAccessibilityId("CbCategoria");
                        System.Threading.Thread.Sleep(100);
                    }
                    catch { }
                }

                if (WinElem_Categoria == null)
                    return false;

                //Edita los Valores respectivos [Si no se van a modificar, se deben dejar en blanco o nulos
                if (!string.IsNullOrWhiteSpace(Categoria))
                {
                    ///"Soporte a Usuarios", "Compra de Equipos", "Instalación de Programas"
                    WinElem_Categoria.SendKeys(Categoria);
                }
                if (!string.IsNullOrWhiteSpace(Estado))
                {
                    ///"Abierto", "Cerrado", "Inactivo"
                    desktopSession.FindElementByAccessibilityId("CbEstado").SendKeys(Estado);
                }
                desktopSession.FindElementByAccessibilityId("txtComentario").SendKeys(Comentario);

                desktopSession.FindElementByAccessibilityId("btnEditarSolicitud").Click();
                desktopSession.FindElementByAccessibilityId("BtnCerrarSesion").Click();
            }
            else
            {
                Console.WriteLine($"La tabla no tenia ninguna fila. No hay tickets creados.");
                return false;
            }

            return true;
        }

        [TestMethod]
        public void BU_007_EditarSolicitud()
        {
            Assert.IsTrue(EditarSolicitud("Jonathan4862", "User456789", true,"","Cerrado", "gBEB8mVFhXXMloBuI0sLI8zvqWbVTsGA1Wkfam3BBYYPXRRjNo"));
        }

        [TestMethod]
        public void BU_008_EditarSolicitud()
        {
            Assert.IsTrue(EditarSolicitud("J", "9", true, "", "", 
                "ayyusgjfvhhwapytvoagvfqnuqmbjcigkcgcrrpakyjeogjdkyvnoonkqknjhrdfrsqvilobqrpbnzbqwoqqtsxnythubwupisiedewomerpxglwhumvmgdrfghqvxhamwyjtgyoemvzpvoedrkvdcxjmgqfxgikqcrkqfngjpkjbosqgatgyxvrwwahepnpwuaqzvjcknrpwisvcbszuslnnzzgyymvkoygvxdnqrrtfhriycqwmxxnkqbeqie"));
        }

        [TestMethod]
        public void BU_009_EditarSolicitud()
        {
            Assert.IsTrue(
                EditarSolicitud(
                    "ayyusgjfvhhwapytvoagvfqnuqmbjcigkcgcrrpakyjeogjdkyvnoonkqknjhrdfrsqvilobqrpbnzbqwoqqtsxnythubwupisiedewomerpxglwhumvmgdrfghqvxhamwyjtgyoemvzpvoedrkvdcxjmgqfxgikqcrkqfngjpkjbosqgatgyxvrwwahepnpwuaqzvjcknrpwisvcbszuslnnzzgyymvkoygvxdnqrrtfhriycqwmxxnkqbeqie",
                    "ayyusgjfvhhwapytvoagvfqnuqmbjcigkcgcrrpakyjeogjdkyvnoonkqknjhrdfrsqvilobqrpbnzbqwoqqtsxnythubwupisiedewomerpxglwhumvmgdrfghqvxhamwyjtgyoemvzpvoedrkvdcxjmgqfxgikqcrkqfngjpkjbosqgatgyxvrwwahepnpwuaqzvjcknrpwisvcbszuslnnzzgyymvkoygvxdnqrrtfhriycqwmxxnkqbeqie", 
                    true, "Instalación de Programas", "Inactivo",
                    "ayyusgjfvhhwapytvoagvfqnuqmbjcigkcgcrrpakyjeogjdkyvnoonkqknjhrdfrsqvilobqrpbnzbqwoqqtsxnythubwupisiedewomerpxglwhumvmgdrfghqvxhamwyjtgyoemvzpvoedrkvdcxjmgqfxgikqcrkqfngjpkjbosqgatgyxvrwwahepnpwuaqzvjcknrpwisvcbszuslnnzzgyymvkoygvxdnqrrtfhriycqwmxxnkqbeqie"));
        }
    }
}
