using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using Infraestructura.Procesos;
using System.Windows.Forms;

namespace Dominio.Conectores
{
    class ConectorOrdenServicioVentaInfluencer:Configuraciones
    {
        public void conectorOrdenServicioVentaInfluencer(string json)
        {
            dynamic Json = JsonConvert.DeserializeObject<dynamic>(json);

            DataTable _d1 = new DataTable();

            _d1.TableName = "OrdenServicioVentaInfluencer";

            _d1.Columns.Add("NombreSeccion");
            _d1.Columns.Add("f310IdTipoDocto");
            _d1.Columns.Add("f310ConsecDocto");
            _d1.Columns.Add("f310Fecha");
            _d1.Columns.Add("f310IdTercero");
            _d1.Columns.Add("f310IdSucursalCli");
            _d1.Columns.Add("f310IdTerceroVendedor");
            _d1.Columns.Add("f310Referencia");
            _d1.Columns.Add("f310IdCondPago");
            _d1.Columns.Add("f310IdTipoCli");
            _d1.Columns.Add("f310IdMonedaDocto");
            _d1.Columns.Add("f310IndTasa");
            _d1.Columns.Add("f310IdMonedaConv");
            _d1.Columns.Add("f310TasaConv");
            _d1.Columns.Add("f310IdMonedaLocal");
            _d1.Columns.Add("f310TasaLocal");
            _d1.Columns.Add("f310Notas");
            _d1.Columns.Add("f310NumeroOrdenCompra");

            _d1.Columns.Add("NombreSeccion2");
            _d1.Columns.Add("f310IdCo2");
            _d1.Columns.Add("f310IdTipoDocto2");
            _d1.Columns.Add("f310ConsecDocto2");
            _d1.Columns.Add("f318RowId2");
            _d1.Columns.Add("f318IdServicio2");
            _d1.Columns.Add("f318IdMotivo2");
            _d1.Columns.Add("f318IdCoMovto2");
            _d1.Columns.Add("f318IdUnMovto2");
            _d1.Columns.Add("f318IdCCostoMovto2");
            _d1.Columns.Add("f318IdTerceroMovto2");
            _d1.Columns.Add("f318IdSucursalCliente2");
            _d1.Columns.Add("f318IdSucursalProveedor2");
            _d1.Columns.Add("f318Cantidad2");
            _d1.Columns.Add("f318VlrBruto2");
            _d1.Columns.Add("f318VlrDscto12");
            _d1.Columns.Add("f318VlrDscto22");
            _d1.Columns.Add("f318Notas2");
            _d1.Columns.Add("f318Detalle2");
            _d1.Columns.Add("fnumeroReg2");
            _d1.Columns.Add("fsubtipoReg2");
            _d1.Columns.Add("ftipoReg2");
            _d1.Columns.Add("fversionReg2");
            _d1.Columns.Add("fcia2");

            _d1.Columns.Add("fnumeroReg3");
            _d1.Columns.Add("fconsecAutoReg3");

            MessageBox.Show("Se agregaron columnas");


            for (int i = 0; i<Json.value.Count; i++)
            {
                for (int m = 0; m<Json.value[i].movementsServices.Count; m++ )
                {
                     _d1.Rows.Add(
                    "OrdenVentaServicios",
                    Json.value[i].f310IdTipoDocto,
                    i,
                    Json.value[i].f310Fecha,
                    Json.value[i].f310IdTercero,
                    Json.value[i].f310IdSucursalCli,
                    Json.value[i].f310IdTerceroVendedor,
                    Json.value[i].f310Referencia,
                    Json.value[i].f310IdCondPago,
                    Json.value[i].f310IdTipoCli,
                    Json.value[i].f310IdMonedaDocto,
                    Json.value[i].f310IndTasa,
                    Json.value[i].f310IdMonedaConv,
                    Json.value[i].f310TasaConv,
                    Json.value[i].f310IdMonedaLocal,
                    Json.value[i].f310TasaLocal,
                    Json.value[i].f310Notas,
                    Json.value[i].f310NumeroOrdenCompra,

                    "MovtoVentaServicios",
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
                    Json.value[i].fconsecAutoReg
                    );

                }

                

            }

            AccionesBD accionesBD = new AccionesBD();
            DataSet DsGenerico = new DataSet();

            DsGenerico.Tables.Add(_d1);

            MessageBox.Show("Registros originales = "+DsGenerico.Tables[0].Rows.Count);
            DataSet dsProcesado = new DataSet();

            dsProcesado = accionesBD.AlmacenarOrdenServicioVentaInfluencer(DsGenerico);
            MessageBox.Show("Registros procesados = " + dsProcesado.Tables[0].Rows.Count);


            if (dsProcesado.Tables[0].Rows.Count > 0)
            {

                ConsumoGT _consumo = new ConsumoGT();
                string rutaplano7 = RutaPlanos;
                string respuestaSiesa = _consumo.Insertar(dsProcesado, "ORDEN_DE_SERVICIO", 120111, rutaplano7, "1");

                MessageBox.Show("Respuesta Siesa: " + respuestaSiesa);

                if (respuestaSiesa.Equals("Importacion exitosa"))
                {
                    MessageBox.Show("Filas procesadas: " + dsProcesado.Tables[0].Rows.Count);


                    accionesBD.ActualizarIntegrado(6, dsProcesado);
                    //Correo correo = new Correo();

                    //for (int i = 0; i < dsProcesado.Tables[0].Rows.Count; i++)
                    //{
                    //    correo.EnviarCorreo("jerazo@generictransfer.com,contabilidad@anurotec.com", "GTINTEGRATION: CREACION DE TERCERO CLIENTE", "Se creó el tercero con el Nit " + dsProcesado.Tables[0].Rows[i]["f200Nit"] + "  y tipo de identidad: " + dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"] + "\n" + "Nota: El estado actual del tercero es INACTIVO");
                    //}
                }
            }

        }
    }
}
