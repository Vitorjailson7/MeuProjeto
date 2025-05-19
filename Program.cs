namespace Name
{
    using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Verificar maioridade");
            Console.WriteLine("2 - Média de 3 provas");
            Console.WriteLine("3 - Verificar positivo/negativo");
            Console.WriteLine("4 - Verificar par/ímpar");
            Console.WriteLine("5 - Calcular dobro");
            Console.WriteLine("6 - Verificar divisível por 3");
            Console.WriteLine("7 - Soma de 1 até N");
            Console.WriteLine("8 - Contar números pares (10 entradas)");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1: Maioridade(); break;
                case 2: MediaProvas(); break;
                case 3: PositivoNegativo(); break;
                case 4: ParOuImpar(); break;
                case 5: CalcularDobro(); break;
                case 6: DivisivelPor3(); break;
                case 7: SomaAteN(); break;
                case 8: ContarPares(); break;
                case 0: Console.WriteLine("Saindo..."); break;
                default: Console.WriteLine("Opção inválida."); break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }

    static void Maioridade()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine(idade >= 18 ? "Maior de idade." : "Menor de idade.");
    }

     //////////////////////////////
  
    static void MediaProvas()
    {
        Console.Write("Nota 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        double n3 = double.Parse(Console.ReadLine());
        double media = (n1 + n2 + n3) / 3;
        Console.WriteLine(media >= 7 ? "Aprovado." : "Reprovado.");
    }

     ///////////////////////////

    static void PositivoNegativo()
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine(num >= 0 ? "Positivo." : "Negativo.");
    }
     
     ///////////////////////
     
    static void ParOuImpar()
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num % 2 == 0 ? "Par." : "Ímpar.");
    }
     
     ////////////////////
    
    static void CalcularDobro()
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("Dobro: " + (num * 2));
    }
  
     ///////////////////
   
    static void DivisivelPor3()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num % 3 == 0 ? "Divisível por 3." : "Não divisível por 3.");
    }


     //////////////////


    static void SomaAteN()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int n = int.Parse(Console.ReadLine());
        int soma = 0;
        for (int i = 1; i <= n; i++)
        {
            soma += i;
        }
        Console.WriteLine("Soma de 1 até " + n + ": " + soma);
    }

      //////////////////
   
    static void ContarPares()
    {
        int cont = 0, pares = 0;
        while (cont < 10)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) pares++;
            cont++;
        }
        Console.WriteLine("Quantidade de pares: " + pares);
    }
}
}