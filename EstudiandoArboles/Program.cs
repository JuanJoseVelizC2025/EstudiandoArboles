using EstudiandoArboles;

class Program
{
    static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();

        //INSERTAR VALORES EN EL ARBOL
        arbol.Insertar(10);
        arbol.Insertar(5);
        arbol.Insertar(15);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(18);

        Console.WriteLine("RECORRIDO INORDER (DE MENOR A MAYOR):  ");
        arbol.RecorrerInorden(arbol.Raiz);
        Console.WriteLine();


        Console.WriteLine("RECORRIDO PREORDEN:  ");
        arbol.RecorrerPreorden(arbol.Raiz);
        Console.WriteLine();

        Console.WriteLine("RECORRIDO POSTORDEN:  ");
        arbol.RecorrerPostOrden(arbol.Raiz);
        Console.WriteLine();

        Console.WriteLine("¿EXISTE EL 7?  " + (arbol.Buscar(7) ? "SI" : "NO"));
        Console.WriteLine("¿EXISTE EL 20?  " + (arbol.Buscar(20) ? "SI" : "NO"));

        Console.WriteLine("\nELIMINA EL NODO 15...");
        arbol.Eliminar(15);

        Console.WriteLine("INORDEN DESPUES DE ELIMINAR 15:  ");
        arbol.RecorrerInorden(arbol.Raiz);
        Console.WriteLine();

    }

}


