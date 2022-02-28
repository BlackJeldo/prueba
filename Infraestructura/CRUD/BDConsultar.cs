using Infraestructura.Procesos;
using Infraestructura.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Infraestructura.CRUD
{
    public class BDConsultar
    {
        public string CadenaConexion { get; private set; }

        public void QueryIngresarRespuestasSolicitudes(string NombreProcedimiento, string @numeroPedidoq, string @dataestado, string @datadescripcion, string @dataurl, string @datacus, string @datanumeroCuenta, string @status, string @msg, string @Jsonrespuesta)
        {

            SqlConnection _SqlConnection = new SqlConnection(Tareas.CadenaConexion);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@numeroPedidoq", @numeroPedidoq);
            _SqlCommand.Parameters.AddWithValue("@dataestado", @dataestado);
            _SqlCommand.Parameters.AddWithValue("@datadescripcion ", @datadescripcion);
            _SqlCommand.Parameters.AddWithValue("@dataurl", @dataurl);
            _SqlCommand.Parameters.AddWithValue("@datacus", @datacus);
            _SqlCommand.Parameters.AddWithValue("@datanumeroCuenta", @datanumeroCuenta);
            _SqlCommand.Parameters.AddWithValue("@status ", @status);
            _SqlCommand.Parameters.AddWithValue("@msg", @msg);
            _SqlCommand.Parameters.AddWithValue("@Jsonrespuesta", @Jsonrespuesta);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();

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
        public void QueryValueGTEnvio(string NombreProcedimiento, string @Archivo, string @Linea)
        {

            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@Archivo", @Archivo);
            _SqlCommand.Parameters.AddWithValue("@Linea", @Linea);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();

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
        public void QueryActualizarestado(string NombreProcedimiento, string @valor, int @IdTarea)
        {

            SqlConnection _SqlConnection = new SqlConnection(Tareas.CadenaConexion);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@valor", @valor);
            _SqlCommand.Parameters.AddWithValue("@IdTarea", @IdTarea);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();

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
        public DataSet QueryParametros(string NombreProcedimiento, string @orden, int @Consecutivo)
        {

            SqlConnection _SqlConnection = new SqlConnection(Tareas.CadenaConexion);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@orden", @orden);
            _SqlCommand.Parameters.AddWithValue("@Consecutivo", @Consecutivo);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
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
        public DataSet QueryGT(string NombreProcedimiento)
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                // _SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
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
        public DataSet QueryGTN(string NombreProcedimiento)
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();
                return DsGenerico;
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
        public DataSet QueryValueGT(string NombreProcedimiento, int idTarea)
        {

            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("idTarea", idTarea);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                //_SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
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
        public DataSet QueryValueGTcONCE(string NombreProcedimiento, string documento)
        {

            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@documento", documento);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                // _SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
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
        public DataSet QueryValueGTDias(string NombreProcedimiento, string documento, int dias)
        {

            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@documento", documento);
            _SqlCommand.Parameters.AddWithValue("@dias", dias);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                // _SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
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
        public DataSet QueryValueGTConsulta(string NombreProcedimiento, string ARTPRO, string documento, string F_CIA)
        {

            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@ARTPRO", ARTPRO);
            _SqlCommand.Parameters.AddWithValue("@documento", documento);
            _SqlCommand.Parameters.AddWithValue("@F_CIA", F_CIA);
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                // _SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
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
        public void sp_ut_ActualizarEstadoConectores(string @documento, int idTarea, string @xmlEnv, string @xmlsiesa)
        {
            Tareas _Tareas = new Tareas();
            SqlConnection _SqlConnection = new SqlConnection(Tareas.CadenaConexion);
            SqlCommand _SqlCommand = new SqlCommand();
            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = "sp_ut_ActualizarEstadoConectores";
            _SqlCommand.CommandTimeout = 999999999;
            _SqlCommand.Parameters.AddWithValue("@documento", @documento);
            _SqlCommand.Parameters.AddWithValue("@tarea", idTarea);
            _SqlCommand.Parameters.AddWithValue("@xmlEnv", @xmlEnv);
            _SqlCommand.Parameters.AddWithValue("@xmlsiesa", @xmlsiesa);

            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();
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
        public void sp_ut_Actualizarlogdespacho(string @pedido, string @factura, string @jsonEnvio, string @dataconfirmacion, string @dataresultado, string @status, string @msg)
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            SqlCommand _SqlCommand = new SqlCommand();
            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = "sp_Ut_IngresarRespuestasDespacho";
            _SqlCommand.CommandTimeout = 999999999;

            _SqlCommand.Parameters.AddWithValue("@pedido ", @pedido);
            _SqlCommand.Parameters.AddWithValue("@factura ", @factura);
            _SqlCommand.Parameters.AddWithValue("@jsonEnvio ", @jsonEnvio);
            _SqlCommand.Parameters.AddWithValue("@dataconfirmacion,", @dataconfirmacion);
            _SqlCommand.Parameters.AddWithValue("@dataresultado ", @dataresultado);
            _SqlCommand.Parameters.AddWithValue("@statu", @status);
            _SqlCommand.Parameters.AddWithValue("@msg", @msg);


            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();
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








        public void sp_ut_ActualizarEstado(string valor, int idTarea, int Docenvio)
        {
            SqlConnection _SqlConnection = new SqlConnection(Settings.Default.ConexionGT);
            SqlCommand _SqlCommand = new SqlCommand();
            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = "sp_IM_ActualizarEstado";
            _SqlCommand.CommandTimeout = 999999999;

            _SqlCommand.Parameters.AddWithValue("@valor", valor);
            _SqlCommand.Parameters.AddWithValue("@IdTarea", idTarea);
            _SqlCommand.Parameters.AddWithValue("@Docenvio", Docenvio);

            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.ExecuteNonQuery();
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
        public DataSet Execute(string Conexion, string Query)
        {
            SqlConnection _SqlConnection = new SqlConnection(Conexion);
            DataSet DsGenerico = new DataSet();
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.Text;
            _SqlCommand.CommandText = Query;
            _SqlCommand.CommandTimeout = 999999999;

            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                //_SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter.Fill(DsGenerico);


                //MessageBox.Show(DsGenerico.Tables[0].Rows.Count.ToString());
                return DsGenerico;
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
    }
}
