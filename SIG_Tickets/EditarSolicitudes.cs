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
            Text = Text + " #" + IdTicket; // Ajustar título del Form con #Ticket
            CbCategoria.Text = MiTicket.tk_categoria;
            TxtTitulo.Text = MiTicket.tk_asunto;
            TxtDescripcion.Text = MiTicket.tk_descripción;
            TxtFechaCreacion.Text = MiTicket.tk_fecha_creacion;
            TxtSolicitante.Text = MiTicket.Cliente?.cli_nombres + " " + MiTicket.Cliente?.cli_apellidos;
            if (MiTicket.tk_estado_ticket == null)
                CbEstado.Text = "Abierto";
            else
                CbEstado.Text = MiTicket.tk_estado_ticket;
            /////////////////////////// Carga el listado de Comentarios
            msgDataGrid.Rows.Clear();
            List<DetallesTicket> ListaDetalleTickets = 
                DataEntities.DetallesTickets.Where(s => s.tk_id_ticket == MiTicket.tk_id_ticket).ToList();
            foreach (DetallesTicket detallesTicket in ListaDetalleTickets) {
                msgDataGrid.Rows.Add(detallesTicket.dt_titulo, detallesTicket.dt_comentario);
            }
            msgDataGrid.Refresh();
            ////////////////////////// Change Permissions
            if(MiTecnico == null) {
                CbEstado.Enabled = false;
            }
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
            if (MiCliente == null) {
                TipoUsuario = "Técnico";
                MiTicket.tec_id = MiTecnico.tec_id; //Actualiza el técnico asignado como el que está modificando la solicitud.
            }
            else
                TipoUsuario = "Cliente";

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
            Close();
        }
    }
}
