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
    public partial class GestionSolicitudes : Form
    {
        SIGDataEntities DataEntities;
        Tecnico MiTecnico;
        public GestionSolicitudes(Tecnico _MiTecnico)
        {
            if (_MiTecnico == null) {
                MessageBox.Show("Acceso Inválido.");
                BtnCerrarSesion.PerformClick();
                return;
            }
            InitializeComponent();
            MiTecnico = _MiTecnico;
            AgentNameLabel.Text = $"¡Bienvenido {MiTecnico.tec_nombre}!";
            DataEntities = new SIGDataEntities(); 
            LoadRows();
        }
        private void LoadRows()
        {
            DataEntities = new SIGDataEntities();
            MyTable.Rows.Clear();
            List<Ticket> ListaTickets = DataEntities.Tickets.OrderBy(s => s.tk_estado_ticket).ToList();
            foreach (Ticket ticket in ListaTickets) {
                MyTable.Rows.Add(ticket.tk_id_ticket, ticket.tk_asunto, ticket.tk_estado_ticket, ticket.Tecnico?.tec_nombre + " " + ticket.Tecnico?.tec_apellido);
            }
            MyTable.Refresh();
        }

        private void TimeStamp_Timer_Tick(object sender, EventArgs e)
        {
            TimeStampLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnEditarSolicitud_Click(object sender, EventArgs e)
        {
            new EditarSolicitudes((int)MyTable.SelectedRows[0].Cells[0].Value, null, MiTecnico).ShowDialog();
            LoadRows();
        }

        private void BtnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Hide();
            new LogIn().Show();
        }

        private void MyTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new EditarSolicitudes((int)MyTable.SelectedRows[0].Cells[0].Value, null, MiTecnico).ShowDialog();
            LoadRows();
        }

        private void MyTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new EditarSolicitudes((int)MyTable.SelectedRows[0].Cells[0].Value, null, MiTecnico).ShowDialog();
                LoadRows();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
