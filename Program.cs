﻿// Para digitar uma mensagem no terminal
Console.WriteLine("Bem vindo a nossa calculadora simples!\n");
// Criando uma variável do tipo número inteiro onde o valor é de acordo com o que o usuário digitar
Console.Write("Escreva um número para iniciar o cálculo: ");
// Toda vez que formos usar um valor int que entra dentro do terminal precisamos usar o ToInt32
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O primeiro número escolhido foi de valor: {n1}\n");

Console.WriteLine("Escreva o segundo numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O primeiro número escolhido foi de valor: {n2}\n");

Console.WriteLine("Escreva a operação que você quer realizar: ");
string operador = Console.ReadLine();

switch(operador)
{
    case "mais":
        Console.WriteLine("Você escolheu soma!\n");
        Console.WriteLine($"O resultado entre {n1} e {n2} ficará {n1 + n2}");
        break;
    case "menos":
        Console.WriteLine("Você escolheu Subtração!\n");
        Console.WriteLine($"O resultado entre {n1} e {n2} ficará {n1 - n2}");
        break;
    case "vezes":
        Console.WriteLine("Você escolheu multiplicação!\n");
        Console.WriteLine($"O resultado entre {n1} e {n2} ficará {n1 * n2}");
        break;
    case "dividido":
        Console.WriteLine("Você escolheu divisão!\n");
        Console.WriteLine($"O resultado entre {n1} e {n2} ficará {n1 / n2}");
        break;
}