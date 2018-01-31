using System;
using mvc_test.Models;

namespace mvc_test.Services {

    public class EmpleadoService
    {

        public uint Crear(EmpleadoViewModel model)
        {
            var edad = DateTime.Today - model.FechaNacimiento.Value;
            var anios = edad.TotalDays / 365;
            if (anios < 18)
                return 0;
            else
                return 1;
        }

    }

}