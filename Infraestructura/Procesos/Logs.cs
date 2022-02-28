using Infraestructura.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Infraestructura.Procesos
{
    public class Logs:Tareas
    {
        public static int idLogPrincipal;
        public static int idLog;

        public void LogPrincipalAlmacenar()
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            SqlCommand _SqlCommand = new SqlCommand();
            SqlParameter sqlParametro = new SqlParameter();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = "sp_LogPrincipalAlmacenar";
            _SqlCommand.CommandTimeout = 999999999;

            _SqlCommand.Parameters.AddWithValue("idTarea", idTarea);
            sqlParametro.ParameterName = "idLogPrincipal";
            sqlParametro.Direction = ParameterDirection.InputOutput;
            sqlParametro.Value = 0;
            _SqlCommand.Parameters.Add(sqlParametro);

            try
            {
                _SqlConnection.Open();
                _SqlCommand.ExecuteNonQuery();
                idLogPrincipal = Convert.ToInt32(_SqlCommand.Parameters["idLogPrincipal"].Value);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                _SqlCommand.Connection.Close();
            }
        }

        public void LogInicio()
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            SqlCommand _SqlCommand = new SqlCommand();
            SqlParameter sqlParametro = new SqlParameter();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = "sp_LogInicio";
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("IdLogPrincipal", idLogPrincipal);
            _SqlCommand.Parameters.AddWithValue("idTarea", idTarea);
            _SqlCommand.Parameters.AddWithValue("idProceso", 1);


            sqlParametro.ParameterName = "IdLog";
            sqlParametro.Direction = ParameterDirection.InputOutput;
            sqlParametro.Value = 0;
            _SqlCommand.Parameters.Add(sqlParametro);

            try
            {
                _SqlConnection.Open();
                _SqlCommand.ExecuteNonQuery();
                idLog = Convert.ToInt32(_SqlCommand.Parameters["IdLog"].Value);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                _SqlConnection.Close();
            }

        }

        public void ActualizarLog(string Variable, string Resultado, int Opcion, string Error)
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            SqlCommand _SqlCommand = new SqlCommand();
            _SqlCommand.CommandType = CommandType.Text;
            _SqlCommand.Connection = _SqlConnection;

            string MensajeError = Error.ToString() == string.Empty ? "''" : "'" + Error.Replace("'", "") + "'";

            string Query = "UPDATE TareaLog SET " + Variable + " = " + Resultado + ", " +
                           "EjecucionCompleta = " + Opcion + ", " +
                           "MensajesError = " + MensajeError + " WHERE idLog = " + idLog;

            _SqlCommand.CommandText = (Query);

            try
            {
                _SqlConnection.Open();
                _SqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }
    }
}
