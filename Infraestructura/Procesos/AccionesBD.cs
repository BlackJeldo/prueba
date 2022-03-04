using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Infraestructura.Properties;
using System.Windows.Forms;

namespace Infraestructura.Procesos
{
    public class AccionesBD : Configuraciones
    {
        //SqlConnection _sqlConnection = new SqlConnection(Settings.Default.ConexionGT);
        //SqlCommand _SqlCommand = new SqlCommand();

        public void ActualizarIntegrado(int proceso, DataSet ds)
        {
            string consultaSql = "";

            switch (proceso) {
                case 1:
                    consultaSql = "Sp_Actualizar_Integrado";
                    break;
                case 2:
                    consultaSql = "Sp_Actualizar_Integrado_TProveedor";
                    break;
                case 3:
                    consultaSql = "Sp_Actualizar_Integrado_TCliente";
                    break;
                case 4:
                    consultaSql = "Sp_Actualizar_Integrado_OCInfluencer";
                    break;
                case 5:
                    consultaSql = "Sp_Actualizar_Integrado_OCLogistico";
                    break;
                case 6:
                    consultaSql = "Sp_Actualizar_Integrado_OSVentaInfluencer";
                    break;
            }


            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Infraestructura.Properties.Settings.Default.ConexionGT;

            SqlCommand sqlCommand = new SqlCommand(consultaSql, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Details", ds.Tables[0]);
            sqlCommand.CommandTimeout = 999999999;

            try
            {
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }


        }




        public DataSet AlmacenarVentasdeServicio(DataSet ds)
        {
            string Sp = "Sp_Insertar_Ventas_de_Servicio";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Infraestructura.Properties.Settings.Default.ConexionGT;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet DsGenerico = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(Sp, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@ARTPRO", @ARTPRO);
            sqlCommand.Parameters.AddWithValue("@Details", ds.Tables[0]);
            //sqlCommand.Parameters.AddWithValue("@consilidado_id", "");
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlCommand.CommandTimeout = 999999999;




            try
            {
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter.Fill(DsGenerico);


                int CantidadSecciones = DsGenerico.Tables.Count;

                if (DsGenerico.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < CantidadSecciones; i++)
                    {
                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {
                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion"].ToString();

                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {
                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }


                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion2"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {

                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion2"].ToString();
                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {

                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }
                    }

                }


                return DsGenerico;
            }


            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }





        public DataSet AlmacenarTerceroProveedor(DataSet ds)
        {
            string Sp = "Sp_Insertar_Tercero_Proveedor";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Infraestructura.Properties.Settings.Default.ConexionGT;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet DsGenerico = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(Sp, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@ARTPRO", @ARTPRO);
            sqlCommand.Parameters.AddWithValue("@Details", ds.Tables[0]);
            //sqlCommand.Parameters.AddWithValue("@consilidado_id", "");
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlCommand.CommandTimeout = 999999999;




            try
            {
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter.Fill(DsGenerico);

                //MessageBox.Show("Ejecuto la consulta sql");

                int CantidadSecciones = DsGenerico.Tables.Count;

                if (DsGenerico.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < CantidadSecciones; i++)
                    {
                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {
                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion"].ToString();

                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {
                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }


                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion2"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {

                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion2"].ToString();
                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {

                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }
                    }

                }


                return DsGenerico;
            }


            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }



        public DataSet AlmacenarTerceroCliente(DataSet ds)
        {
            string Sp = "Sp_Insertar_Tercero_Cliente";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Infraestructura.Properties.Settings.Default.ConexionGT;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet DsGenerico = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(Sp, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@ARTPRO", @ARTPRO);
            sqlCommand.Parameters.AddWithValue("@Details", ds.Tables[0]);
            //sqlCommand.Parameters.AddWithValue("@consilidado_id", "");
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlCommand.CommandTimeout = 999999999;




            try
            {
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter.Fill(DsGenerico);

                //MessageBox.Show("Ejecuto la consulta sql");

                int CantidadSecciones = DsGenerico.Tables.Count;

                if (DsGenerico.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < CantidadSecciones; i++)
                    {
                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {
                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion"].ToString();

                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {
                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }


                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion2"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {

                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion2"].ToString();
                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {

                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }
                    }

                }


                return DsGenerico;
            }


            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }


        public DataSet AlmacenarOrdenCompraInfluencer(DataSet ds)
        {
            string comandoSQL = "Sp_Insertar_Orden_Compra_Influencer";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Properties.Settings.Default.ConexionGT;

            SqlCommand sqlCommand = new SqlCommand(comandoSQL,sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Details",ds.Tables[0]);
            sqlCommand.CommandTimeout = 999999999;
            //sqlCommand.Connection = sqlConnection;


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                DataSet DsGenerico = new DataSet();

                sqlDataAdapter.Fill(DsGenerico);


                int CantidadSecciones = DsGenerico.Tables.Count;

                if (DsGenerico.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < CantidadSecciones; i++)
                    {
                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {
                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion"].ToString();

                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {
                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }


                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion2"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {

                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion2"].ToString();
                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {

                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }
                    }

                }

                return DsGenerico;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

        }


        public DataSet AlmacenarOrdenCompraLogistico(DataSet ds)
        {
            string procedimiento = "Sp_Insertar_Orden_Compra_Logistico";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Properties.Settings.Default.ConexionGT;

            SqlCommand sqlCommand = new SqlCommand(procedimiento, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Details",ds.Tables[0]);
            sqlCommand.CommandTimeout = 999999999;

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataSet DsGenerico = new DataSet();

                sqlDataAdapter.Fill(DsGenerico);



                int CantidadSecciones = DsGenerico.Tables.Count;

                if (DsGenerico.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < CantidadSecciones; i++)
                    {
                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {
                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion"].ToString();

                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {
                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }


                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion2"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {

                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion2"].ToString();
                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {

                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }
                    }

                }


                return DsGenerico;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

        }



        public DataSet AlmacenarOrdenServicioVentaInfluencer(DataSet ds)
        {
            string procedimiento = "Sp_Insertar_Orden_Servicio_Venta_Influencer";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Properties.Settings.Default.ConexionGT;

            SqlCommand sqlCommand = new SqlCommand(procedimiento,sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 999999999;
            sqlCommand.Parameters.AddWithValue("@Details",ds.Tables[0]);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataSet DsGenerico = new DataSet();

                sqlDataAdapter.Fill(DsGenerico);


                int CantidadSecciones = DsGenerico.Tables.Count;

                if (DsGenerico.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < CantidadSecciones; i++)
                    {
                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {
                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion"].ToString();

                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {
                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }


                        if (DsGenerico.Tables[i].Columns.Contains("NombreSeccion2"))
                        {
                            if (DsGenerico.Tables[i].Rows.Count > 0)
                            {

                                DsGenerico.Tables[i].TableName = DsGenerico.Tables[i].Rows[0]["NombreSeccion2"].ToString();
                                DsGenerico.Tables[i].Columns.Remove(DsGenerico.Tables[i].Columns[0]);
                            }
                            else
                            {

                                DsGenerico.Tables.Remove(DsGenerico.Tables[i]);
                            }
                        }
                    }

                }




                return DsGenerico;

            }
            catch(Exception ex)
            {
                throw ex;
            }



        }




    }
}
