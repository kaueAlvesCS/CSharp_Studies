using System;

public class AdivinheONumero
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;
        int palpite;

        Console.WriteLine("--- Jogo: Adivinhe o Número! ---");
        Console.WriteLine("Eu pensei em um número entre 1 e 100. Você consegue adivinhar qual é?");
        Console.WriteLine("----------------------------------");

        while (true)
        {
            Console.Write("Digite seu palpite: ");
            
            // 1. Validação da entrada do usuário
            if (!int.TryParse(Console.ReadLine(), out palpite))
            {
                Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro.");
                Console.WriteLine("----------------------------------");
                continue;
            }

            // Incrementa o contador de tentativas apenas para palpites válidos
            tentativas++;

            // 2. Lógica principal do jogo com dicas
            if (palpite == numeroSecreto)
            {
                Console.Clear();
                Console.WriteLine("🎉 PARABÉNS! Você acertou! 🎉");
                Console.WriteLine($"O número secreto era: {numeroSecreto}");
                Console.WriteLine($"Você conseguiu em {tentativas} tentativas.");
                break;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("Errado! O número secreto é MAIOR que o seu palpite.");
            }
            else
            {
                Console.WriteLine("Errado! O número secreto é MENOR que o seu palpite.");
            }
            
            Console.WriteLine($"Tentativas até agora: {tentativas}");
            Console.WriteLine("----------------------------------");
        }

        Console.WriteLine("\nObrigado por jogar!");
    }
}
