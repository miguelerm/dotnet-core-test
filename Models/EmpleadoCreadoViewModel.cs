using System;
using System.Collections.Generic;

namespace mvc_test.Models {

    public class EmpleadoCreadoViewModel
    {
        public bool Success { get; }
        public string Message { get; set; }

        public EmpleadoCreadoViewModel(bool success)
        {
            Success = success;
        }
    }

}