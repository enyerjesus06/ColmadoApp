


public class Calculandobase
{
    
    public void Calculandosumaproducto()
    {
        //Declarar la Variable Num1, Num2, Suma, Producto.
        int Num1 = 0;
        int Num2 = 0;
        int Suma = 0;
        int Producto = 0;
        string linea = string.Empty;

        try
        {
            Console.WriteLine("digite el Num1: ");
            linea = Console.ReadLine();
            Num1 = Convert.ToInt32(linea);


            Console.WriteLine("digite el Num2: ");
            linea = Console.ReadLine();
            Num2 = Convert.ToInt32(linea);



            Suma = (Num1 + Num2);

            Producto = (Num1 * Num2);

            Console.WriteLine($"La suma es: {Suma} y el producto es: {Producto}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
        
        
        }

        

    }
}