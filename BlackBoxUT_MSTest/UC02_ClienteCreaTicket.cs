using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;

namespace BlackBoxUT_MSTest
{
    [TestClass]
    public class UC02_ClienteCreaTicket : TestSession
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

        public bool CrearSolicitud(string User, string Passwd, bool IsTecnico = false, string Categoria = "", string Titulo = "", string Descripcion = "", bool ExpectedError = false)
        {
            try
            {
                if (LogIn(User, Passwd, IsTecnico) == false)
                {
                    return false;
                }

                //Abre Ventana Solicitudes de Cliente
                WindowsElement WinElem_CrearSolicitud = null;
                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        if (WinElem_CrearSolicitud != null)
                            break;
                        WinElem_CrearSolicitud = desktopSession.FindElementByAccessibilityId("btnCrearSolicitud");
                        System.Threading.Thread.Sleep(100);
                    }
                    catch { }
                }

                if (WinElem_CrearSolicitud == null)
                    return false;

                WinElem_CrearSolicitud.Click();

                //Abre ventana Crear Solicitud
                WindowsElement WinElem_Categoria = null;
                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        if (WinElem_Categoria != null)
                            break;
                        WinElem_Categoria = desktopSession.FindElementByAccessibilityId("CB_Categoria");
                        System.Threading.Thread.Sleep(100);
                    }
                    catch { }
                }

                if (WinElem_Categoria == null)
                    return false;
                if (!string.IsNullOrWhiteSpace(Categoria))
                {
                    ///"Soporte a Usuarios", "Compra de Equipos", "Instalación de Programas"
                    WinElem_Categoria.SendKeys(Categoria);
                }
                desktopSession.FindElementByAccessibilityId("txtTitulo").SendKeys(Titulo);
                desktopSession.FindElementByAccessibilityId("txtDescripcion").SendKeys(Descripcion);
                desktopSession.FindElementByAccessibilityId("btnCrearTicket").Click();

                //Cierra mensaje emergente.
                desktopSession.FindElementByName("OK").Click();
                if (ExpectedError)
                {
                    desktopSession.FindElementByAccessibilityId("BtnCancelarTicket").Click();
                }
                desktopSession.FindElementByAccessibilityId("BtnCerrarSesion").Click();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }

        [TestMethod]
        public void BU_004_CrearSolicitud()
        {
            Assert.IsTrue(CrearSolicitud("klaus123", "1", false, "", "", "", true));
        }

        [TestMethod]
        public void BU_005_CrearSolicitud()
        {
            Assert.IsTrue(CrearSolicitud(
                "SsnHhTwrr712AxpIuzoptW2IILS6u5ZFIHYmYHh07GsFPj3jaSo37uP0WTS00eOe3KBrJiqVpJUqCwYQXTUCqOMBuRPnmLncXGKV0pVqSKuiz2E1GHM8updejNGyIAPkDmtA6PGLdh9MzVJUi1Yz0ZHgJWnx67eiXZAv4vFT1LzEMLC8tn0EgXH6WkMyd5pYFWrvHxc5eMGwT6KLTabYO9BGrBN3WlaWp4BINoF5FjCtpovt3KEbvQBUk7WaMsi",
                "ioTRzmLH5twsZADCPoae8RghvAQhPqOrDsiamiaEI5I5wkXqSdtMWxQ7MJAFYmD1FFwpXkU3DL9OdcK2NNhhYXh283u1L7pZIWv9FXGP6cmTXpFRdd7YMHfPMgjdtrFo1OiJdwLndQwaADOaFT2n1U543KLJZuAwGQT3K8DfLfFy5vtEbTz0TKQeWvXXLMJiyx0PsgbO6SIGaENsJ6SB1uHRZw3DMJVdPbhnOc21ojzjroV4teiOMLjIe9J8TTL", 
                false,
                "Soporte a Usuarios",
                "Teams se queda cargando",
                "Cuando intento abrir la aplicación, se presenta en blanco en vez de mostrar la pantalla de forma adecuada y deja de responder después de un tiempo.", 
                false));
        }

        [TestMethod]
        public void BU_006_CrearSolicitud()
        {
            Assert.IsTrue(CrearSolicitud(
                "kelvinLee",
                "1234",
                false,
                "",
                "Fng7N36ZGANccHahTFZXhp5nT0LCX4qvYMtOmViKZjLLEd3UUVo8PqtNdkgkecVigtA9WYrEWovTa59ji5OG140pVFToxeSM8C014d6Quv3rjKKkrsdnHFlvLyFnLdsMWAcoqgBO3QhUZlnJY7LSLk3CQmoYOGSFzmToXEzX5BxHcDkPWUMSUkR8FdJGyvq7b2UiZBCEkMHW4rEHbYNd9emYsLMSYgUyBT0WwLRwqy4A2hMW5EZHF5aATURwaE0 + 1",
                "jYvHFzzX0eDw7LILUpRfoADUBLp9UtRVpJklla1vNk9jO3JwDEdQf8gQKqj2ezYQEWY2pkNXy54IOi0mfxrsElVe7hoIadpuNFF4TMLg5ThjYkPqh3B3W8OU70jvDrK4JBF7gG123dlujzwFWRn6v5CyM4uvnoPvveHBJ3SaV1dMmFBeh48etrnDyv9AI6kJffGQ5EICro0vjvEny9ot44kjk7WaFMBY7u4yCgGQroirNtiMVaBuvizXGMjYHpq + 1",
                true));
        }
    }
}
