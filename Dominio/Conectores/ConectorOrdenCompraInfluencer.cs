using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Infraestructura.Procesos;
using Dominio.Procesos;
using System.Windows.Forms;

namespace Dominio.Conectores
{
    class ConectorOrdenCompraInfluencer: Configuraciones
    {
        public void conectorOrdenCompraInfluencer(string json)
        {
            try
            {
                dynamic Json = JsonConvert.DeserializeObject<dynamic>(json);

                DataTable _d1 = new DataTable();

                _d1.TableName= "NombreSeccion";

                _d1.Columns.Add("NombreSeccion");
                _d1.Columns.Add("f310IdCo");
                _d1.Columns.Add("f310IdTipoDocto");
                _d1.Columns.Add("f310ConsecDocto");
                _d1.Columns.Add("f310Fecha");
                _d1.Columns.Add("f310IdTercero");
                _d1.Columns.Add("f310IdSucursalProv");
                _d1.Columns.Add("f310IdTerceroComprador");
                _d1.Columns.Add("f310IdClaseDocto");
                _d1.Columns.Add("f310IndEstado");
                _d1.Columns.Add("f310IndImpresion");
                _d1.Columns.Add("f310Referencia");
                _d1.Columns.Add("f310IdCondPago");
                _d1.Columns.Add("f310IdTipoProv");
                _d1.Columns.Add("f310IdMonedaDocto");
                _d1.Columns.Add("f310IdMonedaConv");
                _d1.Columns.Add("f310TasaConv");
                _d1.Columns.Add("f310IdMonedaLocal");
                _d1.Columns.Add("f310TasaLocal");
                _d1.Columns.Add("f310Notas");
                _d1.Columns.Add("f310IdMandato");
                _d1.Columns.Add("f310IdCoDoctoCdp");
                _d1.Columns.Add("f310IdTipoDoctoCdp");
                _d1.Columns.Add("f310ConsecDoctoCdp");

                _d1.Columns.Add("NombreSeccion2");
                _d1.Columns.Add("f310IdCo");
                _d1.Columns.Add("f310IdTipoDocto");
                _d1.Columns.Add("f310ConsecDocto");
                _d1.Columns.Add("f318RowId");
                _d1.Columns.Add("f318IdServicio");
                _d1.Columns.Add("f318IdMotivo");
                _d1.Columns.Add("f318IdCoMovto");
                _d1.Columns.Add("f318IdUnMovto");
                _d1.Columns.Add("f318IdCCostoMovto");
                _d1.Columns.Add("f318IdTerceroMovto");
                _d1.Columns.Add("f318IdSucursalCliente");
                _d1.Columns.Add("f318IdSucursalProveedor");
                _d1.Columns.Add("f318Cantidad");
                _d1.Columns.Add("f318VlrBruto");
                _d1.Columns.Add("f318VlrDscto1");
                _d1.Columns.Add("f318VlrDscto2");
                _d1.Columns.Add("f318Notas");
                _d1.Columns.Add("f318Detalle");
                _d1.Columns.Add("fnumeroReg");
                _d1.Columns.Add("fsubtipoReg");
                _d1.Columns.Add("ftipoReg");
                _d1.Columns.Add("fversionReg");
                _d1.Columns.Add("fcia");

                _d1.Columns.Add("fnumeroReg");
                _d1.Columns.Add("fsubtipoReg");
                _d1.Columns.Add("ftipoReg");
                _d1.Columns.Add("fversionReg");
                _d1.Columns.Add("fcia");
                _d1.Columns.Add("fliquidaImpuesto");
                _d1.Columns.Add("fconsecAutoReg");


                for (int i = 0; i < Json.value.Count; i++)
                {
                    for (int m = 0; m<Json.value.movementsServices.Count; m++)
                    {
                       _d1.Rows.Add("OrdenCompra",
                       Json.value[i].f310IdCo,
                       Json.value[i].f310IdTipoDocto,
                       i,
                       Json.value[i].f310Fecha,
                       Json.value[i].f310IdTercero,
                       Json.value[i].f310IdSucursalProv,
                       Json.value[i].f310IdTerceroComprador,
                       Json.value[i].f310IdClaseDocto,
                       Json.value[i].f310IndEstado,
                       Json.value[i].f310IndImpresion,
                       Json.value[i].f310Referencia,
                       Json.value[i].f310IdCondPago,
                       Json.value[i].f310IdTipoProv,
                       Json.value[i].f310IdMonedaDocto,
                       Json.value[i].f310IdMonedaConv,
                       Json.value[i].f310TasaConv,
                       Json.value[i].f310IdMonedaLocal,
                       Json.value[i].f310TasaLocal,
                       Json.value[i].f310Notas,
                       Json.value[i].f310IdMandato,
                       Json.value[i].f310IdCoDoctoCdp,
                       Json.value[i].f310IdTipoDoctoCdp,
                       Json.value[i].f310ConsecDoctoCdp,

                       "MovtoOrdenCompra",
                       Json.value[i].movementsServices[m].f310IdCo,
                       Json.value[i].movementsServices[m].f310IdTipoDocto,
                       i,
                       Json.value[i].movementsServices[m].f318RowId,
                       Json.value[i].movementsServices[m].f318IdServicio,
                       Json.value[i].movementsServices[m].f318IdMotivo,
                       Json.value[i].movementsServices[m].f318IdCoMovto,
                       Json.value[i].movementsServices[m].f318IdUnMovto,
                       Json.value[i].movementsServices[m].f318IdCCostoMovto,
                       Json.value[i].movementsServices[m].f318IdTerceroMovto,
                       Json.value[i].movementsServices[m].f318IdSucursalCliente,
                       Json.value[i].movementsServices[m].f318IdSucursalProveedor,
                       Json.value[i].movementsServices[m].f318Cantidad,
                       Json.value[i].movementsServices[m].f318VlrBruto,
                       Json.value[i].movementsServices[m].f318VlrDscto1,
                       Json.value[i].movementsServices[m].f318VlrDscto2,
                       Json.value[i].movementsServices[m].f318Notas,
                       Json.value[i].movementsServices[m].f318Detalle,
                       Json.value[i].movementsServices[m].fnumeroReg,
                       Json.value[i].movementsServices[m].fsubtipoReg,
                       Json.value[i].movementsServices[m].ftipoReg,
                       Json.value[i].movementsServices[m].fversionReg,
                       Json.value[i].movementsServices[m].fcia,

                       Json.value[i].fnumeroReg,
                       Json.value[i].fsubtipoReg,
                       Json.value[i].ftipoReg,
                       Json.value[i].fversionReg,
                       Json.value[i].fcia,
                       Json.value[i].fliquidaImpuesto,
                       Json.value[i].fconsecAutoReg
                       );
                    }
                 
                }

                DataSet DS = new DataSet();

                DS.Tables.Add(_d1);

                AccionesBD accionesBD = new AccionesBD();
                DataSet dsProcesado = accionesBD.AlmacenarOrdenCompraInfluencer(DS);

                if (dsProcesado.Tables[0].Rows.Count > 0)
                {

                    ConsumoGT _consumo = new ConsumoGT();
                    string rutaplano4 = RutaPlanos;
                    string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_CLIENTES", 120951, rutaplano4, "1");

                    MessageBox.Show("Respuesta Siesa: " + respuestaSiesa);

                    if (respuestaSiesa.Equals("Importacion exitosa"))
                    {
                        //MessageBox.Show("Filas procesadas: "+ dsProcesado.Tables[0].Rows.Count);

                        //for (int i = 0; i<dsProcesado.Tables[0].Rows.Count; i++)
                        //{
                        //    MessageBox.Show("Nit: "+dsProcesado.Tables[0].Rows[i]["f200Nit"]+" Tipo Ident: "+ dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"]);
                        //}


                        accionesBD.ActualizarIntegrado(4, dsProcesado);
                        //Correo correo = new Correo();

                        //for (int i = 0; i < dsProcesado.Tables[0].Rows.Count; i++)
                        //{
                        //    correo.EnviarCorreo("jerazo@generictransfer.com,contabilidad@anurotec.com", "GTINTEGRATION: CREACION DE TERCERO CLIENTE", "Se creó el tercero con el Nit " + dsProcesado.Tables[0].Rows[i]["f200Nit"] + "  y tipo de identidad: " + dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"] + "\n" + "Nota: El estado actual del tercero es INACTIVO");
                        //}
                    }
                }

            }
            catch
            {

            }
        }

    }
}
