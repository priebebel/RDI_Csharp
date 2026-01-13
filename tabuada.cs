using System;

public class Program
{
    public static void Main()
    {
        // Solicita um número inteiro ao usuário
        Console.WriteLine("Digite um número inteiro para ver a tabuada:");
        int x = int.Parse(Console.ReadLine());

        // Laço for para exibir a tabuada de 1 até 10
        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine(x + " x " + contador + " = " + (x * contador));
        }

        Console.WriteLine("Obrigada :)");
    }
}