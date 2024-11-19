using System;
using System.Threading; // Necessário para Thread.Sleep()

namespace Pomodoro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuração dos tempos (em minutos)
            int tempoDeTrabalho = 25; // Tempo para foco
            int tempoDeDescanso = 5;  // Tempo para descanso curto
            int ciclos = 4;           // Número de ciclos antes de um descanso longo

            Console.WriteLine("Relógio Pomodoro iniciado!");
            
            for (int cicloAtual = 1; cicloAtual <= ciclos; cicloAtual++)
            {
                Console.WriteLine($"\nCiclo {cicloAtual} de {ciclos}:");
                
                // Período de trabalho
                ContarTempo("Trabalho", tempoDeTrabalho);
                
                // Descanso curto, exceto no último ciclo
                if (cicloAtual < ciclos)
                {
                    ContarTempo("Descanso Curto", tempoDeDescanso);
                }
                else
                {
                    // Descanso longo após os ciclos
                    ContarTempo("Descanso Longo", tempoDeDescanso * 3);
                }
            }

            Console.WriteLine("\nParabéns! Você completou seus ciclos Pomodoro!");
        }

        static void ContarTempo(string atividade, int minutos)
        {
            Console.WriteLine($"Iniciando: {atividade} ({minutos} minutos)");
            for (int i = 0; i < minutos; i++)
            {
                Console.Write($"\rTempo restante: {minutos - i} minutos");
                Thread.Sleep(60000); // Aguarda 1 minuto (em milissegundos)
            }
            Console.WriteLine($"\n{atividade} concluído!");
        }
    }
}

