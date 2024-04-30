


    public class Calculareverything
    {

        public void CalcularSueldo()
        {
            //Declarar la variable horasTrabajadas, costoHoras, Sueldo.
            int horasTrabajadas = 0;
            int costoHoras = 0;
            decimal Sueldo = 0;
            decimal Impuesto = 0.18m;
            decimal valorImpuesto = 0.25m;
            decimal SueldoBruto = 0;
            string linea = string.Empty;

        try
        {
            Console.WriteLine("digite las Horas Trabajadas:");
            linea = Console.ReadLine();
            horasTrabajadas = Convert.ToInt32(linea);

            Console.WriteLine("digite el Costo Por Hora:");
            linea = Console.ReadLine();
            costoHoras = Convert.ToInt32(linea);

            SueldoBruto = (horasTrabajadas * costoHoras);
            Console.WriteLine($"Su sueldo en Bruto es de:{SueldoBruto}");

            Sueldo = (horasTrabajadas * costoHoras);

            if (Sueldo > 12000 && Sueldo <= 20999) 
            {
                var valueImpuesto = (Sueldo * Impuesto);
                Sueldo = (Sueldo - valueImpuesto);
                Console.WriteLine($"Pero el Impuesto aplicado a los sueldos sobre los 12,000 pesos es de 0.18% por ende el Impuesto aplicado a su sueldo es de: {valueImpuesto} ");
                
            }
            else if (Sueldo >= 21000)
            {
                decimal valueoverImpuesto = (Sueldo * valorImpuesto);
                Sueldo = (Sueldo - valueoverImpuesto);
                Console.WriteLine($"Pero el Impuesto aplicado a los sueldos sobre los 21,000 pesos es de 0.25% por ende el Impuesto aplicado a su sueldo es de: {valueoverImpuesto} "); 

            } 
            else if (Sueldo <=11999)
                {
                Console.WriteLine($"Su sueldo es inferior a 12,000 asi que no se aplica ningun Impuesto");

            }

            Console.WriteLine($"Por lo tanto su sueldo es de: {Sueldo}");


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} ");
        }

        }
    }

