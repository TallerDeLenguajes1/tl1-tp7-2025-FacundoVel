using EspacioCalculadora;

Calculadora calculadora1 = new Calculadora();
int opcion;

    Console.WriteLine("--CALCULADORA--");
do
{
    Console.WriteLine($"Resultado actual: {calculadora1.Resultado}");
    Console.WriteLine("Seleccione una operación:");
    Console.WriteLine("1 - Sumar || 2 - Restar || 3 - Multiplicar || 4 - Dividir || 5 - Limpiar || 0 - Salir");

    string? entrada = Console.ReadLine();
    bool valido = int.TryParse(entrada, out opcion);

    if (valido)
    {
        if (opcion >= 1 && opcion <= 4)
        {
            
            string? inputNumero = Console.ReadLine();
            if (double.TryParse(inputNumero, out double numero))
            {
                switch (opcion)
                {
                    case 1:
                        calculadora1.Sumar(numero);
                        break;
                    case 2:
                        calculadora1.Restar(numero);
                        break;
                    case 3:
                        calculadora1.Multiplicar(numero);
                        break;
                    case 4:
                        calculadora1.Dividir(numero);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida. Debe ser un número.");
            }
        }
        else if (opcion == 5)
        {
            calculadora1.Limpiar();
            Console.WriteLine("Resultado reestablecido a 0.");
        }
        else if (opcion == 0)
        {
            Console.WriteLine("Saliendo...");
        }
        else
        {
            Console.WriteLine("Opcion no válida.");
        }
    }
    else
    {
        Console.WriteLine("Debe ingresar un numero del menu.");
    }

} while (opcion != 0);
