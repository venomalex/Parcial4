using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
         static SqlDataAdapter adaptador = new SqlDataAdapter();
        static SqlConnection conectar = new SqlConnection();
        static SqlCommandBuilder generadorComando;
        static SqlCommand comando = new SqlCommand();

        private string ConsultasSql;
        private string cadena_conex="Data Source=.;Initial Catalog=hospital;Integrated Security=True";

        public void setConsultaSql(string Consulta)
        {
            ConsultasSql= Consulta;
        }
        public void InsertarDatos()
        {
            try
            {
                comando = new SqlCommand(ConsultasSql, conectar);
                comando.ExecuteNonQuery();
            }
            catch(System.IO.IOException ex)
            {
                Console.WriteLine("Error al ejecutar el insert");
                    Console.WriteLine(ex.Message);
            }
        }

        public bool Conectar()
        {
            bool estado = true;
            try
            {
                conectar.ConnectionString = cadena_conex;
                conectar.Open();
            }
            catch
            {
                estado = false;
                Console.WriteLine("Error al conectar con el servidor");

            }
            return estado;
        }
        public void desconectar()
        {
            conectar.Close();
        }

    }


    public class Conexion
    {
    }
}
    
