using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Infraestructura.Procesos;

namespace Dominio.Conectores
{
    public class ConectorVentasdeServicio:Configuraciones
    {
        public void conectorVentasdeServicio(string json)
        {
            try
            {
               
                dynamic jsonT = JsonConvert.DeserializeObject<dynamic>(json);

                DataTable _d2 = new DataTable();
                //DataTable _d3 = new DataTable();


                _d2.TableName = "OrdenVentaServicios";
                _d2.Columns.Add("NombreSeccion");
                _d2.Columns.Add("f310IdTipoDocto");
                _d2.Columns.Add("f310ConsecDocto");
                _d2.Columns.Add("f310Fecha");
                _d2.Columns.Add("f310IdTercero");
                _d2.Columns.Add("f310IdSucursalCli");
                _d2.Columns.Add("f310IdTerceroVendedor");
                _d2.Columns.Add("f310Referencia");
                _d2.Columns.Add("f310IdCondPago");
                _d2.Columns.Add("f310IdTipoCli");
                _d2.Columns.Add("f310IdMonedaDocto");
                _d2.Columns.Add("f310IndTasa");
                _d2.Columns.Add("f310IdMonedaConv");
                _d2.Columns.Add("f310TasaConv");
                _d2.Columns.Add("f310IdMonedaLocal");
                _d2.Columns.Add("f310TasaLocal");
                _d2.Columns.Add("f310Notas");
                _d2.Columns.Add("f310NumeroOrdenCompra");
                // _d2.Columns.Add("fnumeroReg"); //Este puede estar adicional ---------------ESTE NO VA
                // _d2.Columns.Add("fconsecAutoReg"); //Este puede estar adicional -------------ESTE NO VA

                //_d2.TableName = "MovtoVentaServicios";
                _d2.Columns.Add("NombreSeccion2");
                _d2.Columns.Add("f310IdTipoDocto2");
                _d2.Columns.Add("f310ConsecDocto2");
                _d2.Columns.Add("f318RowId");
                _d2.Columns.Add("f318IdServicio");
                _d2.Columns.Add("f318IdTerceroMovto");
                _d2.Columns.Add("f318Cantidad");
                _d2.Columns.Add("f318VlrBruto");
                _d2.Columns.Add("f318VlrDscto1");
                _d2.Columns.Add("f318VlrDscto2");
                _d2.Columns.Add("f318Notas");
                _d2.Columns.Add("f318Detalle");
                _d2.Columns.Add("fnumeroReg");






                for (int Entrega = 0; Entrega < jsonT.value.Count; Entrega++)
                {
                  
                    for (int i = 0; i < jsonT.value[Entrega].movementsSaleService.Count; i++)
                    {

                        _d2.Rows.Add("OrdenVentaServicios",
                        "OST",
                        jsonT.value[Entrega].f310ConsecDocto,
                        jsonT.value[Entrega].f310Fecha,
                        jsonT.value[Entrega].f310IdTercero,
                        jsonT.value[Entrega].f310IdSucursalCli,
                        jsonT.value[Entrega].f310IdTerceroVendedor,
                        jsonT.value[Entrega].f310Referencia,
                        jsonT.value[Entrega].f310IdCondPago,
                        jsonT.value[Entrega].f310IdTipoCli,
                        jsonT.value[Entrega].f310IdMonedaDocto,
                        jsonT.value[Entrega].f310IndTasa,
                        jsonT.value[Entrega].f310IdMonedaConv,
                        jsonT.value[Entrega].f310TasaConv,
                        jsonT.value[Entrega].f310IdMonedaLocal,
                        jsonT.value[Entrega].f310TasaLocal,
                        jsonT.value[Entrega].f310Notas,
                        jsonT.value[Entrega].f310NumeroOrdenCompra,
                        //jsonT.value[Entrega].fnumeroReg,
                        //jsonT.value[Entrega].fconsecAutoReg);

                            "MovtoVentaServicios",
                            "OST",
                            jsonT.value[Entrega].f310ConsecDocto,
                            jsonT.value[Entrega].movementsSaleService[i].f318RowId,
                            jsonT.value[Entrega].movementsSaleService[i].f318IdServicio,
                            jsonT.value[Entrega].movementsSaleService[i].f318IdTerceroMovto,
                            jsonT.value[Entrega].movementsSaleService[i].f318Cantidad,
                            jsonT.value[Entrega].movementsSaleService[i].f318VlrBruto,
                            jsonT.value[Entrega].movementsSaleService[i].f318VlrDscto1,
                            jsonT.value[Entrega].movementsSaleService[i].f318VlrDscto2,
                            jsonT.value[Entrega].movementsSaleService[i].f318Notas,
                            jsonT.value[Entrega].movementsSaleService[i].f318Detalle,
                            jsonT.value[Entrega].movementsSaleService[i].fnumeroReg);

                    }


                }

                 

                AccionesBD accionbd = new AccionesBD();

                DataSet dsDatosPedido = new DataSet();
                dsDatosPedido.Tables.Add(_d2);


                //dsDatosPedido.Tables.Add(_d3);



                //INGRESA LOS REGISTROS A LA BASE DE DATOS PARA PODER LLEVAR UN CONTROL
                DataSet dsProcesado = accionbd.AlmacenarVentasdeServicio(dsDatosPedido);




                if (dsProcesado.Tables[0].Rows.Count>0) {
                    ConsumoGT _Consumo = new ConsumoGT();
                    string RespuestaPedidos = "";
                    string RutaPlanos2 = RutaPlanos;
                    RespuestaPedidos = _Consumo.Insertar(dsProcesado, "ORDEN_DE_SERVICIO", 120111, RutaPlanos2, "1");
                    MessageBox.Show("Respuesta Siesa: "+RespuestaPedidos);

                    if (RespuestaPedidos.Equals("Importacion exitosa"))
                    {
                        //Aqui debo continuar
                        accionbd.ActualizarIntegrado(1,dsProcesado);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
                throw;
            }
        }

    }
}
