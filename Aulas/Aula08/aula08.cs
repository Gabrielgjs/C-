// Lendo valores do teclado 

using System;

class Aula08{
    static void Main(){
        int v1, v2 , soma; 
        string nome; 

        //Para ler dados do teclado podemos usar os metodos Read e ReadLine
        Console.Write("Digite O Primeiro valor: ");
        //Para ler um valor do teclado em forma de inteiro deve ser feito a conversão, pois o valor pelo metodo ReadLine vem como string. há duas formas de converter o valor, atráves do Parse ou Convert.
        v1= int.Parse(Console.ReadLine());
        Console.Write("Digite O Segundo valor: ");
        v2= Convert.ToInt32(Console.ReadLine());
        soma= v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);
    }
}