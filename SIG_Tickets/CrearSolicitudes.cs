using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG_Tickets
{
    public partial class CrearSolicitudes : Form
    {
        SIGDataEntities DataEntities;
        Cliente MiCliente;
        Tecnico MiTecnico;
        public CrearSolicitudes(Cliente cliente = null, Tecnico tecnico = null)
        {
            InitializeComponent();
            DataEntities = new SIGDataEntities();
            MiCliente = cliente;
            MiTecnico = tecnico;
        }

        private void btnCrearSolicitud_Click(object sender, EventArgs e)
        {
            DataEntities.Tickets.Add(
                new Ticket() {
                    tk_categoria = comboBox1.Text,
                    tk_asunto = textBox1.Text,
                    tk_descripción = textBox2.Text,
                    cli_id = MiCliente?.cli_id, //Si es un cliente agregalo, si no lo es, coloca null
                    tec_id = MiTecnico?.tec_id, //Si es un técnico agrégalo, si no lo es, coloca null
                    tk_fecha_creacion = DateTime.Now.Date.ToString()
                });
            DataEntities.SaveChanges();
            MessageBox.Show(this, "Su Ticket ha sido creado!", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
