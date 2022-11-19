System.Console.WriteLine("~~~~ Tabuada ~~~~");
System.Console.WriteLine();

Console.BackgroundColor= ConsoleColor.White;
Console.ForegroundColor= ConsoleColor.Black;


Console.Write("Digite o numero que deseja saber a tabuada: ");
Console.ResetColor();

Console.ForegroundColor= ConsoleColor.White;
int numeroDigitado = Convert.ToInt32(Console.ReadLine());
int multiplo = 1;
int resultado;

Console.ResetColor();

while (multiplo <= 10)
{
    
    Console.ForegroundColor= ConsoleColor.Green;
    resultado = multiplo * numeroDigitado;
    System.Console.WriteLine($"{numeroDigitado} X {multiplo} = {resultado}");
    multiplo++;
   Console.ResetColor(); 
}

System.Console.WriteLine("- pressione qualquer tecla para fechar");
Console.ReadKey();