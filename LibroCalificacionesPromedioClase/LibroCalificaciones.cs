using System;
using System.Collections.Generic;
using System.Text;

namespace LibroCalificacionesPromedioClase
{
    public class LibroCalificaciones
    {
        private string nombreCurso; // nombre del curso que representa este LibroCalificaciones

        public LibroCalificaciones(string nombre)
        {
            NombreCurso = nombre; // inicializa nombreCurso usando la propiedad
        }

        // propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        } // fin de la propiedad NombreCurso

        // muestra un mensaje de bienvenida para el usuario de LibroCalficaciones
        public void MostrarMensaje()
        {
            // la propiedad NombreCurso obtiene el nombre del curso
            Console.WriteLine("Bienvenido al libro de calificaciones de\n{0}!\n", NombreCurso);
            // fin del método MostrarMensaje
        }

        // determina el promedio de la clase con base en las 10 calificaciones introducidas por el usuario
        public void DeterminarPromedioClase()
        {
            int total; // suma de las calificaciones introducidas por el usuario
            int contadorCalif; // número de la siguiente calificación a introducir
            int calificacion; // valor de la calificación introducida por el usuario
            int promedio; // promedio de las calificaciones

            // fase de inicialización
            total = 0; // inicializa el total
            contadorCalif = 1; // inicializa el contador del ciclo

            // fase de procesamiento
            while (contadorCalif <= 10) // itera 10 veces
            {
                Console.Write("Escriba calificación: "); // mensaje para el usuario
                calificacion = Convert.ToInt32(Console.ReadLine()); // lee calificación
                total = total + calificacion; // suma la calificación al total
                contadorCalif = contadorCalif + 1; // incrementa el contador en 1
            } // fin de while

            // fase de terminación
            promedio = total / 10; // división entera produce resultado entero

            // muestra el total y el promedio de las calificaciones
            Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
            Console.WriteLine("El promedio de la clase es {0}", promedio);
        }
    }
}