using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.MASSIMINO.LibreriaClases
{
    class CustomExcepciones
    {

    }

    class SinAlumnosRegistradosExcepcion : Exception
    {
        public override string Message => "Sin Alumnos";
    }
}
