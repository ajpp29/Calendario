using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioTareas
{
    public class Nodo
    {
        /// <summary>
        /// Costructor de la clase
        /// </summary>
        public Nodo()
        {

        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="tarea">Tarea para el nodo</param>
        /// <param name="siguiente">Nodo que le sigue</param>
        public Nodo(cTarea tarea,Nodo siguiente)
        {
            tTarea = tarea;
            nSiguiente = siguiente;
        }


        public cTarea tTarea { get; set; }
        public Nodo nSiguiente { get; set; }
    }

    class cListaEnlazada
    {
        public Nodo nInicio;
        int iElementos;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public cListaEnlazada()
        {
            this.nInicio = null;
            this.iElementos = 0;
        }

        /// <summary>
        /// Funcion para validar si la lista contiene un elemento
        /// </summary>
        /// <returns>Verdadero, si esta vacia la lista, y falso, si tiene al menos un elemento</returns>
        public bool listaVacia()
        {
            return (this.nInicio == null);
        }

        /// <summary>
        /// Obtiene el ultimo nodo de la lista
        /// </summary>
        /// <returns>ultimo nodo de la lista</returns>
        public Nodo ObtenerUltimo()
        {
            Nodo nAux = nInicio;

            while (nAux.nSiguiente != null)
            {
                nAux = nAux.nSiguiente;
            }
            return nAux;
        }

        /// <summary>
        /// Encuentra el nodo de la tarea especificada
        /// </summary>
        /// <param name="tarea">Tarea a buscar</param>
        /// <returns>Nodo de la tarea</returns>
        public Nodo ObtenerNodo(cTarea tarea)
        {
            Nodo nAux = nInicio;

            while (nAux.tTarea != tarea)
            {
                nAux = nAux.nSiguiente;

                if (nAux == null)
                {
                    break;
                }
            }

            return nAux;
        }

        /// <summary>
        /// Obtiene el nodo anterior al nodo actual
        /// </summary>
        /// <param name="Actual">Nodo actual</param>
        /// <returns>Nodo anterior</returns>
        public Nodo ObtenerAnterior(Nodo Actual)
        {
            Nodo nAux = nInicio;

            while (nAux.nSiguiente != Actual)
            {
                nAux = nAux.nSiguiente;
            }

            return nAux;
        }

        /// <summary>
        /// Inserta el nodo en la ultima posicion de la lista
        /// </summary>
        /// <param name="nNuevo">Nodo a ingresar</param>
        public void InsertarNodo(Nodo nNuevo)
        {
            Nodo nAux = ObtenerUltimo();
            iElementos++;

            nAux.nSiguiente = nNuevo;
        }
         
        public void EliminarNodo(Nodo nEliminar)
        {
            Nodo nUltimo = ObtenerUltimo();
            Nodo nAux;

            if (nInicio == nEliminar)
            {
                nInicio = nInicio.nSiguiente;
            }
            else if (nUltimo == nEliminar)
            {
                nAux = ObtenerAnterior(nUltimo);
                nAux.nSiguiente = null;
            }
            else
            {
                nAux = ObtenerNodo(nEliminar.tTarea);
                Nodo nTemp = ObtenerAnterior(nAux);
                nTemp.nSiguiente = nAux.nSiguiente;
                nAux = null;
            }
            
        }
        
    }
}
