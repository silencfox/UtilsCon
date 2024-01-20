namespace UtilesCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();

            int val1 = 5, val2 = 3;

            Console.WriteLine(calcular.Suma(val1, val2));
            string resp="";
            while (resp != "0")
            {
                Console.WriteLine("******  ELIGE UNA OPCION  ******");
                Console.WriteLine("******  1.- OPCION  ******");
                Console.WriteLine("******  2.- SUMAR  ******");
                Console.WriteLine("******  3.- OPCION  ******");
                Console.WriteLine("******  4.- OPCION  ******");
                Console.WriteLine("******  5.- OPCION  ******");
                Console.WriteLine("******  6.- OPCION  ******");
                Console.WriteLine("******  7.- OPCION  ******");
                Console.WriteLine("******  8.- OPCION  ******");
                Console.WriteLine("******  9.- OPCION  ******");

                Console.Write("Elige una opcion: ");
                resp= Console.ReadLine();

                switch (resp)
                {
                    case "1":
                        Console.Write($"La opcion selecionada es {resp}");
                        break; 

                    case "2":
                        Calcular calcular1 = new Calcular();
                        Console.WriteLine("ingrese el primer valor ");
                        Console.WriteLine(calcular1.Suma(val1, val2));
                        calcular1.Suma();
                        break; 
                    case "3":
                    
                        break; 
                    case "4":
                            break; 
                    case "5":
                    
                        break; 
                    case "6":
                    
                        break;




                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }


}
