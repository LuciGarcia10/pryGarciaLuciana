using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryGarciaLuciana
{
    public partial class FrmActividades : Form
    {
        public FrmActividades()
        {
            InitializeComponent();
            
        }

        private void FrmActividades_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
             if (dtpFechaInicio.Value > dtpFechaFin.Value)
             {
                MessageBox.Show("La fecha de inicio debe ser menor o igual a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
               return;
             }
                MessageBox.Show("Consulta realizada correctamente.");
           
        }
    }
}
