using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Infraestructura.Procesos
{
    public class Configuraciones : Tareas
    {
        public static StringBuilder Error = new StringBuilder();

        public static string ProgramaMigracion;
        public static int NumFilasMultiProcesos;
        public static int ProcesosParalelos;
        public static string RutaLog;
        public static string RutaPlanos;
        public static string ConexionWsSiesa;
        public static string CompaniaUnoEE;
        public static string UsuarioUnoEE;
        public static string ClaveUnoEE;
        public static bool Consumir_WSUNOEE;
        public static bool EnviarNotificaciones;
        public static string EnviarNotificacionesemail;
        public static string ServidorDeCorreo;
        public static string Puerto;
        public static bool RequiereAutenticacion;
        public static bool SSL;
        public static string CorreoRemitente;
        public static string UsuarioMail;
        public static string ClaveMail;
        public static string CorreosNotificaciones;
        public static bool AdjuntarArchivoCorreo;
        public static string ServidorFTP;
        public static string PuertoFTP;
        public static string UsuarioFTP;
        public static string ClaveFTP;
        public static string RutaFTP;
        public static string RutaArchivoLocal;
        public static string RutaArchivoExitoso;
        public static string RutaArchivoErrores;
        public static string RutaConsultas;
        public static string BaseDeDatos;
        public static bool ValidarXML;
        public static string Codificacion;


        public static string UsuarioApiFintra;
        public static string LoginneApiFintra;
        public static string UrlAultracemFintraTokem;
        public static string UrlAultracemFintraValidarApro;
        public static string UrlAultracemFintranotificaciondespacho;
        public static string RutaActualizarPedidos;
        public static string EjecutableAutomatizar;
        public static string ParametrosAutomatizar;
        public static string JsonTokens;


        public static string idAnurotec;
        public static string secretAnurotec;
        public static string accessTokenUriAnurotec;
        public string EndPointVentasdeServicio;
        public string EndPointTercerosProveedor;
        public string EndPointTercerosComercianteCliente;
        public string EndPointOrdenCompraInfluencer;
        public string EndPointOrdenCompraLogistico;
        public string EndPointOrdenServicioVentaInfluencer;

        public void Obtener()
        {
            DataSet DsConfiguraciones = QueryGT("sp_Propiedades_Select");
            
            //ProgramaMigracion = DsConfiguraciones.Tables[0].Rows[0]["valorEntero"].ToString();
            //NumFilasMultiProcesos = Convert.ToInt32(DsConfiguraciones.Tables[0].Rows[1]["valorEntero"]);
            //ProcesosParalelos = Convert.ToInt32(DsConfiguraciones.Tables[0].Rows[2]["valorEntero"]);
            //RutaLog = DsConfiguraciones.Tables[0].Rows[3]["valorTexto1"].ToString();
            RutaPlanos = DsConfiguraciones.Tables[0].Rows[4]["valorTexto1"].ToString();
            //ConexionWsSiesa = DsConfiguraciones.Tables[0].Rows[5]["valorTexto1"].ToString();
            //CompaniaUnoEE = DsConfiguraciones.Tables[0].Rows[6]["valorTexto1"].ToString();
            //UsuarioUnoEE = DsConfiguraciones.Tables[0].Rows[7]["valorTexto1"].ToString();
            //ClaveUnoEE = DsConfiguraciones.Tables[0].Rows[8]["valorTexto1"].ToString();
            //Consumir_WSUNOEE = Convert.ToBoolean(DsConfiguraciones.Tables[0].Rows[9]["valorBooleano"]);
            //EnviarNotificaciones = Convert.ToBoolean(DsConfiguraciones.Tables[0].Rows[10]["valorBooleano"]);
            //EnviarNotificacionesemail = DsConfiguraciones.Tables[0].Rows[10]["valorTexto1"].ToString();
            //ServidorDeCorreo = DsConfiguraciones.Tables[0].Rows[11]["valorTexto1"].ToString();
            //Puerto = DsConfiguraciones.Tables[0].Rows[12]["valorTexto1"].ToString();
            //RequiereAutenticacion = Convert.ToBoolean(DsConfiguraciones.Tables[0].Rows[13]["valorBooleano"]);
            //SSL = Convert.ToBoolean(DsConfiguraciones.Tables[0].Rows[14]["valorBooleano"]);
            //CorreoRemitente = DsConfiguraciones.Tables[0].Rows[15]["valorTexto1"].ToString();
            //UsuarioMail = DsConfiguraciones.Tables[0].Rows[16]["valorTexto1"].ToString();
            //ClaveMail = DsConfiguraciones.Tables[0].Rows[17]["valorTexto1"].ToString();
            //CorreosNotificaciones = DsConfiguraciones.Tables[0].Rows[18]["valorTexto1"].ToString();
            //AdjuntarArchivoCorreo = Convert.ToBoolean(DsConfiguraciones.Tables[0].Rows[19]["valorBooleano"]);
            //ServidorFTP = DsConfiguraciones.Tables[0].Rows[20]["valorTexto1"].ToString();
            //PuertoFTP = DsConfiguraciones.Tables[0].Rows[21]["valorTexto1"].ToString();
            //UsuarioFTP = DsConfiguraciones.Tables[0].Rows[22]["valorTexto1"].ToString();
            //ClaveFTP = DsConfiguraciones.Tables[0].Rows[23]["valorTexto1"].ToString();
            //RutaFTP = DsConfiguraciones.Tables[0].Rows[24]["valorTexto1"].ToString();
            //RutaArchivoLocal = DsConfiguraciones.Tables[0].Rows[25]["valorTexto1"].ToString();
            //RutaArchivoExitoso = DsConfiguraciones.Tables[0].Rows[26]["valorTexto1"].ToString();
            //RutaArchivoErrores = DsConfiguraciones.Tables[0].Rows[27]["valorTexto1"].ToString();
            //RutaConsultas = DsConfiguraciones.Tables[0].Rows[28]["valorTexto1"].ToString();
            //BaseDeDatos = DsConfiguraciones.Tables[0].Rows[29]["valorTexto1"].ToString();
            //ValidarXML = Convert.ToBoolean(DsConfiguraciones.Tables[0].Rows[30]["valorBooleano"]);
            //Codificacion = DsConfiguraciones.Tables[0].Rows[31]["valorTexto1"].ToString();
            //UsuarioApiFintra = DsConfiguraciones.Tables[0].Rows[43]["valorTexto1"].ToString();
            //LoginneApiFintra = DsConfiguraciones.Tables[0].Rows[44]["valorTexto1"].ToString();
            //UrlAultracemFintraTokem = DsConfiguraciones.Tables[0].Rows[45]["valorTexto1"].ToString();
            //UrlAultracemFintraValidarApro = DsConfiguraciones.Tables[0].Rows[46]["valorTexto1"].ToString();
            //UrlAultracemFintranotificaciondespacho = DsConfiguraciones.Tables[0].Rows[47]["valorTexto1"].ToString();
            //RutaActualizarPedidos = DsConfiguraciones.Tables[0].Rows[48]["valorTexto1"].ToString();
            //EjecutableAutomatizar = DsConfiguraciones.Tables[0].Rows[49]["valorTexto1"].ToString();
            //ParametrosAutomatizar = DsConfiguraciones.Tables[0].Rows[50]["valorTexto1"].ToString();
            
            idAnurotec = DsConfiguraciones.Tables[0].Rows[33]["valorTexto1"].ToString();
            

           
            secretAnurotec = DsConfiguraciones.Tables[0].Rows[34]["valorTexto1"].ToString();
           

            
            accessTokenUriAnurotec = DsConfiguraciones.Tables[0].Rows[32]["valorTexto1"].ToString();
            

            
            EndPointVentasdeServicio = DsConfiguraciones.Tables[0].Rows[35]["valorTexto1"].ToString();


            EndPointTercerosProveedor = DsConfiguraciones.Tables[0].Rows[36]["valorTexto1"].ToString();


            EndPointTercerosComercianteCliente = DsConfiguraciones.Tables[0].Rows[37]["valorTexto1"].ToString();


            EndPointOrdenCompraInfluencer = DsConfiguraciones.Tables[0].Rows[38]["valorTexto1"].ToString();


            EndPointOrdenCompraLogistico = DsConfiguraciones.Tables[0].Rows[39]["valorTexto1"].ToString();


            EndPointOrdenServicioVentaInfluencer = DsConfiguraciones.Tables[0].Rows[40]["valorTexto1"].ToString();

        }
    }
}
