using System;

namespace mvc_test.Extensions {

    public static class StringExtensions
    {

        public static string Reverse(this string text) {
            var nuevoString = "";

            for(var i = text.Length - 1; i > 0; i--)
            {
                nuevoString += text[i];
            }

            return nuevoString;
        }
    }

}