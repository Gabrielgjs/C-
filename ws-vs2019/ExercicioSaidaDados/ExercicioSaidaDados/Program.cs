﻿using System;
using System.Globalization;

namespace ExercicioSaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            String produto1 = "Computador";
            String produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} , cujo preço é {preco1}");
            Console.WriteLine($"{produto2} , cujo preço é {preco2}");
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero : {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine($"Arredondado ( três casas decimais): {medida:F3}" );
            Console.WriteLine("Serapador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
