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
    public partial class EditarSolicitudes : Form
    {
        SIGDataEntities DataEntities;
        Cliente MiCliente;
        Tecnico MiTecnico;
        public EditarSolicitudes(Cliente cliente = null, Tecnico tecnico = null)
        {
            InitializeComponent();
            DataEntities = new SIGDataEntities();
            MiCliente = cliente;
            MiTecnico = tecnico;
        }
    }
}
