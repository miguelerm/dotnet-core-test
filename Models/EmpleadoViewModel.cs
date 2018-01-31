using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvc_test.Models {

    public class EmpleadoViewModel
    {
        [Required]
        [RegularExpression("[a-zA-Z]+")]
        [MaxLength(5)]
        public string Nombre { get; set; }

        [Required ( ErrorMessage = "Falta la fecha de nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        public IEnumerable<long> Telefonos { get; set; }
    }

}