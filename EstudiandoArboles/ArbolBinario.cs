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

        //BUSCAR UN ELEMNTO EN EL ARBOL (TRUE SI EXISTE)
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(Raiz,  valor);
        }

        private bool BuscarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            
                return false;

                if(valor == nodo.Valor)
                    return true;
                else if (valor < nodo.Valor)
                    return BuscarRecursivo(nodo.Izquierdo, valor);
                else
                    return BuscarRecursivo(nodo.Derecho, valor);
        }

        //ELIMINAR UN VALOR DEL ARBOL
        public void Eliminar(int valor)
        {
            Raiz = EliminarRecursivo(Raiz, valor);
        }

        private Nodo EliminarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return null;

            if(valor < nodo.Valor)
            {
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor);
            }

            else if(valor > nodo.Valor)
            {
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor);
            }
            else
            {
                //CASO 1: SIN HIJOS
                if(nodo.Izquierdo == null && nodo.Derecho == null)
                {
                    return null;
                }

                //CASO 2: UN SOLO HIJO
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                //CASO 3: DOS HIJOS -> BUSCAR EL SUCESOR MINIMO
                Nodo sucesor = EncontrarMinimo(nodo.Derecho);
                nodo.Valor = sucesor.Valor;
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, sucesor.Valor);
            }
            return nodo;
        }

        private Nodo EncontrarMinimo(Nodo nodo)
        {
            while(nodo.Izquierdo != null)
            {
                nodo = nodo.Derecho;
            }
            return nodo;
        }
    }
}
