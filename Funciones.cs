using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1 {
    public static class Funciones {
        /// <summary>
        /// Normaliza un string, con el fin de que sea posible poder compararlo con otros.  
        /// </summary>
        /// <param name="str">El string que se desea normalizar</param>
        /// <returns>Un string sin acentos, en mayúsculas, ni espacios en blanco.</returns>
        public static string NormalizarString(string str) {
            string paso1 = new string(str
                .Normalize(NormalizationForm.FormD)
                .Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray()); // Quita acentos.
            string paso2 = paso1.ToUpper(); // Pasar todo a mayúsculas
            string paso3 = paso2.Trim(); // Cortar espacios
            string paso4 = paso3.Replace(" ", ""); // Cortar espacios, definitivamente
            return paso4;
        }
        /// <summary>
        /// Recibe un string y se fija si está vacío o no.
        /// </summary>
        /// <param name="str">El string que se quiere revisar</param>
        /// <returns>True si está vacío, False si no.</returns>
        public static bool EstaVacio(string str) {
            return str.Trim() != "";
        }
        /// <summary>
        /// Elimina todos los espacios en blanco de una cadena de texto.
        /// </summary>
        /// <param name="str">Cadena de texto a la que se le quitarán los espacios en blanco.</param>
        /// <returns>Una cadena de texto sin espacios en blanco.</returns>
        public static string EliminarEspacios(string str) {
            return string.Concat(str.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}
