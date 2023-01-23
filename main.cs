// Created by: Allen Li
// Created on: Oct 2022
//
// This program displays, "Multiplication Calculator"

using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        double firstNumber;
        double secondNumber;
        Console.Write("Multiplication Calculator");
        Console.WriteLine("");
        Console.Write("Input two number to find out the product");
        Console.WriteLine("");
        Console.Write("Input the first number:");
        firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the second number: ");
        secondNumber = Convert.ToDouble(Console.ReadLine());
        double product = 0;
        double counter = 0;
        while (counter < Math.Abs(secondNumber))
        {
            counter++;
            product = product + Math.Abs(firstNumber);
        }
        if ((firstNumber < 0 && secondNumber > 0) || (secondNumber < 0 && firstNumber > 0))
        {
            Console.WriteLine("-" + product);
        }
        else
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("");
        Console.Write("/Done");
    }
}