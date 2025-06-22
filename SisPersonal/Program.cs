using EspacioEmpleado;
using System.Globalization;

Empleado[] empleados = new Empleado[3];

for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();
    Console.WriteLine($"Ingrese los datos del empleado {i + 1}:");

    Console.Write("Nombre: ");
    empleados[i].Nombre = Console.ReadLine();

    Console.Write("Apellido: ");
    empleados[i].Apellido = Console.ReadLine();

    Console.Write("Fecha de Nacimiento (dd/mm/yyyy): ");
    empleados[i].FechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Estado Civil (S)Soltero (C)Casado (V)Viudo (D)Divorciado: ");
    empleados[i].EstadoCivil = char.Parse(Console.ReadLine().ToUpper());

    Console.Write("Fecha de Ingreso (dd/mm/yyyy): ");
    empleados[i].FechaDeIngreso = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Sueldo Básico: ");
    empleados[i].SueldoBasico = double.Parse(Console.ReadLine());

    Console.Write("Cargo (0)Auxiliar (1)Administrativo (2)Ingeniero (3)Especialista (4)Investigador: ");
    if (int.TryParse(Console.ReadLine(), out int valorCargo) && Enum.IsDefined(typeof(cargos), valorCargo))
    {
        empleados[i].Cargo = (cargos)valorCargo;
    }
    else
    {
        Console.WriteLine("Cargo inválido. Se asigna Auxiliar por defecto.");
        empleados[i].Cargo = cargos.Auxiliar;
    }
}

double totalSalario = 0;
foreach (Empleado empleado in empleados)
{
    totalSalario += empleado.CalcularSalario();
}
Console.WriteLine($"\nEl total pagado en concepto de salarios es: ${totalSalario}");
