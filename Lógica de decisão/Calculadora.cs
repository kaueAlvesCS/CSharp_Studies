using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao sistema de tarifas de transporte!");
        Console.Write("Qual a distância da corrida em km? ");
        double distancia = double.Parse(Console.ReadLine());
        
        Console.Write("Tempo estimado da corrida em minutos: ");
        int tempo = int.Parse(Console.ReadLine()); 
        
        Console.Write("Em que hora a corrida foi solicitada (0-23)? ");
        int horaDia = int.Parse(Console.ReadLine());
        
        Console.Write("Tipo de veículo (Básico, Conforto, Executivo): ");
        string tipoCarro = Console.ReadLine().ToLower();
        
        double tarifaBase = 0;
        double custoKm = 0;
        double custoMin = 0;
        
        switch(tipoCarro)
        {
            case "basico":
                tarifaBase = 4.50;
                custoKm = 1.50;
                custoMin = 0.25;
                break;
                
            case "conforto":
                tarifaBase = 6.00;
                custoKm = 1.80;
                custoMin = 0.35;
                break;
                
            case "executivo":
                tarifaBase = 8.00;
                custoKm = 2.20;
                custoMin = 0.45;
                break;
                
            default:
                Console.WriteLine("\nErro: Tipo de veículo inválido. Encerrando programa.");
                return;
        }
        
        double precoBruto = tarifaBase + (distancia * custoKm) + (tempo * custoMin);
        
        bool ehHorarioDePico = (horaDia >= 7 && horaDia <= 9) || (horaDia >= 17 && horaDia <= 19);

        if(ehHorarioDePico)
        {
            precoBruto *= 1.20;
        }
        
        if(precoBruto < 8.00)
        {
            precoBruto = 8.00;
        }
        
        Console.WriteLine("\n--- Resumo da Corrida ---");
        Console.WriteLine($"Tipo de Veículo: {tipoCarro}");
        Console.WriteLine($"Preço Final da Corrida: {precoBruto:F2}");
    }
}
