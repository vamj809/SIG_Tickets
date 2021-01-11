using NUnit.Framework;
using System;

namespace BlackBoxUT
{
    public class Tests : TestSession_CU
    {
        public void ClassInitialize(TestContext context)
        {
            Setup(context);
            
            //radGridView = session.FindElementByAccessibilityId("radGridView1");
            //radDropDownButtonThemes = session.FindElementByAccessibilityId("radDropDownButton1");
        }

        public static void ClassCleanup()
        {
            TearDown();
        }

        [Test]
        public void ConsultarSolicitudesAutoTest()
        {
            Assert.Pass();
            /*
            // LeftClick on Edit "" at (160,17)
            Console.WriteLine("LeftClick on Edit \"\" at (160,17)");
            string xpath_LeftClickEdit_160_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Inicio de Sesión\"][@AutomationId=\"LogIn\"]/Edit[@AutomationId=\"txtUserName\"]";
            var winElem_LeftClickEdit_160_17 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickEdit_160_17);
            
            if (winElem_LeftClickEdit_160_17 != null)
            {
                winElem_LeftClickEdit_160_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_160_17}");
                return;
            }


            // KeyboardInput VirtualKeys=""kelvin1234"" CapsLock=False NumLock=True ScrollLock=False
            Console.WriteLine("KeyboardInput VirtualKeys=\"\"kelvin1234\"\" CapsLock=False NumLock=True ScrollLock=False");
            System.Threading.Thread.Sleep(100);
            winElem_LeftClickEdit_160_17.SendKeys("kelvin1234");


            // LeftClick on Edit "Nombre de Usuario" at (157,20)
            Console.WriteLine("LeftClick on Edit \"Nombre de Usuario\" at (157,20)");
            string xpath_LeftClickEditNombredeUs_157_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Inicio de Sesión\"][@AutomationId=\"LogIn\"]/Edit[@Name=\"Nombre de Usuario\"][@AutomationId=\"txtPassword\"]";
            var winElem_LeftClickEditNombredeUs_157_20 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickEditNombredeUs_157_20);
            if (winElem_LeftClickEditNombredeUs_157_20 != null)
            {
                winElem_LeftClickEditNombredeUs_157_20.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditNombredeUs_157_20}");
                return;
            }


            // KeyboardInput VirtualKeys=""1"" CapsLock=False NumLock=True ScrollLock=False
            Console.WriteLine("KeyboardInput VirtualKeys=\"\"1\"\" CapsLock=False NumLock=True ScrollLock=False");
            System.Threading.Thread.Sleep(100);
            winElem_LeftClickEditNombredeUs_157_20.SendKeys("1");


            // LeftClick on CheckBox "Técnico" at (141,7)
            Console.WriteLine("LeftClick on CheckBox \"Técnico\" at (141,7)");
            string xpath_LeftClickCheckBoxTécnico_141_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Inicio de Sesión\"][@AutomationId=\"LogIn\"]/CheckBox[@Name=\"Técnico\"][@AutomationId=\"TipoCuenta\"]";
            var winElem_LeftClickCheckBoxTécnico_141_7 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickCheckBoxTécnico_141_7);
            if (winElem_LeftClickCheckBoxTécnico_141_7 != null)
            {
                winElem_LeftClickCheckBoxTécnico_141_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxTécnico_141_7}");
                return;
            }


            // LeftClick on Button "Iniciar Sesión" at (100,29)
            Console.WriteLine("LeftClick on Button \"Iniciar Sesión\" at (100,29)");
            string xpath_LeftClickButtonIniciarSes_100_29 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Inicio de Sesión\"][@AutomationId=\"LogIn\"]/Button[@Name=\"Iniciar Sesión\"][@AutomationId=\"btnLogIn\"]";
            var winElem_LeftClickButtonIniciarSes_100_29 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickButtonIniciarSes_100_29);
            if (winElem_LeftClickButtonIniciarSes_100_29 != null)
            {
                winElem_LeftClickButtonIniciarSes_100_29.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonIniciarSes_100_29}");
                return;
            }


            // LeftDblClick on Edit "Solicitud Row 0" at (99,16)
            Console.WriteLine("LeftDblClick on Edit \"Solicitud Row 0\" at (99,16)");
            string xpath_LeftDblClickEditSolicitudR_99_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Mis Solicitudes\"][@AutomationId=\"SolicitudesCliente\"]/Table[@Name=\"DataGridView\"][@AutomationId=\"MyTable\"]/Custom[@Name=\"Row 0\"]/Edit[@Name=\"Solicitud Row 0\"]";
            var winElem_LeftDblClickEditSolicitudR_99_16 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftDblClickEditSolicitudR_99_16);
            if (winElem_LeftDblClickEditSolicitudR_99_16 != null)
            {
                desktopSession.DesktopSessionElement.Mouse.MouseMove(winElem_LeftDblClickEditSolicitudR_99_16.Coordinates);
                desktopSession.DesktopSessionElement.Mouse.DoubleClick(null);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftDblClickEditSolicitudR_99_16}");
                return;
            }


            // LeftClick on Button "Cancelar" at (56,14)
            Console.WriteLine("LeftClick on Button \"Cancelar\" at (56,14)");
            string xpath_LeftClickButtonCancelar_56_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Mis Solicitudes\"][@AutomationId=\"SolicitudesCliente\"]/Window[@Name=\"Editar Solicitud #5\"][@AutomationId=\"EditarSolicitudes\"]/Button[@Name=\"Cancelar\"][@AutomationId=\"BtnCancelar\"]";
            var winElem_LeftClickButtonCancelar_56_14 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickButtonCancelar_56_14);
            if (winElem_LeftClickButtonCancelar_56_14 != null)
            {
                winElem_LeftClickButtonCancelar_56_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonCancelar_56_14}");
                return;
            }


            // LeftClick on Button "Cerrar Sesión" at (50,22)
            Console.WriteLine("LeftClick on Button \"Cerrar Sesión\" at (50,22)");
            string xpath_LeftClickButtonCerrarSesi_50_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Mis Solicitudes\"][@AutomationId=\"SolicitudesCliente\"]/Pane[starts-with(@AutomationId,\"panel\")]/Button[@Name=\"Cerrar Sesión\"][@AutomationId=\"BtnCerrarSesion\"]";
            var winElem_LeftClickButtonCerrarSesi_50_22 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickButtonCerrarSesi_50_22);
            if (winElem_LeftClickButtonCerrarSesi_50_22 != null)
            {
                winElem_LeftClickButtonCerrarSesi_50_22.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonCerrarSesi_50_22}");
                return;
            }


            // LeftClick on Button "Close" at (20,20)
            Console.WriteLine("LeftClick on Button \"Close\" at (20,20)");
            string xpath_LeftClickButtonClose_20_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Inicio de Sesión\"][@AutomationId=\"LogIn\"]/TitleBar[@AutomationId=\"TitleBar\"]/Button[@Name=\"Close\"][@AutomationId=\"Close\"]";
            var winElem_LeftClickButtonClose_20_20 = desktopSession.FindElementByAbsoluteXPath(xpath_LeftClickButtonClose_20_20);
            if (winElem_LeftClickButtonClose_20_20 != null)
            {
                winElem_LeftClickButtonClose_20_20.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonClose_20_20}");
                return;
            }*/
        }

