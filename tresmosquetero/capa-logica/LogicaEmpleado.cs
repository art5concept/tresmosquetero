using System;
using System.Collections.Generic;
using System.Text;

namespace tresmosquetero.capa_logica
{
    internal class LogicaEmpleado
    {
        public int ID { get; set; }
        public string NombreEmpleado { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Departamento { get; set; }
        public string CorreoElectronico { get; set; }
        public required byte[] FotoEmpleado { get; set; }
    }
}


