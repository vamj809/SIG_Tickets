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
    public partial class LogIn : Form
    {
        SIGDataEntities DataEntities;
        Tecnico UsuarioTec;
        Cliente UsuarioCli;

        public LogIn()
        {
            InitializeComponent();
            txtUserName.Focus();
            DataEntities = new SIGDataEntities();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // if Es Tecnico
            if (TipoCuenta.Checked) {
                UsuarioTec = DataEntities.Tecnicos.Where(s => s.tec_usuario == txtUserName.Text).FirstOrDefault();
                if (UsuarioTec != null) {
                    //LogIn Correcto
                    MessageBox.Show($"Técnico:  {UsuarioTec.tec_apellido}, {UsuarioTec.tec_nombre}");
                    
                    Hide();
                    new GestionSolicitudes(UsuarioTec).Show();
                } else {
                    //LogIn Incorrecto
                    MessageBox.Show("Técnico No Encontrado");
                }
            }
            else { 
                UsuarioCli = DataEntities.Clientes.Where(s => s.cli_usuario == txtUserName.Text).FirstOrDefault();
                if (UsuarioCli != null) {
                    //LogIn Correcto
                    MessageBox.Show($"Cliente:  {UsuarioCli.cli_apellidos}, {UsuarioCli.cli_nombres}");

                    Hide();
                    new SolicitudesCliente(DataEntities, UsuarioCli).Show();
                } else {
                    //LogIn Incorrecto
                    MessageBox.Show("Cliente No Encontrado");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TipoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            //Checked = Técnico | Unchecked = Cliente
            if (TipoCuenta.CheckState == CheckState.Checked)
                TipoCuenta.Text = "Técnico";
            else
                TipoCuenta.Text = "Cliente";
        }
    }
}
