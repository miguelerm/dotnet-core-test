using System;

namespace mvc_test.Extensions {

    public static class DateTimeExtensions
    {

        public static bool EsMayorDeEdad(this DateTime? fecha) {
            if (fecha == null) return false;
            return fecha.Value.EsMayorDeEdad();
        }

        public static bool EsMayorDeEdad(this DateTime fecha) {
            var edad = DateTime.Today - fecha;
            var anios = edad.TotalDays / 365;
            if (anios < 18)
                return false;
            else
                return true;
        }

    }

}