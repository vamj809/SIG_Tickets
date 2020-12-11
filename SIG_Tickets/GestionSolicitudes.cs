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
        }

        private void TimeStamp_Timer_Tick(object sender, EventArgs e)
        {
            TimeStampLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnEditarSolicitud_Click(object sender, EventArgs e)
        {
            //MyTable.SelectedRows[0].Cells["tk_id_ticket"].Value;
            new EditarSolicitudes().ShowDialog();
        }

        private void BtnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Hide();
            new LogIn().Show();
        }
    }
}
