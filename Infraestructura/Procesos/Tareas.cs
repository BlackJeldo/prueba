using Infraestructura.CRUD;
using System;
using System.Data;
using System.Windows.Forms;

namespace Infraestructura.Procesos
{
    public class Tareas:BDConsultar
    {
        public static int idTarea;
        public static int idDocumento;
        public static string Nombre;
        public static string CadenaConexion;
        public static string RutaGeneracionPlano;
        public static bool InvocarWebService;
        public static bool EnviarNotificaciones;
        public static string Destinatarios;
        public static string NombreConexionWsSiesa;
        public static string CiaWsSiesa;
        public static string UsuarioWsSiesa;
        public static string ClaveWsSiesa;

        public DataSet Obtener(int IdTarea)
        {

            DataSet DsTareas = QueryValueGT("sp_TareaSeleccionar", IdTarea);

            if (DsTareas.Tables[0].Rows.Count > 0)
            {
                idTarea = (int)DsTareas.Tables[0].Rows[0]["idTarea"];
                idDocumento = (int)DsTareas.Tables[0].Rows[0]["idDocumento"];
                Nombre = DsTareas.Tables[0].Rows[0]["Nombre"].ToString();
                CadenaConexion = DsTareas.Tables[0].Rows[0]["CadenaConexion"].ToString();
                RutaGeneracionPlano = DsTareas.Tables[0].Rows[0]["RutaGeneracionPlano"].ToString();
                InvocarWebService = (bool)DsTareas.Tables[0].Rows[0]["InvocarWebService"];
                EnviarNotificaciones = (bool)DsTareas.Tables[0].Rows[0]["EnviarNotificaciones"];
                Destinatarios = DsTareas.Tables[0].Rows[0]["Destinatarios"].ToString();
                NombreConexionWsSiesa = DsTareas.Tables[0].Rows[0]["NombreConexionWsSiesa"].ToString();
                CiaWsSiesa = DsTareas.Tables[0].Rows[0]["CiaWsSiesa"].ToString();
                UsuarioWsSiesa = DsTareas.Tables[0].Rows[0]["UsuarioWsSiesa"].ToString();
                ClaveWsSiesa = DsTareas.Tables[0].Rows[0]["ClaveWsSiesa"].ToString();
            }

            return DatosOrigen(DsTareas);
        }

        public DataSet DatosOrigen(DataSet DsTareas)
        {

            Logs _Logs = new Logs();

            try
            {
                DataSet DsQuery = new DataSet();
                int i = 0;
                foreach (DataRow Registro in DsTareas.Tables[1].Rows)
                {
                    DataSet DsTmp = new DataSet();
                    DsTmp = Execute(CadenaConexion, Registro["Query"].ToString());
                    DsTmp.Tables[0].TableName = Registro["Descripcion"].ToString();
                    DsQuery.Tables.Add(DsTmp.Tables[0].Copy());
                    if (i == 0)
                    {
                        _Logs.LogPrincipalAlmacenar();

                        _Logs.LogInicio();
                        _Logs.ActualizarLog("FechaInicioRecuperacionDatosOrigen", "GETDATE()", 0, string.Empty);

                        _Logs.ActualizarLog("FechaFinRecuperacionDatosOrigen", "GETDATE()", 0, string.Empty);
                        _Logs.ActualizarLog("RecuperacionDatosOrigen", "1", 0, string.Empty);
                    }
                }

                return DsQuery;
            }
            catch (Exception Ex)
            {
                _Logs.ActualizarLog("FechaFinRecuperacionDatosOrigen", "GETDATE()", 0, Ex.Message.ToString());
                _Logs.ActualizarLog("RecuperacionDatosOrigen", "0", 0, Ex.Message.ToString());

                throw Ex;
            }
        }

    }
}
