using System.Data;
using System.Data.SqlClient;

namespace Actividad_3_CRUD.Clases
{
    public class ConexionBD
    {
        private static readonly string cadenaConexion =
            @"Server=DESKTOP-TEAMCLK\MSSQLSERVER01;Database=ZapateriaUMI;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public static DataTable EjecutarConsulta(string consulta, params SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(consulta, con))
            {
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public static int EjecutarComando(string comandoSql, params SqlParameter[] parametros)
        {
            using (SqlConnection con = ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(comandoSql, con))
            {
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}