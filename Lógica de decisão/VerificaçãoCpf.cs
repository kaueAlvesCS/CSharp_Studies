using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu CPF (apenas números): ");
        string cpf = Console.ReadLine();

        //Validação do Tamanho
        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF inválido! O CPF deve conter exatamente 11 dígitos.");
            return; // Encerra o programa
        }

        //Validação de Caracteres (verifica se todos são números)
        foreach (char c in cpf)
        {
            if (!char.IsDigit(c))
            {
                Console.WriteLine("CPF inválido! O CPF deve conter apenas números.");
                return;
            }
        }

        //Validação de Dígitos Repetidos
        if (cpf.All(c => c == cpf[0]))
        {
            Console.WriteLine("CPF inválido! Não pode ser uma sequência de dígitos iguais.");
            return;
        }

        // Se o programa chegou até aqui, o CPF passou nas validações básicas.
        Console.WriteLine("\nFormato básico do CPF é válido!");
        Console.WriteLine("CPF processado com sucesso!");
    }
}
