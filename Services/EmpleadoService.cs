using System;
using mvc_test.Extensions;
using mvc_test.Models;

namespace mvc_test.Services {

    public class EmpleadoService
    {

        public uint Crear(EmpleadoViewModel empleado)
        {
            if (empleado.EsMayorDeEdad())
                return 0;
            else
                return 1;
        }

    }

}