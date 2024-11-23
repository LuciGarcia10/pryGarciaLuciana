using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarciaLuciana
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private OleDbConnection connection;
       


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Garcia.accdb";
            connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
                lblEstadoConexion.Text = "Conectado";
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = "Desconectado";
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();    
            frmReportes.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUusarios frmUsuarios = new FrmUusarios();
            frmUsuarios.ShowDialog();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActividades frmActividades = new FrmActividades();
            frmActividades.ShowDialog();
        }
    }
}
