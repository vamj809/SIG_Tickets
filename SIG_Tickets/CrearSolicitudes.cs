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

        private int IsTicketValid()
        {
            if (string.IsNullOrWhiteSpace(CB_Categoria.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
                return -1;
            if (CB_Categoria.SelectedIndex == -1)
                return -2;
            if (txtTitulo.Text.Length > 255)
                return -3;
            if (txtDescripcion.Text.Length > 255)
                return -4;
            return 0;
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            //Valida el ticket.
            int TicketValidationStatus = IsTicketValid();
            if (TicketValidationStatus < 0)
            {
                if (TicketValidationStatus == -1)
                    MessageBox.Show("Debe llenar todos los campos con algún valor","Ticket Inválido",MessageBoxButtons.OK);
                else if (TicketValidationStatus == -2) { 
                    MessageBox.Show("Debe seleccionar una categoria de la lista", "Ticket Inválido", MessageBoxButtons.OK); 
                    CB_Categoria.Focus(); }
                else if (TicketValidationStatus == -3) { 
                    MessageBox.Show("Debe resumir un poco el título. Está demasiado largo.", "Ticket Inválido", MessageBoxButtons.OK); 
                    txtTitulo.Focus(); }
                else if (TicketValidationStatus == -3) { 
                    MessageBox.Show("Debe resumir un poco la descripción. Está demasiado larga.", "Ticket Inválido", MessageBoxButtons.OK); 
                    txtDescripcion.Focus(); }
                
                return;
            }
            DataEntities.Tickets.Add(
                new Ticket()
                {
                    tk_categoria = CB_Categoria.Text,
                    tk_asunto = txtTitulo.Text,
                    tk_descripción = txtDescripcion.Text,
                    cli_id = MiCliente?.cli_id, //Si es un cliente agregalo, si no lo es, coloca null
                    tec_id = MiTecnico?.tec_id, //Si es un técnico agrégalo, si no lo es, coloca null
                    tk_fecha_creacion = DateTime.Now.ToString(),
                    tk_estado_ticket = "Abierto"
                });
            DataEntities.SaveChanges();
            MessageBox.Show(this, "Su Ticket ha sido creado!", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtnCancelarTicket_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CB_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
