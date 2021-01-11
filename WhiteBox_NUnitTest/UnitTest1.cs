using NUnit.Framework;
using SIG_Tickets;
using System.Linq;
using System.Windows.Forms;

namespace WhiteBox_NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Form CrearTicket = new Form();
            SIGDataEntities DataEntity = new SIGDataEntities();

            CrearSolicitudes crearSolicitudes = new CrearSolicitudes();
            crearSolicitudes.CB_Categoria.SelectedIndex = crearSolicitudes.CB_Categoria.Items.Count - 1;
            crearSolicitudes.CB_Categoria.Text = crearSolicitudes.CB_Categoria.SelectedIndex.ToString();
            crearSolicitudes.txtTitulo.Text = "ESO";
            crearSolicitudes.txtDescripcion.Text = "CUALQUIER";

            crearSolicitudes.btnCrearTicket.PerformClick();

            if(DataEntity.Tickets.Where(s => s.tk_categoria == crearSolicitudes.CB_Categoria.Text && s.tk_asunto == crearSolicitudes.txtTitulo.Text) != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

            //ButtonTester buttonTester = new ButtonTester("ButtonName");



            //CrearTicket.Categoria.Text = "La categoria";
            //CrearTicket.Titulo.Text = "";

            Assert.Pass();
        }
    }
}