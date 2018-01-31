using System;
using mvc_test.Models;

namespace mvc_test.Extensions {

    public static class EmpleadoViewModelExtensions
    {

        public static bool EsMayorDeEdad(this EmpleadoViewModel empleado) {
            return empleado.FechaNacimiento.EsMayorDeEdad();
        }
    }

}