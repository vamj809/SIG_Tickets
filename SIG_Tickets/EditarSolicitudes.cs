using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG_Tickets
{
    public partial class EditarSolicitudes : Form
    {
        SIGDataEntities DataEntities;
        Cliente MiCliente;
        Tecnico MiTecnico;
        Ticket MiTicket;
        public EditarSolicitudes(int IdTicket, Cliente cliente = null, Tecnico tecnico = null)
        {
            DataEntities = new SIGDataEntities();
            DataEntities.Tickets.Load();
            MiTicket = DataEntities.Tickets.Where(s => s.tk_id_ticket == IdTicket).FirstOrDefault();
            if (MiTicket == null) {
                MessageBox.Show("Acceso Inválido.");
                BtnCancelar.PerformClick();
                return;
            }
            InitializeComponent();
            MiCliente = cliente;
            MiTecnico = tecnico;
            //////////////////////////// Carga Data
            CbCategoria.Text = MiTicket.tk_categoria;
            TxtTitulo.Text = MiTicket.tk_asunto;
            TxtDescripcion.Text = MiTicket.tk_descripción;
            TxtFechaCreacion.Text = MiTicket.tk_fecha_creacion;
            CbEstado.Text = MiTicket.tk_estado_ticket;
            // Pon la tabla. gracias. bye
        }

        private void btnEditarSolicitud_Click(object sender, EventArgs e)
        {
            //Revisa que se ha agregado un comentario.
            if (txtComentario.TextLength == 0) {
                txtComentario.Focus();
                return;
            }

            //Verifica si es el cliente o el tecnico que agrega el mensaje.
            string TipoUsuario;
            if (MiCliente == null)
                TipoUsuario = "Cliente";
            else
                TipoUsuario = "Técnico";

            //Prepara los datos para guardarlos en la BD
            MiTicket.tk_categoria = CbCategoria.Text;
            MiTicket.tk_estado_ticket = CbEstado.Text;
            MiTicket.DetallesTickets.Add(new DetallesTicket() {
                dt_titulo = TipoUsuario,
                dt_comentario = txtComentario.Text
            });
            
            //Guarda los datos y cierra la pantalla.
            DataEntities.SaveChanges();
            BtnCancelar.PerformClick();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DataEntities.Dispose();
            Close();
        }
    }
}
