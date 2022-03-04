using System;

class Aula16{

    static void Main(){
        int tempo =0;
        int escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Belo horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [1]Avião | [2]Carro | [3]Ônibus ");

        escolha = Console.Read();

        switch(escolha){
            case'1': 
                tempo = 50;
                break;
             case'2': 
                tempo = 480;
                break;
             case'3': 
                tempo = 620;
                break;
            default:
                tempo = -1;
                break;    
        }

       if(tempo<0){
            Console.WriteLine("Transporte indisponível");
        }else{
            Console.WriteLine("Tempo de viagem com o transporte escolhido o tempo é: {0} minutos", tempo);
        }

        char op;
        Console.Write("\nCalcular outro transporte:[s/n]");
        op = Char.Parse(Console.ReadLine());
        if(op == 's' || op == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do programma");
        }
    }
}