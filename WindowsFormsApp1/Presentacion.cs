﻿using Dominio.Recursos;
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

