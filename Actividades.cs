using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryGarciaLuciana
{
    public class Actividades
    {

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaDeConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Garcia.accdb";
        private string tabla;


        public string Mes { get; set; }
        public int Cantidad { get; set; }
        public string CategoriaUsuario { get; set; }
    }
}
