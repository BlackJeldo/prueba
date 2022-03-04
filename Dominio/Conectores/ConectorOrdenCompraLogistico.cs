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

            


            for (int i = 0; i< Json.values.Count; i++)
            {
                for (int m=0; m<Json.values.movementLogisticService.Count; m++)
                {
                    _d1.Rows.Add(
                   "OrdenCompraLogistico",
                   Json.values[i].f310IdCo,
                   Json.values[i].f310IdTipoDocto,
                   Json.values[i].f310ConsecDocto,
                   Json.values[i].f310Fecha,
                   Json.values[i].f310IdTercero,
                   Json.values[i].f310IdSucursalProv,
                   Json.values[i].f310IdTerceroComprador,
                   Json.values[i].f310IdClaseDocto,
                   Json.values[i].f310IndEstado,
                   Json.values[i].f310IndImpresion,
                   Json.values[i].f310Referencia,
                   Json.values[i].f310IdCondPago,
                   Json.values[i].f310IdTipoProv,
                   Json.values[i].f310IdMonedaDocto,
                   Json.values[i].f310IdMonedaConv,
                   Json.values[i].f310TasaConv,
                   Json.values[i].f310IdMonedaLocal,
                   Json.values[i].f310TasaLocal,
                   Json.values[i].f310Notas,
                   Json.values[i].f310IdMandato,
                   Json.values[i].f310IdCoDoctoCdp,
                   Json.values[i].f310IdTipoDoctoCdp,
                   Json.values[i].f310ConsecDoctoCdp,

                   "MovtoOrdenCompraLogistico",
                   Json.values[i].movementLogisticService[m].f310IdCo,
                   Json.values[i].movementLogisticService[m].f310IdTipoDocto,
                   Json.values[i].movementLogisticService[m].f310ConsecDocto,
                   Json.values[i].movementLogisticService[m].f318RowId,
                   Json.values[i].movementLogisticService[m].f318IdServicio,
                   Json.values[i].movementLogisticService[m].f318IdMotivo,
                   Json.values[i].movementLogisticService[m].f318IdCoMovto,
                   Json.values[i].movementLogisticService[m].f318IdUnMovto,
                   Json.values[i].movementLogisticService[m].f318IdCCostoMovto,
                   Json.values[i].movementLogisticService[m].f318IdTerceroMovto,
                   Json.values[i].movementLogisticService[m].f318IdSucursalCliente,
                   Json.values[i].movementLogisticService[m].f318IdSucursalProveedor,
                   Json.values[i].movementLogisticService[m].f318Cantidad,
                   Json.values[i].movementLogisticService[m].f318VlrBruto,
                   Json.values[i].movementLogisticService[m].f318VlrDscto1,
                   Json.values[i].movementLogisticService[m].f318VlrDscto2,
                   Json.values[i].movementLogisticService[m].f318Notas,
                   Json.values[i].movementLogisticService[m].f318Detalle,
                   Json.values[i].movementLogisticService[m].fnumeroReg,
                   Json.values[i].movementLogisticService[m].fsubtipoReg,
                   Json.values[i].movementLogisticService[m].ftipoReg,
                   Json.values[i].movementLogisticService[m].fversionReg,
                   Json.values[i].movementLogisticService[m].fcia,

                   Json.values[i].fnumeroReg,
                   Json.values[i].fsubtipoReg,
                   Json.values[i].ftipoReg,
                   Json.values[i].fversionReg,
                   Json.values[i].fcia,
                   Json.values[i].fliquidaImpuesto,
                   Json.values[i].fconsecAutoReg
                   );
                }
            }

            DataSet dsOriginal = new DataSet();

            dsOriginal.Tables.Add(_d1);

            AccionesBD accionesBD = new AccionesBD();

            DataSet dsProcesado = new DataSet();
            dsProcesado = accionesBD.AlmacenarOrdenCompraLogistico(dsOriginal);


            if (dsProcesado.Tables[0].Rows.Count > 0)
            {

                ConsumoGT _consumo = new ConsumoGT();
                string rutaplano5 = RutaPlanos;
                string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_CLIENTES", 120951, rutaplano5, "1");

                MessageBox.Show("Respuesta Siesa: " + respuestaSiesa);

                if (respuestaSiesa.Equals("Importacion exitosa"))
                {
                    //MessageBox.Show("Filas procesadas: "+ dsProcesado.Tables[0].Rows.Count);

                    //for (int i = 0; i<dsProcesado.Tables[0].Rows.Count; i++)
                    //{
                    //    MessageBox.Show("Nit: "+dsProcesado.Tables[0].Rows[i]["f200Nit"]+" Tipo Ident: "+ dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"]);
                    //}


                    accionesBD.ActualizarIntegrado(5, dsProcesado);
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
