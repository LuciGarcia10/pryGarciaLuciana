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
using System.Windows.Forms.DataVisualization.Charting;

namespace pryGarciaLuciana
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
            // Cadena de conexión a tu base de datos Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Garcia.accdb";
            connection = new OleDbConnection(connectionString);
        }
        private OleDbConnection connection;
        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Consulta Actividades por mes
                string query1 = "SELECT Mes, COUNT(*) AS Cantidad FROM TuTabla WHERE ... GROUP BY Mes";

                // Consulta Actividades por categoría de usuario
                string query2 = "SELECT CategoriaUsuario, COUNT(*) AS Cantidad FROM TuTabla WHERE ... GROUP BY CategoriaUsuario";

                // Llenar dataset
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query1, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    chart1.DataSource = ds.Tables[0];
                  
                }

                // Llenar el dataset para el segundo gráfico
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query2, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    chart2.DataSource = ds.Tables[1];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los gráficos: " + ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
