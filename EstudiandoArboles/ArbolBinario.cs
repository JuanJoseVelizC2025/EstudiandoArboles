using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiandoArboles
{
    public class ArbolBinario
    {
        public Nodo Raiz;

        public ArbolBinario() 
        {
            Raiz = null;
        }

        //ACA SERA PUBLICO EL METODO PARAR INSERTAR UN VALOR
        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        //METODO RECURSIVO PARA INSERTAR UN NUEVO NODO
        private Nodo InsertarRecursivo(Nodo actual, int valor)
        {
            if(actual == null)
            {
                return new Nodo(valor);
            }
            if (valor < actual.Valor)
            {
                actual.Izquierdo = InsertarRecursivo(actual.Izquierdo, valor);

            }
            else if(valor > actual.Valor)
            {
                actual.Derecho = InsertarRecursivo(actual.Derecho, 
                    valor);
            }
            return actual;
        }

        //METODOS PARA LE RECORRIDO DEL ARBOL
        //RECORRIDO INORDEN izquierda, raiz, derecha
        public void RecorrerInorden(Nodo nodo)
        {
            if(nodo != null)
            {
                RecorrerInorden(nodo.Izquierdo);
                Console.WriteLine(nodo.Valor + " ");
                RecorrerInorden(nodo.Derecho);
            }
        }

        //RECORRIOD PREORDEN raiz, izquierda, derecha
        public void RecorrerPreorden(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.WriteLine(nodo.Valor + " ");
                RecorrerPreorden(nodo.Izquierdo);
                RecorrerPreorden(nodo.Derecho);
            }
        }
        //RECORRIDO POSTORDEN izquierda, derecha, raiz
        public void RecorrerPostOrden(Nodo nodo)
        {
            if(nodo!= null)
            {
                RecorrerPostOrden(nodo.Izquierdo);
                RecorrerPostOrden(nodo.Derecho);
                Console.WriteLine(nodo.Valor + " ");
            }
        }
    }
}
