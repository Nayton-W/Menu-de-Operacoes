using System;
public class calc{
  public float a {get;set;}
  public float b {get;set;}
  public int num {get;set;}
  public int tabuada=0;

  
public float Divi(float a=0 , float b=0){
return a/b;
}

public float Multi(float a=0 , float b=0){
return a*b;
}

public float Soma(float a=0 , float b=0){
return a+b;
}
public float Sub(float a=0 , float b=0){
return a-b;
}

  public int Tabuada(int num=0){
   int frmula=0;
   for (int contador = 1; contador <= 10; ++contador)
            {
                frmula =  num * contador;
                Console.WriteLine(num + " X " + contador + " = " + frmula);   
            }
    return num;
  }
  }