using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Procesos
{
    public class ConsumoGT: Configuraciones
    {
        ActualizarLog _Alog = new ActualizarLog();
        public string Insertar(DataSet DS, string conector, int codigo, string rutaplano, string cia)
        {

            try
            {
               
                var localInsercion = new ConsumoGTWEB.wsGenerarPlano();
                var respuesta = "";
                string RutaPlano = @rutaplano;
                respuesta = localInsercion.ImportarDatosDS(codigo, conector, 2, cia, "gt", "gt", DS, ref RutaPlano);

                return respuesta;

            }
            catch (Exception Ex)
            {

                Error.Append($"Error en el proceso=> {Ex.InnerException.Message}-{Ex.Message}\n");
                _Alog.ValidarError(Error);
                return Ex.Message.ToString();

            }


        }
    }
}
