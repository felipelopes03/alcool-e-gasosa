﻿Console.Clear();

Console.WriteLine("--- Alcool ou Gasolina? ---");

double alcool;
double gasolina;

Console.WriteLine("Digite o preço do alcool (R$):");
alcool = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o preço da gasolina (R$):");
gasolina = Convert.ToDouble(Console.ReadLine());

Calcular();

void Calcular()
{
    double percentual = (alcool / gasolina) * 100;

    Console.WriteLine("O preço do alcool corresponde a " + percentual.ToString("n2") + "% do preço da gasolina.");

    Console.ForegroundColor = ConsoleColor.Green;
    if (percentual > 70)
    {
        Console.WriteLine("Recomendação: Abasteça com gasolina.");
    }
    else 
    {
        Console.WriteLine("Recomendação: Abasteça com alcool.");
    }
    Console.ResetColor();
}