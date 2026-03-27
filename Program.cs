class Program
{
    static void Main(string[] args)
    {
       Dictionary<string,int> dicRecursos = new Dictionary <string,int> ();
        dicRecursos.Add("madera",30);
        dicRecursos.Add("hierro",10);
        dicRecursos.Add("soga",5);
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
                    foreach(string clave in dicRecursos.Keys)
                    {
                        Console.WriteLine(clave + ": " + dicRecursos[clave]);
                    }
                   
                    break;

               case 2:
                   Console.WriteLine("Ingrese el recurso a actualizar:");
                   string recursoActualizar = Console.ReadLine();
                   Console.WriteLine("Ingrese la cantidad a sumar:");
                   int cantidadSumar = int.Parse(Console.ReadLine());
                
                   if (dicRecursos.ContainsKey(recursoActualizar))
                    {
                    dicRecursos[recursoActualizar] += cantidadSumar;
                    }
                     else
                      {
                         dicRecursos.Add(recursoActualizar, cantidadSumar);
                      }
                    break;

              case 3:
                  Console.WriteLine("Ingrese el recurso a consumir:");
                  string recursoConsumir = Console.ReadLine();
                  Console.WriteLine("Ingrese la cantidad a consumir:");
                  int cantidadConsumir = int.Parse(Console.ReadLine());

                 if (dicRecursos.ContainsKey(recursoConsumir))
                 {
                    dicRecursos[recursoConsumir] -= cantidadConsumir;

                if (dicRecursos[recursoConsumir] < 5)
                {
                    Console.WriteLine("Alerta: rebastecer " + recursoConsumir);
                }
                 }
                   else
                  {
                      Console.WriteLine("El recurso no existe.");
                  }
                  break;

                 case 4:
                    Console.WriteLine("Ingrese el recurso a consultar:");
                    string recursoConsultar = Console.ReadLine();

                  if (dicRecursos.ContainsKey(recursoConsultar))
                  {
                     Console.WriteLine(recursoConsultar + ": " + dicRecursos[recursoConsultar]);
                  }
                 else
                 {
                     Console.WriteLine("El recurso no existe.");
                 }
            
             break;
                
                
            }

        } while (opcion != 0);
    }
}
