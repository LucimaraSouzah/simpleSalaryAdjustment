using System;
public class ReajusteSalarial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do salário: ");
        double salario = double.Parse(Console.ReadLine());
        salario = salario + (salario * 0.1);
        Console.WriteLine("Com o reajuste, o salário será: " + salario);
    }
}