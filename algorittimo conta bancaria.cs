//algoritmo que solicite o número da conta, saldo, tipo de operação (1 para depósito, 2 para retirada) e valor da operação
using System;

class Program
{
    static void Main()
    {
        // Declaração de variáveis
        int numeroConta;         // Armazena o número da conta
        int tipoOperacao;        // Armazena o tipo de operação (1 ou 2)
        float saldo;             // Armazena o saldo atual da conta
        float valorOperacao;     // Armazena o valor da operação
        float saldoNovo;         // Armazena o saldo após a operação

        // Entrada de dados
        Console.Write("Digite o número da conta: ");
        numeroConta = int.Parse(Console.ReadLine());

        Console.Write("Digite o saldo da conta: ");
        saldo = float.Parse(Console.ReadLine());

        Console.Write("Digite o tipo (1 para depósito, 2 para retirada): ");
        tipoOperacao = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor da operação: ");
        valorOperacao = float.Parse(Console.ReadLine());

        // Processamento
        if (tipoOperacao == 1) // Depósito
        {
            saldoNovo = saldo + valorOperacao; // Calcula o saldo novo
            Console.WriteLine($"\nNúmero da conta: {numeroConta}");
            Console.WriteLine($"Saldo anterior: {saldo:F2}");
            Console.WriteLine("Operação: Depósito");
            Console.WriteLine($"Valor da operação: {valorOperacao:F2}");
            Console.WriteLine($"Saldo novo: {saldoNovo:F2}");
        }
        else if (tipoOperacao == 2) // Retirada
        {
            if (valorOperacao > saldo) // Verifica se o saldo é insuficiente
            {
                Console.WriteLine($"\nNúmero da conta: {numeroConta}");
                Console.WriteLine($"Saldo anterior: {saldo:F2}");
                Console.WriteLine("Operação: Retirada");
                Console.WriteLine($"Valor da operação: {valorOperacao:F2}");
                Console.WriteLine("Saldo insuficiente para a retirada.");
            }
            else
            {
                saldoNovo = saldo - valorOperacao; // Calcula o saldo novo
                Console.WriteLine($"\nNúmero da conta: {numeroConta}");
                Console.WriteLine($"Saldo anterior: {saldo:F2}");
                Console.WriteLine("Operação: Retirada");
                Console.WriteLine($"Valor da operação: {valorOperacao:F2}");
                Console.WriteLine($"Saldo novo: {saldoNovo:F2}");
            }
        }
        else // Tipo de operação inválido
        {
            Console.WriteLine("Tipo de operação inválido.");
        }
    }
}
