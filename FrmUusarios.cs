using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarciaLuciana
{
    public partial class FrmUusarios : Form
    {
        public FrmUusarios()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Garcia.accdb";
            connection = new OleDbConnection(connectionString);
            CargarTreeView();
        }

        private OleDbConnection connection;

        private void CargarTreeView()
        {
            try
            {
                // Consulta SQL (ejemplo)
                string query = "SELECT Categoria, Usuario FROM Garcia.accdb";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Crear nodos en el TreeView
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string ID_Categoria = row["ID_Categoria"].ToString();
                        string Nombre_Ctaegoris = row["Nombre_Categoria"].ToString();

                        // Buscar el nodo de la categoría
                        TreeNode nodoCategoria = treeView1.Nodes.Find(ID_Categoria, true)[0];
                        if (nodoCategoria == null)
                        {
                            nodoCategoria = treeView1.Nodes.Add(ID_Categoria);
                        }

                        // Agregar el usuario como nodo 
                        nodoCategoria.Nodes.Add(Nombre_Ctaegoris);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }



        private void FrmUusarios_Load(object sender, EventArgs e)
        {

        }

       

        private void treeView1_NodeMouseclick(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1) // Si se hace clic en un nodo de usuario
            {
                string usuarioSeleccionado = e.Node.Text;

                // Consulta para obtener los detalles del usuario
                string query = "SELECT * FROM TuTabla WHERE Usuario = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbParameter parameter = new OleDbParameter("@Nombre_Categoria", usuarioSeleccionado);
                    command.Parameters.Add(parameter);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        lstDatosUusario.Items.Clear();
                        while (reader.Read())
                        {
                            // Agregar datos del usuario al ListBox
                            lstDatosUusario.Items.Add("ID_Categoria: " + reader["ID_Categoria"]);
                            lstDatosUusario.Items.Add("Nombre_Categoria: " + reader["Nombre_Categoria"]);
                            
                        }
                    }
                }
            }
        }

    }
}
