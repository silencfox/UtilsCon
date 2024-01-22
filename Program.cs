using System.Text.RegularExpressions;

namespace UtilesCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();

            int ival1;
            int ival2;
            int dval1;
            int dval2;

            string resp ="";
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
                        ival1 =Convert.ToInt32(Console.ReadLine()) ;
                        Console.WriteLine("ingrese el segundo valor ");
                        ival2 =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(calcular1.Suma(ival1, ival2));
                        break; 
                    case "3":
                        Calcular multipli = new Calcular();
                        Console.WriteLine("ingrese el primer valor ");
                        ival1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo valor ");
                        ival2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(multipli.multiplicar(ival1 , ival2));
                        break; 
                    case "4":
                        //string valor = Console.ReadLine();
                        //Console.WriteLine(valor);
                        //const string pattern = @"\D+";
                        const string pattern = @"[^\d]+";
                        
                        var input = "1111-444/222**3333333///44/ 55555";
                        var output = Regex.Split(input, pattern);
                        
                        foreach (var line in output) Console.WriteLine(line);

                        break; 
                    case "5":
                    
                        break; 
                    case "9":
                        
                        break;




                }
                Console.ReadKey();
                Console.Clear();
            }
        }



    }


}
