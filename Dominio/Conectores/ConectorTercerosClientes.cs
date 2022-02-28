using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Infraestructura.ConsumoGTWEB;
using Infraestructura.Procesos;
using System.Windows.Forms;
using Dominio.Procesos;

namespace Dominio.Conectores
{
    public class ConectorTercerosClientes:Configuraciones
    {
        public void conectorTercerosClientes(string json)
        {
            try
            {


                dynamic jsonT = JsonConvert.DeserializeObject<dynamic>(json);


                DataTable _d1 = new DataTable();
                //DataTable _d2 = new DataTable();

                _d1.TableName = "Terceros";
                //_d2.TableName = "Clientes";

                _d1.Columns.Add("NombreSeccion");
                _d1.Columns.Add("f200Id");
                _d1.Columns.Add("f200Nit");
                _d1.Columns.Add("f200DvNit");
                _d1.Columns.Add("f200IdTipoIdent");
                _d1.Columns.Add("f200IndTipoTercero");
                _d1.Columns.Add("f200RazonSocial");
                _d1.Columns.Add("f200Apellido1");
                _d1.Columns.Add("f200Apellido2");
                _d1.Columns.Add("f200Nombres");
                _d1.Columns.Add("f200NombreEst");
                _d1.Columns.Add("f015Contacto");
                _d1.Columns.Add("f015Direccion1");
                _d1.Columns.Add("f015Direccion2");
                _d1.Columns.Add("f015Direccion3");
                _d1.Columns.Add("f015IdPais");
                _d1.Columns.Add("f015IdDepto");
                _d1.Columns.Add("f015IdCiudad");
                _d1.Columns.Add("f015IdBarrio");
                _d1.Columns.Add("f015Telefono");
                _d1.Columns.Add("f015Fax");
                _d1.Columns.Add("f015CodPostal");
                _d1.Columns.Add("f015Email");
                _d1.Columns.Add("f200FechaNacimiento");
                _d1.Columns.Add("f200IdCiiu");
                _d1.Columns.Add("f200IndNoDomiciliado");
                _d1.Columns.Add("f015Celular");
                _d1.Columns.Add("fnumeroReg");

                _d1.Columns.Add("NombreSeccion2");
                _d1.Columns.Add("f200Id2");
                _d1.Columns.Add("f200Nit2");
                _d1.Columns.Add("f200DvNit2");
                _d1.Columns.Add("f200IdTipoIdent2");
                _d1.Columns.Add("f200IndTipoTercero2");
                _d1.Columns.Add("f200RazonSocial2");
                _d1.Columns.Add("f200Apellido12");
                _d1.Columns.Add("f200Apellido22");
                _d1.Columns.Add("f200Nombres2");
                _d1.Columns.Add("f200NombreEst2");
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
                _d1.Columns.Add("f200FechaNacimiento2");
                _d1.Columns.Add("f200IdCiiu2");
                _d1.Columns.Add("f200IndNoDomiciliado2");
                _d1.Columns.Add("f015Celular2");
                _d1.Columns.Add("fnumeroReg2");

                for (int i = 0; i < jsonT.value.Count; i++)
                {
                    _d1.Rows.Add("Terceros",
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
                        

                        "Clientes",
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
                        jsonT.value[i].fnumeroReg
                        );
                }


                DataSet DS = new DataSet();
                DS.Tables.Add(_d1);
                //DS.Tables.Add(_d2);

                //MessageBox.Show("Filas Original: "+DS.Tables[0].Rows.Count);
                //MessageBox.Show("Columnas Original: " + DS.Tables[0].Columns.Count);


                AccionesBD accionesBD = new AccionesBD();
                DataSet dsProcesado = accionesBD.AlmacenarTerceroCliente(DS);


                if (dsProcesado.Tables[0].Rows.Count > 0)
                {

                    ConsumoGT _consumo = new ConsumoGT();
                    string rutaplano2 = RutaPlanos;
                    string respuestaSiesa = _consumo.Insertar(dsProcesado, "TERCERO_CLIENTES", 120951, rutaplano2, "1");

                    MessageBox.Show("Respuesta Siesa: "+respuestaSiesa);

                    if (respuestaSiesa.Equals("Importacion exitosa"))
                    {
                        //MessageBox.Show("Filas procesadas: "+ dsProcesado.Tables[0].Rows.Count);

                        //for (int i = 0; i<dsProcesado.Tables[0].Rows.Count; i++)
                        //{
                        //    MessageBox.Show("Nit: "+dsProcesado.Tables[0].Rows[i]["f200Nit"]+" Tipo Ident: "+ dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"]);
                        //}


                        accionesBD.ActualizarIntegrado(3,dsProcesado);
                        Correo correo = new Correo();

                        for (int i = 0; i < dsProcesado.Tables[0].Rows.Count; i++)
                        {
                            correo.EnviarCorreo("jerazo@generictransfer.com,contabilidad@anurotec.com", "GTINTEGRATION: CREACION DE TERCERO CLIENTE", "Se creó el tercero con el Nit " + dsProcesado.Tables[0].Rows[i]["f200Nit"]+"  y tipo de identidad: "+dsProcesado.Tables[0].Rows[i]["f200IdTipoIdent"] + "\n" + "Nota: El estado actual del tercero es INACTIVO");
                        }
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
