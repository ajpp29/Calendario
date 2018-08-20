using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioTareas
{
    public class cTarea
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public cTarea()
        {

        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="Dia">Dia de entrega</param>
        /// <param name="Mes">Mes de entrega</param>
        /// <param name="Anio">Año de entrega</param>
        /// <param name="Materia">Materia de la tarea</param>
        /// <param name="Tarea">Especificación de la tarea</param>
        public cTarea(int Dia,int Mes, int Anio, int Materia, string Tarea)
        {
            iDia = Dia;
            iMes = Mes;
            iAnio = Anio;
            sMateria = ObtenerMateria(Materia);
            sTarea = Tarea;
            bCompletada = false;
        }

        public int iDia { get; set; }
        public int iMes { get; set; }
        public int iAnio { get; set; }
        public string sMateria { get; set; }
        public string sTarea { get; set; }
        public bool bCompletada { get; set; }

        /// <summary>
        /// Obtiene el nombre de la materia de la tarea
        /// </summary>
        /// <param name="Materia">Clave de la materia</param>
        /// <returns>Nombre de la materia</returns>
        public string ObtenerMateria(int Materia)
        {
            switch (Materia)
            {
                case 0:
                    return "Estadistica Inferencial";

                case 1:
                    return "Estructura de Datos II";

                case 2:
                    return "Fisica III";

                case 3:
                    return "Ingles";

                case 4:
                    return "Juventud y Vida Saludable";

                case 5:
                    return "Manejo e Implementacion de Archivos";

                case 6:
                    return "Organización Computacional";

                default:
                    return "No se especifico";
            }
        }
    }
}
