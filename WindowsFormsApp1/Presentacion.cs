using Dominio.Recursos;
using Infraestructura.Procesos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Procesos;

namespace WindowsFormsApp1
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        public string endpoint;
      
        private void Presentacion_Load_1(object sender, EventArgs e)
        {
            ActualizarLog _Alog = new ActualizarLog();
            Infraestructura.Procesos.Configuraciones _Configuraciones = new Infraestructura.Procesos.Configuraciones();
            Infraestructura.Procesos.Tareas _Tareas = new Infraestructura.Procesos.Tareas();
            WebRequestPostDirecto _WebRequestPostDirecto = new WebRequestPostDirecto();
            
               

            var argumento = Environment.GetCommandLineArgs();
          

            try
                {

                    _Configuraciones.Obtener();

                DataSet DsOrigen = _Tareas.Obtener(Convert.ToInt32((argumento[1])));


                switch (argumento[1])
                {
                    case "1":
                        string token = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.EndPointVentasdeServicio;
                        _WebRequestPostDirecto.RequestEndPoint(token,endpoint);
                        break;

                    case "2":
                        string token2 = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.EndPointTercerosProveedor;
                        _WebRequestPostDirecto.RequestEndPoint(token2,endpoint);

                        break;
                    case "3":
                        string token3 = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.EndPointTercerosComercianteCliente;
                        _WebRequestPostDirecto.RequestEndPoint(token3, endpoint);
                        break;
                    case "4":
                        string token4 = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.EndPointOrdenCompraInfluencer;
                        _WebRequestPostDirecto.RequestEndPoint(token4,endpoint);
                        break;

                    case "5":
                        string token5 = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.EndPointOrdenCompraLogistico;
                        _WebRequestPostDirecto.RequestEndPoint(token5,endpoint);
                        break;

                    case "6":
                        break;
                        string token6 = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.EndPointOrdenServicioVentaInfluencer;
                        _WebRequestPostDirecto.RequestEndPoint(token6,endpoint);

                    case "7":
                        string token7 = _WebRequestPostDirecto.Token();
                        endpoint = _Configuraciones.
                        break;

                    default:
                        MessageBox.Show("El argumento enviado no fue valido");
                        break;
                }

                Application.Exit();
                //}
            }
            catch (Exception Ex)
                {
                MessageBox.Show("Error: "+Ex.Message);
                    _Alog.ValidarErrorMov(Ex.Message, 0);
                    Application.Exit();
                }
        }
    }
}

