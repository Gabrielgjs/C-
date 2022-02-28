using System;

class Aula10{

    enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};
    static void Main(){

       DiasSemana ds = DiasSemana.Domingo;
       //para acessar o valor do enum pelo indíce é necessario fazer o casting para do enum.
       DiasSemana ds1 = (DiasSemana)3;
       int ds2 = (int)DiasSemana.Sexta; // atravez do cast da variável para int, o valor retornado será o indíce de sexta;
       
       Console.WriteLine(ds);
       Console.WriteLine(ds1);
    }
}