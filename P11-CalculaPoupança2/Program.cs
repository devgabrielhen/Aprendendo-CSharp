﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Poupança 2");

        //rendimento de 0.5% ao mês

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + "R$" + investimento);

            //mes = mes + 1, mes ++ tambêm funciona!
            mes += 1;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes += 1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + "R$" + investimento);
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}