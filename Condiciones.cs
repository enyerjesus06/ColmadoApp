


    public class Calculos
    {

        public void CalcularCondicionales()
        {
            //Declarar la variables Num1, Num2, Suma, Resta.
            decimal Num1 = 0;
            decimal Num2= 0;
            int Suma= 0;
            int Resta = 0;
            decimal Producto = 0;
            decimal Division = 0;
            string linea = string.Empty;

          try
          {
              Console.WriteLine("Por favor introduce un Número:");
              linea = Console.ReadLine();
              Num1 = Convert.ToInt32(linea);

              Console.WriteLine("Por favor introduce un Número:");
              linea = Console.ReadLine();
              Num2 = Convert.ToInt32(linea);



            Suma = ((int)(Num1 + Num2));
            Resta = ((int)(Num1 - Num2));

            Producto = ((int)(Num1 * Num2));
            Division = (Num1 / Num2);

            if (Num1 >= Num2)
              {

                  Console.WriteLine($"La suma es: {Suma} y La diferencia es: {Resta} ");

              }
            else if (Num2 >= Num1)

              {

                  Console.WriteLine($"El producto es: {Producto} Y la division es: {Division} ");

              }



          }
          catch (Exception ex)
          {
            Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} ");
          }

        }
    }

