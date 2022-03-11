using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Infraestructura.Procesos;
using System.Windows.Forms;

namespace Dominio.Conectores
{
    class ConectorOrdenCompraLogistico:Configuraciones
    {
        public void conectorOrdenCompraLogistico(string json)
        {
            dynamic Json = JsonConvert.DeserializeObject<dynamic>(json);

            DataTable _d1 = new DataTable();

            _d1.TableName = "OrdenCompra";

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
            _d1.Columns.Add("fsubtipoReg3");
            _d1.Columns.Add("ftipoReg3");
            _d1.Columns.Add("fversionReg3");
            _d1.Columns.Add("fcia3");
            _d1.Columns.Add("fliquidaImpuesto3");
            _d1.Columns.Add("fconsecAutoReg3");



            MessageBox.Show("Agrego las columnas");
            for (int i = 0; i< Json.value.Count; i++)
            {
                for (int m=0; m<Json.value[i].movementLogisticService.Count; m++)
                {
                    _d1.Rows.Add(
                   "OrdenCompraLogistico",
                   Json.value[i].f310IdCo,
                   Json.value[i].f310IdTipoDocto,
                   Json.value[i].f310ConsecDocto,
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

                   "MovtoOrdenCompraLogistico",
                   Json.value[i].movementLogisticService[m].f310IdCo,
                   Json.value[i].movementLogisticService[m].f310IdTipoDocto,
                   Json.value[i].movementLogisticService[m].f310ConsecDocto,
                   Json.value[i].movementLogisticService[m].f318RowId,
                   Json.value[i].movementLogisticService[m].f318IdServicio,
                   Json.value[i].movementLogisticService[m].f318IdMotivo,
                   Json.value[i].movementLogisticService[m].f318IdCoMovto,
                   Json.value[i].movementLogisticService[m].f318IdUnMovto,
                   Json.value[i].movementLogisticService[m].f318IdCCostoMovto,
                   Json.value[i].movementLogisticService[m].f318IdTerceroMovto,
                   Json.value[i].movementLogisticService[m].f318IdSucursalCliente,
                   Json.value[i].movementLogisticService[m].f318IdSucursalProveedor,
                   Json.value[i].movementLogisticService[m].f318Cantidad,
                   Json.value[i].movementLogisticService[m].f318VlrBruto,
                   Json.value[i].movementLogisticService[m].f318VlrDscto1,
                   Json.value[i].movementLogisticService[m].f318VlrDscto2,
                   Json.value[i].movementLogisticService[m].f318Notas,
                   Json.value[i].movementLogisticService[m].f318Detalle,
                   Json.value[i].movementLogisticService[m].fnumeroReg,
                   Json.value[i].movementLogisticService[m].fsubtipoReg,
                   Json.value[i].movementLogisticService[m].ftipoReg,
                   Json.value[i].movementLogisticService[m].fversionReg,
                   Json.value[i].movementLogisticService[m].fcia,

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

            DataSet dsOriginal = new DataSet();

            dsOriginal.Tables.Add(_d1);
            MessageBox.Show("Registros Originales = "+dsOriginal.Tables[0].Rows.Count);

            AccionesBD accionesBD = new AccionesBD();

            DataSet dsProcesado = new DataSet();
            dsProcesado = accionesBD.AlmacenarOrdenCompraLogistico(dsOriginal);
            MessageBox.Show("Registros Procesados = "+dsProcesado.Tables[0].Rows.Count);


            //if (dsProcesado.Tables[0].Rows.Count > 0)
            //{

            //    ConsumoGT _consumo = new ConsumoGT();
            //    string rutaplano5 = RutaPlanos;
            //    string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_CLIENTES", 120951, rutaplano5, "1");

            //    MessageBox.Show("Respuesta Siesa: " + respuestaSiesa);

            //    if (respuestaSiesa.Equals("Importacion exitosa"))
            //    {
            //        //MessageBox.Show("Filas procesadas: "+ dsProcesado.Tables[0].Rows.Count);

            //        //for (int i = 0; i<dsProcesado.Tables[0].Rows.Count; i++)
            //        //{
            //        //    MessageBox.Show("Nit: "+dsProcesado.Tables[0].Rows[i]["f200Nit"]+" Tipo Ident: "+ dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"]);
            //        //}


            //        accionesBD.ActualizarIntegrado(5, dsProcesado);
            //        //Correo correo = new Correo();

            //        //for (int i = 0; i < dsProcesado.Tables[0].Rows.Count; i++)
            //        //{
            //        //    correo.EnviarCorreo("jerazo@generictransfer.com,contabilidad@anurotec.com", "GTINTEGRATION: CREACION DE TERCERO CLIENTE", "Se creó el tercero con el Nit " + dsProcesado.Tables[0].Rows[i]["f200Nit"] + "  y tipo de identidad: " + dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"] + "\n" + "Nota: El estado actual del tercero es INACTIVO");
            //        //}
            //    }
            //}



        }
    }
}
