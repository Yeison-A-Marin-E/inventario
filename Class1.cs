using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;


/* static void connect()
 {
 string connectionString = "Server=127.0.0.1;Port=3306;Database=usuario;Uid=root;password=test;";
 MySqlConnection conexion = new MySqlConnection(connectionString);



         conexion.Dispose();
     }

 static void Main(string[] args)
 {
     connect();
 }*/
namespace inventario
{
    public class Class1
    {

        #region Variables Privadas
        private MySqlConnection _connection;
        private MySqlDataAdapter _objdataAdapter;
        private MySqlCommand _objSqlcommand;
        private DataSet _dsResultados;
        private DataTable _dtparametros;
        private string nombretabla, nombresp, mensajerrordb, valorScalar, nombredb, stringconnection;
        private bool scalar;


        public MySqlConnection Connection { get => _connection; set => _connection = value; }
        public MySqlDataAdapter ObjdataAdapter { get => _objdataAdapter; set => _objdataAdapter = value; }
        public MySqlCommand ObjSqlcommand { get => _objSqlcommand; set => _objSqlcommand = value; }
        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable Dtparametros { get => _dtparametros; set => _dtparametros = value; }
        public string Nombretabla { get => nombretabla; set => nombretabla = value; }
        public string Nombresp { get => nombresp; set => nombresp = value; }
        public string Mensajerrordb { get => mensajerrordb; set => mensajerrordb = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public string Nombredb { get => nombredb; set => nombredb = value; }
        public string Stringconnection { get => stringconnection; set => stringconnection = value; }
        public bool Scalar { get => scalar; set => scalar = value; }

        #region variable publicas

        private void conexion(ref Class1 ObjMySql)
        {

            MySqlConnectionStringBuilder ObjMySqlConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = ObjMySql.Nombredb,
                UserID = "root",
                Password = ""
            };
            ObjMySql.Stringconnection = ObjMySqlConnectionStringBuilder.ConnectionString;
        
        }

        private void CrearConexionBaseDatos(ref Class1 ObjMySql)
        {
            conexion(ref ObjMySql);
                ObjMySql.Connection = new MySqlConnection(ObjMySql.Stringconnection); 

        }

    
    } 

    
}