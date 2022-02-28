using Infraestructura.Procesos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Procesos;

namespace Dominio.Conectores
{
    class ConectorTercerosProveedor:Configuraciones
    {
        public void conectorTercerosProveedor(string json)
        {
            try
            {


                dynamic jsonT = JsonConvert.DeserializeObject<dynamic>(json);


                DataTable _d1 = new DataTable();
                //DataTable _d2 = new DataTable();

                _d1.TableName = "Terceros";
                //_d2.TableName = "Proveedor";
                _d1.Columns.Add("NombreSeccion");
                _d1.Columns.Add("f200Id");
                _d1.Columns.Add("f200Nit");
                _d1.Columns.Add("f200DvNit");
                _d1.Columns.Add("f200IdTipoIdent");
                _d1.Columns.Add("f200IndTipoTercero");
                _d1.Columns.Add("f200RazonSocial");//2
                _d1.Columns.Add("f200Apellido1");
                _d1.Columns.Add("f200Apellido2");
                _d1.Columns.Add("f200Nombres");
                _d1.Columns.Add("f200NombreEst");
                _d1.Columns.Add("f015Contacto");//1
                _d1.Columns.Add("f015Direccion1");
                _d1.Columns.Add("f015Direccion2");
                _d1.Columns.Add("f015Direccion3");
                _d1.Columns.Add("f015IdPais");
                _d1.Columns.Add("f015IdDepto");
                _d1.Columns.Add("f015IdCiudad");
                _d1.Columns.Add("f015IdBarrio");//1
                _d1.Columns.Add("f015Telefono");//1
                _d1.Columns.Add("f015Fax");//1
                _d1.Columns.Add("f015CodPostal");//1
                _d1.Columns.Add("f015Email");//1
                _d1.Columns.Add("f200FechaNacimiento");
                _d1.Columns.Add("f200IdCiiu");//2
                _d1.Columns.Add("f200IndNoDomiciliado");
                _d1.Columns.Add("f015Celular");//2
                _d1.Columns.Add("fnumeroReg");

                _d1.Columns.Add("NombreSeccion2");
                _d1.Columns.Add("f200Id2");
                //_d1.Columns.Add("f200Nit");
                //_d1.Columns.Add("f200DvNit");
                //_d1.Columns.Add("f200IdTipoIdent");
                _d1.Columns.Add("f200RazonSocial2");
                //_d1.Columns.Add("f200Apellido1");
                //_d1.Columns.Add("f200Apellido2");
                //_d1.Columns.Add("f200Nombres");
                //_d1.Columns.Add("f200NombreEst");
                _d1.Columns.Add("f015Contacto2");
                _d1.Columns.Add("f015Direccion12");
                _d1.Columns.Add("f015Direccion22");
                _d1.Columns.Add("f015Direccion32");
                _d1.Columns.Add("f015IdPais2");
                _d1.Columns.Add("f015IdDepto2");
                _d1.Columns.Add("f015IdCiudad2");
                _d1.Columns.Add("f015IdBarrio2");
                _d1.Columns.Add("f015Telefono2");
                _d1.Columns.Add("f015Fax2");
                _d1.Columns.Add("f015CodPostal2");
                _d1.Columns.Add("f015Email2");
                _d1.Columns.Add("f200FechaNacimiento2"); //talvez no deberia de ir
                //_d1.Columns.Add("f200IdCiiu");este no deberia ir
                //_d1.Columns.Add("f200IndNoDomiciliado"); este no deberia ir
                _d1.Columns.Add("f015Celular2");
                _d1.Columns.Add("fnumeroReg2");

                for (int i = 0; i < jsonT.value.Count; i++)
                {
                    _d1.Rows.Add(
                        "Terceros",
                        jsonT.value[i].f200Id,
                        jsonT.value[i].f200Nit,
                        jsonT.value[i].f200DvNit,
                        jsonT.value[i].f200IdTipoIdent,
                        jsonT.value[i].f200IndTipoTercero,
                        jsonT.value[i].f200RazonSocial,
                        jsonT.value[i].f200Apellido1,
                        jsonT.value[i].f200Apellido2,
                        jsonT.value[i].f200Nombres,
                        jsonT.value[i].f200NombreEst,
                        jsonT.value[i].f015Contacto,
                        jsonT.value[i].f015Direccion1,
                        jsonT.value[i].f015Direccion2,
                        jsonT.value[i].f015Direccion3,
                        jsonT.value[i].f015IdPais,
                        jsonT.value[i].f015IdDepto,
                        jsonT.value[i].f015IdCiudad,
                        jsonT.value[i].f015IdBarrio,
                        jsonT.value[i].f015Telefono,
                        jsonT.value[i].f015Fax,
                        jsonT.value[i].f015CodPostal,
                        jsonT.value[i].f015Email,
                        jsonT.value[i].f200FechaNacimiento,
                        jsonT.value[i].f200IdCiiu,
                        jsonT.value[i].f200IndNoDomiciliado,
                        jsonT.value[i].f015Celular,
                        jsonT.value[i].fnumeroReg,

                        "Proveedor",
                        jsonT.value[i].f200Id,
                        //jsonT.value[i].f200Nit,
                        ////jsonT.value[i].f200DvNit,
                        //jsonT.value[i].f200IdTipoIdent,
                        jsonT.value[i].f200RazonSocial,
                        //jsonT.value[i].f200Apellido1,
                        //jsonT.value[i].f200Apellido2,
                        //jsonT.value[i].f200Nombres,
                        //jsonT.value[i].f200NombreEst,
                        jsonT.value[i].f015Contacto,
                        jsonT.value[i].f015Direccion1,
                        jsonT.value[i].f015Direccion2,
                        jsonT.value[i].f015Direccion3,
                        jsonT.value[i].f015IdPais,
                        jsonT.value[i].f015IdDepto,
                        jsonT.value[i].f015IdCiudad,
                        jsonT.value[i].f015IdBarrio,
                        jsonT.value[i].f015Telefono,
                        jsonT.value[i].f015Fax,
                        jsonT.value[i].f015CodPostal,
                        jsonT.value[i].f015Email,
                        jsonT.value[i].f200FechaNacimiento,
                        //jsonT.value[i].f200IdCiiu,
                        //jsonT.value[i].f200IndNoDomiciliado,
                        jsonT.value[i].f015Celular,
                        jsonT.value[i].fnumeroReg
                        );
                }


                DataSet DS = new DataSet();
                DS.Tables.Add(_d1);
                //DS.Tables.Add(_d2);

                //MessageBox.Show("Filas Original: " + DS.Tables[0].Rows.Count);
                //MessageBox.Show("Columnas Original: " + DS.Tables[0].Columns.Count);


                AccionesBD accionBD = new AccionesBD();

                DataSet dsProcesado = new DataSet();

                dsProcesado = accionBD.AlmacenarTerceroProveedor(DS);
                //MessageBox.Show("Filas Procesado: " + dsProcesado.Tables[0].Rows.Count);
                //MessageBox.Show("Columnas Procesado: " + dsProcesado.Tables[0].Columns.Count);

                //MessageBox.Show("Filas Procesado tabla2: " + dsProcesado.Tables[1].Rows.Count);
                //MessageBox.Show("Columnas Procesado tabla2: " + dsProcesado.Tables[1].Columns.Count);



                if (dsProcesado.Tables[0].Rows.Count > 0)
                {

                    ConsumoGT _consumo = new ConsumoGT();
                    string rutaplano3 = RutaPlanos;
                    string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_PROVEEDOR", 120969, rutaplano3, "1");
                    MessageBox.Show("Respuesta Siesa: "+respuestaSiesa);

                    if (respuestaSiesa.Equals("Importacion exitosa"))
                    {
                        accionBD.ActualizarIntegrado(2,dsProcesado);

                        Correo correo = new Correo();

                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                            correo.EnviarCorreo("jerazo@generictransfer.com,contabilidad@anurotec.com", "GTINTEGRATION: CREACION DE TERCERO PROVEEDOR", "Se creó el tercero con el Nit " + dsProcesado.Tables[0].Rows[i]["f200Nit"] + "  y tipo de identidad: "+dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"] + "\n" + "Nota: El estado actual del tercero es INACTIVO");
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
