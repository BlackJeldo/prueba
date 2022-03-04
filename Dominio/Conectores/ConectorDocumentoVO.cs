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
    class ConectorDocumentoVO:Configuraciones
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
            _d1.Columns.Add("f350IdCo");
            _d1.Columns.Add("f350IdTipoDocto");
            _d1.Columns.Add("f350ConsecDocto");
            _d1.Columns.Add("f351IdAuxiliar");
            _d1.Columns.Add("f351IdTercero");
            _d1.Columns.Add("f351IdCoMov");
            _d1.Columns.Add("f351IdUn");
            _d1.Columns.Add("f351IdCcosto");
            _d1.Columns.Add("f351IdFe");
            _d1.Columns.Add("f351ValorDb");
            _d1.Columns.Add("f351ValorCr");
            _d1.Columns.Add("f351ValorDbAlt");
            _d1.Columns.Add("f351ValorCrAlt");
            _d1.Columns.Add("f351BaseGravable");
            _d1.Columns.Add("f351ValorDb2");
            _d1.Columns.Add("f351ValorCr2");
            _d1.Columns.Add("f351ValorDbAlt2");
            _d1.Columns.Add("f351ValorCrAlt2");
            _d1.Columns.Add("f351BaseGravable2");
            _d1.Columns.Add("f351ValorDb3");
            _d1.Columns.Add("f351ValorCr3");
            _d1.Columns.Add("f351ValorDbAlt3");
            _d1.Columns.Add("f351ValorCrAlt3");
            _d1.Columns.Add("f351BaseGravable3");
            _d1.Columns.Add("f351DoctoBanco");
            _d1.Columns.Add("f351NroDoctoBanco");
            _d1.Columns.Add("f351Notas");
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
            _d1.Columns.Add("fconsecAutoReg");

            for (int i = 0; i<Json.value.Count; i++)
            {
                for (int m =0; m<Json.value.voMovements.Count; m++)
                {
                    _d1.Rows.Add(
                    "DocumentoVO",
                    Json.value[i].f350IdCo,
                    Json.value[i].f350IdTipoDocto,
                    Json.value[i].f350ConsecDocto,
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
                    Json.value[i].voMovements[m].f350ConsecDocto,
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

            AccionesBD accionesBD = new AccionesBD();
            DataSet dsProcesado = new DataSet();

            dsProcesado = accionesBD.AlmacenarDocumentoVO(dsOriginal);


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


                    accionesBD.ActualizarIntegrado(7, dsProcesado);
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
