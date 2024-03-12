// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int tamano = 2;
String[]nombre = new String[tamano];
int []edad = new int[tamano];
string[] cita = new string [tamano];
int opcion = 0;




menu();


void inicializar()
{
    nombre=Enumerable.Repeat("", tamano).ToArray<string>();
    cita = Enumerable.Repeat("", tamano).ToArray<string>();
    edad = Enumerable.Repeat(0, tamano).ToArray<int>();
    Console.WriteLine("El reporte ha sido inicializado");
    Console.Read();
    Console.Clear();
}
void agregar()
{
    for (int i = 0; i < nombre.Length; i++)    
    {
        Console.Write("Ingrese el Nombre");nombre[i] = Console.ReadLine();
        Console.Write("Ingrese su edad"); edad[i] =int.Parse(Console.ReadLine());

    }
   
}

void Reporte()
{
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Nombre     Edad");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("     ------------           ---------");
    for (int i = 0; i < nombre.Length; i++)

    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nombre[i]} {edad[i]}");

    }
}


void menu()
{



    do
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("*****************CONSULTORIO MEDICO*************************");
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("1- inicializar arreglos");
        Console.WriteLine("2- Ingresar Paciente");
        Console.WriteLine("3- Consultar Paciente");
        Console.WriteLine("4- Reporte");
        Console.WriteLine("5- Asignar Cita");
        Console.WriteLine("6- Salir");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("7-Digite una opcion...");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:inicializar(); break;
            case 2:agregar(); break;
            case 3: break;
            case 4: Reporte(); break;
            case 5: break;
            default:
                break;
        }
        while (opcion!=6) ;














    } while(true); 

}







