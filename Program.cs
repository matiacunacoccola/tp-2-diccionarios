class Program
{
    static void Main(string[] args)
    {
       Dictionary<string,int> dicRecursos = new Dictionary <string,int> ();
        dicRecursos.Add(madera,30);
        dicRecursos.Add(hierro,10);
        dicRecursos.Add(soga,5);
        int opcion;

        do
        {
            Console.WriteLine("\n1- Ver inventario");
            Console.WriteLine("2- Actualizar stock");
            Console.WriteLine("3- Consumir un recurso");
            Console.WriteLine("4- Consultar un recurso");
            Console.WriteLine("0- Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    foreach(int clave in dicRecursos.keys)
                    {
                        console.WriteLine(dicRecursos);
                    }
                   
                    break;

                
                
            }

        } while (opcion != 0);
    }
}
