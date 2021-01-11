using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIG_Tickets;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form CrearTicket = new Form();
            SIGDataEntities DataEntity = new SIGDataEntities();
            bool isTrue = true;

            CrearSolicitudes crearSolicitudes = new CrearSolicitudes();
            crearSolicitudes.CB_Categoria.SelectedIndex = crearSolicitudes.CB_Categoria.Items.Count - 1;
            crearSolicitudes.CB_Categoria.Text = crearSolicitudes.CB_Categoria.SelectedIndex.ToString();
            crearSolicitudes.txtTitulo.Text = "ESO";
            crearSolicitudes.txtDescripcion.Text = "CUALQUIER";

            crearSolicitudes.btnCrearTicket.PerformClick();

            if (DataEntity.Tickets.Where(s => s.tk_categoria == crearSolicitudes.CB_Categoria.Text && s.tk_asunto == crearSolicitudes.txtTitulo.Text) != null)
            {
                isTrue = true;
                Assert.IsTrue(isTrue);
            }
            else
            { 
                Assert.Fail();
            }
        }
    }
}
