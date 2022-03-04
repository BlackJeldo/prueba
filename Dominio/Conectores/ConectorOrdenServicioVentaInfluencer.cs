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
            _d1.Columns.Add("fconsecAutoReg");

            for (int i = 0; i<Json.value.Count; i++)
            {
                _d1.Rows.Add(
                "OrdenServicioVentaInfluencer",
                Json.value[i].f310IdTipoDocto,
                Json.value[i].f310ConsecDocto,
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

                "MovtoOrdenServicioVentaInfluencer",
                Json.value[i].f310IdCo,
                Json.value[i].f310IdTipoDocto,
                Json.value[i].f310ConsecDocto,
                Json.value[i].f318RowId,
                Json.value[i].f318IdServicio,
                Json.value[i].f318IdMotivo,
                Json.value[i].f318IdCoMovto,
                Json.value[i].f318IdUnMovto,
                Json.value[i].f318IdCCostoMovto,
                Json.value[i].f318IdTerceroMovto,
                Json.value[i].f318IdSucursalCliente,
                Json.value[i].f318IdSucursalProveedor,
                Json.value[i].f318Cantidad,
                Json.value[i].f318VlrBruto,
                Json.value[i].f318VlrDscto1,
                Json.value[i].f318VlrDscto2,
                Json.value[i].f318Notas,
                Json.value[i].f318Detalle,
                Json.value[i].fnumeroReg,
                Json.value[i].fsubtipoReg,
                Json.value[i].ftipoReg,
                Json.value[i].fversionReg,
                Json.value[i].fcia,

                Json.value[i].fnumeroReg,
                Json.value[i].fconsecAutoReg
                );

            }

            AccionesBD accionesBD = new AccionesBD();
            DataSet DsGenerico = new DataSet();

            DsGenerico.Tables.Add(_d1);

            DataSet dsProcesado = new DataSet();

            dsProcesado = accionesBD.AlmacenarOrdenServicioVentaInfluencer(DsGenerico);


            if (dsProcesado.Tables[0].Rows.Count > 0)
            {

                ConsumoGT _consumo = new ConsumoGT();
                string rutaplano7 = RutaPlanos;
                string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_CLIENTES", 120951, rutaplano7, "1");

                MessageBox.Show("Respuesta Siesa: " + respuestaSiesa);

                if (respuestaSiesa.Equals("Importacion exitosa"))
                {
                    //MessageBox.Show("Filas procesadas: "+ dsProcesado.Tables[0].Rows.Count);

                    //for (int i = 0; i<dsProcesado.Tables[0].Rows.Count; i++)
                    //{
                    //    MessageBox.Show("Nit: "+dsProcesado.Tables[0].Rows[i]["f200Nit"]+" Tipo Ident: "+ dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"]);
                    //}


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
