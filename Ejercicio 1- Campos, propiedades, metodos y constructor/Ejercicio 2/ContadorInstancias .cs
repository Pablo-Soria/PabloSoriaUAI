namespace Ejercicio_2
{
    public class ContadorInstancias
    {
        private static int cantidadInstancias = 0;

        public ContadorInstancias()
        {
            cantidadInstancias = cantidadInstancias + 1; 
        }

        public static void MostrarCuantosVan()
        {
            Console.WriteLine($"Hasta, se han creado {cantidadInstancias} instancias.");
        }

    }
}
