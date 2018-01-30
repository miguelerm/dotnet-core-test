using System;
using System.Collections.Generic;

namespace mvc_test.Models {

    public class EmpleadoViewModel
    {
        public int Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public IEnumerable<long> Telefonos { get; set; }
    }

}