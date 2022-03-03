using Dominio.Conectores;
using Dominio.EnviosSiesa;
using Infraestructura.CRUD;
using Infraestructura.Procesos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio.Recursos
{
    public class WebRequestPostDirecto:Configuraciones
    {
        ConectorVentasdeServicio _ConectorVentasdeServicio = new ConectorVentasdeServicio();
        ConectorTercerosClientes _ConectorTercerosClientes = new ConectorTercerosClientes();
        ConectorTercerosProveedor _ConectorTercerosProveedor = new ConectorTercerosProveedor();
        ConectorOrdenCompraInfluencer _ConectorOrdenCompraInfluencer = new ConectorOrdenCompraInfluencer();
        ConectorOrdenCompraLogistico _ConectorOrdenCompraLogistico = new ConectorOrdenCompraLogistico();


        BDConsultar _BdConsultar = new BDConsultar();
        Logs _Logs = new Logs();
        ActualizarLog _Alog = new ActualizarLog();
        public string  Token()
        {
            //SE GENERA EL TOKEN DE SEGURIDAD
            try
            {
                var client = new RestClient(accessTokenUriAnurotec);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("application/x-www-form-urlencoded", "grant_type=client_credentials&client_id=" + idAnurotec + "&client_secret=" + secretAnurotec, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                dynamic resp = JObject.Parse(response.Content);
                string token = resp.access_token;

                return token;
            }
            catch 
            {
               return "error en el proceso";

            }
        }

        //CONSUME EL SERVICIO 
       public void RequestEndPoint(string token, string endpoint)
        {
            Obtener();
            try
            {
                var client = new RestClient(endpoint);
                var request = new RestRequest(Method.GET);
                request.AddHeader("authorization", "Bearer " + token);
                request.AddHeader("cache-control", "no-cache");
                IRestResponse response = client.Execute(request);

                string respuesta = response.Content.ToString();



                if (endpoint.Equals(EndPointVentasdeServicio))
                {

                    _ConectorVentasdeServicio.conectorVentasdeServicio(respuesta);
                }
                else if (endpoint.Equals(EndPointTercerosProveedor))
                {

                    _ConectorTercerosProveedor.conectorTercerosProveedor(respuesta);
                }
                else if (endpoint.Equals(EndPointTercerosComercianteCliente))
                {

                    _ConectorTercerosClientes.conectorTercerosClientes(respuesta);
                }
                else if (endpoint.Equals(EndPointOrdenCompraInfluencer))
                {

                    _ConectorOrdenCompraInfluencer.conectorOrdenCompraInfluencer(respuesta);
                } else if (endpoint.Equals(EndPointOrdenCompraLogistico))
                {

                    _ConectorOrdenCompraLogistico.conectorOrdenCompraLogistico(respuesta);
                }

                


                //1 token
                //2 carga de terceros clientes y proveedor
                //3 carga de ordenes de servicio


            }
            catch(Exception ex)
            {
                MessageBox.Show("Sucedio un error al consumir el endpoint: "+ex.Message);
            }
        }


        public void RequestTercero(string token, string endpoint)
        {
            try
            {
                //var client = new RestClient(EndPointVentasdeServicio);
                var client = new RestClient(endpoint);
                var request = new RestRequest(Method.GET);
                request.AddHeader("authorization", "Bearer " + token);
                request.AddHeader("cache-control", "no-cache");
                IRestResponse response = client.Execute(request);

                string respuesta = response.Content.ToString();
                MessageBox.Show("Se consumio el servicio y se obtuvo el JSON: " + respuesta);


                try
                {
                    DataSet data = JsonConvert.DeserializeObject<DataSet>(respuesta);
                }
                catch
                {

                }

                _ConectorVentasdeServicio.conectorVentasdeServicio(respuesta);
                //_ConectorVentasdeServicio.conectorVentasdeServicio(respuesta);
                //if (endpoint.Equals(EndPointVentasdeServicio))
                //{
                //    _ConectorVentasdeServicio.conectorVentasdeServicio(respuesta);
                //}
                //else if(endpoint.Equals(EndPointTercerosProveedor) | endpoint.Equals(EndPointTercerosComercianteCliente))
                //{
                //    _ConectorTerceros.conectorTerceros(respuesta);
                //}
                //_ConectorTerceros.conectorTerceros(respuesta);


                //1 token
                //2 carga de terceros clientes y proveedor
                //3 carga de ordenes de servicio


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error al consumir el endpoint: " + ex.Message);
            }
        }
        public void RequestTerceros(string token2)
        {
            
        }
        
    }

    //preguntar a Wilson para que sirve el struct
    internal struct NewStruct
    {
        public string Item1;
        public string Item2;
        public object RequestBody;

        public NewStruct(string item1, string item2, object requestBody)
        {
            Item1 = item1;
            Item2 = item2;
            RequestBody = requestBody;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   Item1 == other.Item1 &&
                   Item2 == other.Item2 &&
                   EqualityComparer<object>.Default.Equals(RequestBody, other.RequestBody);
        }

        public override int GetHashCode()
        {
            int hashCode = 1891464663;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Item2);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(RequestBody);
            return hashCode;
        }

        public void Deconstruct(out string item1, out string item2, out object requestBody)
        {
            item1 = Item1;
            item2 = Item2;
            requestBody = RequestBody;
        }

        public static implicit operator (string, string, object RequestBody)(NewStruct value)
        {
            return (value.Item1, value.Item2, value.RequestBody);
        }

        public static implicit operator NewStruct((string, string, object RequestBody) value)
        {
            return new NewStruct(value.Item1, value.Item2, value.RequestBody);
        }
    }







}
