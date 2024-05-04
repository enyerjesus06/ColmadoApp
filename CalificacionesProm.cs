





    public class Calculandobase
    {

        public void Calculandosumaproducto()
        {
            //Declarar la Variable Num1, Num2, Num3, Producto.
            decimal Num1 = 0;
            decimal Num2 = 0;
            decimal Num3 = 0;
            decimal division = 3;

            decimal Producto = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Digite la Primera Calificación: ");
                linea = Console.ReadLine();
                Num1 = Convert.ToInt32(linea);


                Console.WriteLine("Digite la Segunda Calificación: ");
                linea = Console.ReadLine();
                Num2 = Convert.ToInt32(linea);

                Console.WriteLine("Digite la Tercera Calificación: ");
                linea = Console.ReadLine();
                Num3 = Convert.ToInt32(linea);



                if ((Num1 + Num2 + Num3) > 30)
                {
                    Console.WriteLine($" Las Calificaciones no pueden sobrepasar la cifra de 10 digitos.");
                    return;

                }


                Producto = ((Num1 + Num2 + Num3) / division);

                Console.WriteLine($"El promedio es: {Producto}");

                if (Producto >= 7)
                {

                    Console.WriteLine($"El alumno ha sido Promosionado.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            
            }



        }
    }