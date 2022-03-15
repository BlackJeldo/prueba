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
    class ConectorDocumentoVO: Configuraciones
    {
        public void conectorDocumentoVO(string json)
        {
            dynamic Json = JsonConvert.DeserializeObject<dynamic>(json);
            DataTable _d1 = new DataTable();

            _d1.TableName = "DocumentoVO";

            _d1.Columns.Add("NombreSeccion");
            _d1.Columns.Add("f350IdCo");
            _d1.Columns.Add("f350IdTipoDocto");
            _d1.Columns.Add("f350ConsecDocto");
            _d1.Columns.Add("f350Fecha");
            _d1.Columns.Add("f350IdTercero");
            _d1.Columns.Add("f350IdClaseDocto");
            _d1.Columns.Add("f350IndEstado");
            _d1.Columns.Add("f350IndImpresion");
            _d1.Columns.Add("f350Notas");
            _d1.Columns.Add("f350RecalcularRx");

            _d1.Columns.Add("NombreSeccion2");
            _d1.Columns.Add("f350IdCo2");
            _d1.Columns.Add("f350IdTipoDocto2");
            _d1.Columns.Add("f350ConsecDocto2");
            _d1.Columns.Add("f351IdAuxiliar2");
            _d1.Columns.Add("f351IdTercero2");
            _d1.Columns.Add("f351IdCoMov2");
            _d1.Columns.Add("f351IdUn2");
            _d1.Columns.Add("f351IdCcosto2");
            _d1.Columns.Add("f351IdFe2");
            _d1.Columns.Add("f351ValorDb2");
            _d1.Columns.Add("f351ValorCr2");
            _d1.Columns.Add("f351ValorDbAlt2");
            _d1.Columns.Add("f351ValorCrAlt2");
            _d1.Columns.Add("f351BaseGravable2");
            _d1.Columns.Add("f351ValorDb22");
            _d1.Columns.Add("f351ValorCr22");
            _d1.Columns.Add("f351ValorDbAlt22");
            _d1.Columns.Add("f351ValorCrAlt22");
            _d1.Columns.Add("f351BaseGravable22");
            _d1.Columns.Add("f351ValorDb32");
            _d1.Columns.Add("f351ValorCr32");
            _d1.Columns.Add("f351ValorDbAlt32");
            _d1.Columns.Add("f351ValorCrAlt32");
            _d1.Columns.Add("f351BaseGravable32");
            _d1.Columns.Add("f351DoctoBanco2");
            _d1.Columns.Add("f351NroDoctoBanco2");
            _d1.Columns.Add("f351Notas2");
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
            _d1.Columns.Add("fconsecAutoReg3");

            for (int i = 0; i < Json.value.Count; i++)
            {
                for (int m = 0; m < Json.value[i].voMovements.Count; m++)
                {
                    _d1.Rows.Add(
                    "DocumentoVO",
                    Json.value[i].f350IdCo,
                    Json.value[i].f350IdTipoDocto,
                    i,
                    Json.value[i].f350Fecha,
                    Json.value[i].f350IdTercero,
                    Json.value[i].f350IdClaseDocto,
                    Json.value[i].f350IndEstado,
                    Json.value[i].f350IndImpresion,
                    Json.value[i].f350Notas,
                    Json.value[i].f350RecalcularRx,

                    "MovtoDocumentoVO",
                    Json.value[i].voMovements[m].f350IdCo,
                    Json.value[i].voMovements[m].f350IdTipoDocto,
                    i,
                    Json.value[i].voMovements[m].f351IdAuxiliar,
                    Json.value[i].voMovements[m].f351IdTercero,
                    Json.value[i].voMovements[m].f351IdCoMov,
                    Json.value[i].voMovements[m].f351IdUn,
                    Json.value[i].voMovements[m].f351IdCcosto,
                    Json.value[i].voMovements[m].f351IdFe,
                    Json.value[i].voMovements[m].f351ValorDb,
                    Json.value[i].voMovements[m].f351ValorCr,
                    Json.value[i].voMovements[m].f351ValorDbAlt,
                    Json.value[i].voMovements[m].f351ValorCrAlt,
                    Json.value[i].voMovements[m].f351BaseGravable,
                    Json.value[i].voMovements[m].f351ValorDb2,
                    Json.value[i].voMovements[m].f351ValorCr2,
                    Json.value[i].voMovements[m].f351ValorDbAlt2,
                    Json.value[i].voMovements[m].f351ValorCrAlt2,
                    Json.value[i].voMovements[m].f351BaseGravable2,
                    Json.value[i].voMovements[m].f351ValorDb3,
                    Json.value[i].voMovements[m].f351ValorCr3,
                    Json.value[i].voMovements[m].f351ValorDbAlt3,
                    Json.value[i].voMovements[m].f351ValorCrAlt3,
                    Json.value[i].voMovements[m].f351BaseGravable3,
                    Json.value[i].voMovements[m].f351DoctoBanco,
                    Json.value[i].voMovements[m].f351NroDoctoBanco,
                    Json.value[i].voMovements[m].f351Notas,
                    Json.value[i].voMovements[m].fnumeroReg,
                    Json.value[i].voMovements[m].fsubtipoReg,
                    Json.value[i].voMovements[m].ftipoReg,
                    Json.value[i].voMovements[m].fversionReg,
                    Json.value[i].voMovements[m].fcia,

                    Json.value[i].fnumeroReg,
                    Json.value[i].fsubtipoReg,
                    Json.value[i].ftipoReg,
                    Json.value[i].fversionReg,
                    Json.value[i].fcia,
                    Json.value[i].fconsecAutoReg

                   );
                }
            }

            DataSet dsOriginal = new DataSet();
            dsOriginal.Tables.Add(_d1);

            MessageBox.Show("Registros originales = " + dsOriginal.Tables[0].Rows.Count);
            AccionesBD accionesBD = new AccionesBD();
            DataSet dsProcesado = new DataSet();

            dsProcesado = accionesBD.AlmacenarDocumentoVO(dsOriginal);

            MessageBox.Show("Tablas procesadas = "+dsProcesado.Tables.Count);
            MessageBox.Show("Registros procesados = " + dsProcesado.Tables[0].Rows.Count);
            MessageBox.Show("Movimientos procesados procesados = " + dsProcesado.Tables[1].Rows.Count);

            //--------------------------PRUEBAS---------------






            //if (dsProcesado.Tables[0].Rows.Count > 0)
            //{

            //    ConsumoGT _consumo = new ConsumoGT();
            //    string rutaplano7 = RutaPlanos;
            //    string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_CLIENTES", 120951, rutaplano7, "1");

            //    MessageBox.Show("Respuesta Siesa: " + respuestaSiesa);

            //    if (respuestaSiesa.Equals("Importacion exitosa"))
            //    {
            //        //MessageBox.Show("Filas procesadas: "+ dsProcesado.Tables[0].Rows.Count);

            //        //for (int i = 0; i<dsProcesado.Tables[0].Rows.Count; i++)
            //        //{
            //        //    MessageBox.Show("Nit: "+dsProcesado.Tables[0].Rows[i]["f200Nit"]+" Tipo Ident: "+ dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"]);
            //        //}


            //        accionesBD.ActualizarIntegrado(7, dsProcesado);
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
