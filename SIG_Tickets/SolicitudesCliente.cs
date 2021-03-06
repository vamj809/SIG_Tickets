﻿using System;
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
    public partial class SolicitudesCliente : Form
    {
        SIGDataEntities DataEntities;
        Cliente MiCliente;

        public SolicitudesCliente(Cliente _MiCliente)
        {
            if (_MiCliente == null) {
                MessageBox.Show("Acceso Inválido.");
                BtnCerrarSesion.PerformClick();
                return;
            }
            InitializeComponent();
            MiCliente = _MiCliente; 
            ClientNameLabel.Text = $"¡Bienvenido {MiCliente.cli_nombres}!                                 ";
            DataEntities = new SIGDataEntities();
            LoadRows();
        }

        private void LoadRows()
        {
            string tecnico;

            MyTable.Rows.Clear();
            List<Ticket> ListaTickets = DataEntities.Tickets.Where(s => s.cli_id == MiCliente.cli_id && s.tk_estado_ticket != "Cerrado").OrderBy(s => s.tk_estado_ticket).ToList();
            foreach (Ticket ticket in ListaTickets) {
                if (ticket.Tecnico == null)
                    tecnico = "Sin Asignar";
                else
                    tecnico = ticket.Tecnico?.tec_nombre + " " + ticket.Tecnico?.tec_apellido;
                
                MyTable.Rows.Add(ticket.tk_id_ticket, ticket.tk_asunto, ticket.tk_estado_ticket, tecnico);
            }
            MyTable.Refresh();
        }

        private void TimeStamp_Timer_Tick(object sender, EventArgs e)
        {
            TimeStampLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            new LogIn().Show();
        }

        private void btnCrearSolicitud_Click(object sender, EventArgs e)
        {
            new CrearSolicitudes(MiCliente).ShowDialog();
            LoadRows();
        }

        private void MyTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new EditarSolicitudes((int)MyTable.SelectedRows[0].Cells[0].Value, MiCliente).ShowDialog();
            LoadRows();
        }

        private void MyTable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                new EditarSolicitudes((int)MyTable.SelectedRows[0].Cells[0].Value, MiCliente).ShowDialog();
                LoadRows();
            }
        }

        private void SolicitudesCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
