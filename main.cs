using System;
class Program {
  public static void Main(string[] args)
    {
        calc calc = new calc();
        
        string teste = "";
        int opcao = 0;
        while (true)
        {
          
            Console.WriteLine("Escolha um numero de 1 a 5 das operações:\n====================\n1)Soma\n2)Subtração\n3)Multiplicação\n4)Divisao\n5)Tabuada");

          Console.WriteLine("====================");
          

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
              Console.WriteLine("====================");
                   Console.WriteLine("Informe numero:");
            calc.a=float.Parse(Console.ReadLine());

Console.WriteLine("====================");
            Console.WriteLine("Informe numero:");
            calc.b = float.Parse(Console.ReadLine());
              Console.WriteLine("====================");
            float a = calc.a;
            float b = calc.b;  
              
            
              Console.WriteLine("Resultado da operação é: "+calc.Soma(a,b));
            }

          
          else if (opcao == 2)
            {  
              Console.WriteLine("====================");
              Console.WriteLine("Informe numero:");
              calc.a=float.Parse(Console.ReadLine());

              Console.WriteLine("====================");
              Console.WriteLine("Informe numero:");
              calc.b = float.Parse(Console.ReadLine());
              float a = calc.a;
              float b = calc.b;  
              
                          Console.WriteLine("====================");
              Console.WriteLine("Resultado da operação é: "+(calc.Sub(a,b)));
            }
  
          else if (opcao == 3)
            {
              Console.WriteLine("====================");   
              Console.WriteLine("Informe numero:");
              calc.a=float.Parse(Console.ReadLine());
              Console.WriteLine("====================");

            Console.WriteLine("Informe numero:");
            calc.b = float.Parse(Console.ReadLine());
            float a = calc.a;
            float b = calc.b;  
        Console.WriteLine("====================");
              Console.WriteLine("Resultado da operação é: "+(calc.Multi(a,b)));
            }

          else if (opcao == 4)
            {
              Console.WriteLine("====================");   
              Console.WriteLine("Informe numero:");
              calc.a=float.Parse(Console.ReadLine());
              Console.WriteLine("====================");

            Console.WriteLine("Informe numero:");
            calc.b = float.Parse(Console.ReadLine());
            float a = calc.a;
            float b = calc.b;  
        Console.WriteLine("====================");
              Console.WriteLine("Resultado da operação é: "+(calc.Divi(a,b)));
            }
          else if(opcao==5){
             Console.WriteLine("====================");
             Console.WriteLine("Informe numero para saber a tabuada desejada:");
             calc.num=int.Parse(Console.ReadLine());
             
              int num = calc.num;
            
               Console.WriteLine("====================");
              Console.WriteLine("[Tabuada do "+calc.Tabuada(num)+" ]");
            }
          else{
            Console.WriteLine("Opcao invalida!");
             Console.WriteLine("====================");
           continue;           
          }
            Console.WriteLine("====================");
            Console.WriteLine("Voce deseja continuar a fazer operações: s/n?");
        Console.WriteLine("====================");
            teste = Console.ReadLine();
            if (teste != "s")
            {
                break;
            }
        }

    }
  }

