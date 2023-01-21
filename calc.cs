using System;
public class calc{
  public float a {get;set;}
  public float b {get;set;}
  public int num {get;set;}
  public float base2{get;set;}
    public float altura{get;set;}


  
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

  public float Base(float altura,float base2){

    return (base2*altura)/2;
  }

  
  }