using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //ENTRADA DE DADOS
        Console.Write("Qual o valor total da compra? ");
        double total = double.Parse(Console.ReadLine());
        
        Console.Write("Qual o código do cupom? ");
        string coupon = Console.ReadLine().ToUpper(); 
        
        Console.Write("Qual a categoria do produto (Eletronicos, Livros, Vestuario)? ");
        string productType = Console.ReadLine().ToLower();
        
        Console.Write("Você é um novo cliente? (S/N): ");
        char isNew = char.Parse(Console.ReadLine().ToUpper());

        double originalTotal = total;
        double frete = 25.00;
        bool cupomAplicado = false;
        string mensagemStatus = "";

        //LÓGICA DE VALIDAÇÃO
        switch (coupon)
        {
            case "PROMO10":
                if (productType == "eletronicos")
                {
                    mensagemStatus = "Desconto não aplicável para a categoria Eletrônicos.";
                }
                else if (total >= 50)
                {
                    total *= 0.90;
                    cupomAplicado = true;
                    mensagemStatus = "Cupom PROMO10 aplicado com sucesso!";
                }
                else
                {
                    mensagemStatus = "Cupom PROMO10 requer uma compra mínima de R$ 50,00.";
                }
                break;
            
            case "FRETEGRATIS":
                if (total >= 100)
                {
                    total -= frete;
                    cupomAplicado = true;
                    mensagemStatus = "Cupom FRETEGRATIS aplicado! Frete removido.";
                }
                else
                {
                    mensagemStatus = "Cupom FRETEGRATIS requer uma compra mínima de R$ 100,00.";
                }
                break;

            case "NATAL50":
                if (productType == "vestuario" && total >= 200)
                {
                    total -= 50;
                    cupomAplicado = true;
                    mensagemStatus = "Cupom NATAL50 aplicado com sucesso!";
                }
                else
                {
                    mensagemStatus = "Cupom NATAL50 é válido apenas para Vestuário em compras acima de R$ 200,00.";
                }
                break;

            default:
                mensagemStatus = "Cupom inválido.";
                break;
        }
        //PARA CLIENTE NOVO
        if (cupomAplicado && isNew == 'S' && productType != "eletronicos")
        {
            total *= 0.95;
            mensagemStatus += "\nBônus de 5% para novo cliente também aplicado!";
        }

        //SAÍDA
        Console.WriteLine("\n--- Resumo da Compra ---");
        Console.WriteLine(mensagemStatus);
        Console.WriteLine($"Valor original: {originalTotal}");
        Console.WriteLine($"Valor final: {total}");
        Console.WriteLine("Obrigado pela sua preferência!");
    }
}