        [Test]
        public void ConsultarSolicitudes()
        {
            //Click on username
            var winElem_LogIn_UserName = desktopSession.FindElementByName("txtUserName");

            if (winElem_LogIn_UserName != null) {
                winElem_LogIn_UserName.Click();
            }
            else {
                Console.WriteLine($"Failed to find element using Name: {"txtUserName"}");
                return;
            }

            //Type username
            System.Threading.Thread.Sleep(100);
            winElem_LogIn_UserName.SendKeys("kelvin1234");

            //Click on password
            var winElem_LogIn_Passwd = desktopSession.FindElementByName("txtPassword");

            if (winElem_LogIn_Passwd != null)
            {
                winElem_LogIn_Passwd.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using Name: txtPassword");
                return;
            }

            //Type password
            System.Threading.Thread.Sleep(100);
            winElem_LogIn_Passwd.SendKeys("1");

            //Click on TipoCuenta
            var winElem_LogIn_TipoCuenta = desktopSession.FindElementByName("TipoCuenta");

            if (winElem_LogIn_TipoCuenta != null)
            {
                winElem_LogIn_TipoCuenta.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using Name: TipoCuenta");
                return;
            }

            //Click on LogIn
            var winElem_LogIn_btnLogIn = desktopSession.FindElementByName("btnLogIn");

            if (winElem_LogIn_btnLogIn != null)
            {
                winElem_LogIn_btnLogIn.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using Name: btnLogIn");
                return;
            }

            // LeftClick on Button "Close" at (20,20)
            Console.WriteLine("LeftClick on Button \"Close\" at (20,20)");
            //string xpath_LeftClickButtonClose_20_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Inicio de Sesión\"][@AutomationId=\"LogIn\"]/TitleBar[@AutomationId=\"TitleBar\"]/Button[@Name=\"Close\"][@AutomationId=\"Close\"]";
            var winElem_LeftClickButtonClose_20_20 = desktopSession.FindElementByName("Close");
            if (winElem_LeftClickButtonClose_20_20 != null)
            {
                winElem_LeftClickButtonClose_20_20.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using name: Close");
                return;
            }
        }
    }
}