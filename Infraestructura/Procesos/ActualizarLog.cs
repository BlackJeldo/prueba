using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Procesos
{
    public class ActualizarLog : Tareas
    {
        static Infraestructura.Procesos.Logs _Logs = new Infraestructura.Procesos.Logs();
        public void ValidarError(StringBuilder Error)
        {
            if (Error.ToString() != string.Empty)
            {
                _Logs.ActualizarLog("FechaFinWebServiceSiesa", "GETDATE()", 0, Error.ToString());
                _Logs.ActualizarLog("WebServiceSiesa", "0", 0, Error.ToString());
                _Logs.ActualizarLog("FechaFin", "GETDATE()", 0, Error.ToString());
                _Logs.ActualizarLog("EjecucionCompleta", "GETDATE()", 0, Error.ToString());

            }
            else
            {
                _Logs.ActualizarLog("FechaFinWebServiceSiesa", "GETDATE()", 1, string.Empty);
                _Logs.ActualizarLog("WebServiceSiesa", "1", 1, string.Empty);
                _Logs.ActualizarLog("FechaFin", "GETDATE()", 1, string.Empty);
                _Logs.ActualizarLog("EjecucionCompleta", "GETDATE()", 1, Error.ToString());
            }
        }
        public void ValidarErrorMov(String Errores, int estado)
        {
            if (estado == 0)
            {
                _Logs.ActualizarLog("FechaFinWebServiceSiesa", "GETDATE()", 0, Errores.ToString());
                _Logs.ActualizarLog("WebServiceSiesa", "0", 0, Errores.ToString());
                _Logs.ActualizarLog("FechaFin", "GETDATE()", 0, Errores.ToString());

            }
            else
            {
                _Logs.ActualizarLog("FechaFinWebServiceSiesa", "GETDATE()", 1, Errores.ToString());
                _Logs.ActualizarLog("WebServiceSiesa", "1", 1, Errores.ToString());
                _Logs.ActualizarLog("FechaFin", "GETDATE()", 1, Errores.ToString());

            }
        }
    }
}
