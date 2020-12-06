using System;

class MainClass
 {
  static int my_variable = 0; //Variable global

  public static void ProcTablaMultiplicar()
  {
    for (int i = 0; i <= 12; i++) 
    {
     Console.WriteLine("{0} x {1} = {2}", my_variable, i, (my_variable*i)); 
    }

    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadKey();
  }

  public static void ProcMostrarEvaluacionPrimo()
  {
    // 2, 3, 5, 7, 11: primeros primos
    bool valprimo = false;
    int[] divisores = {2, 3, 5, 7, 11};
    int posicion = 0;

    while(posicion <= 11)
    {
      if (my_variable % divisores[posicion] == 0)
      {
        //valprimo = false; Redundancia
        break;

      }else{ 
        if(my_variable / divisores[posicion] < divisores[posicion])
        {
         valprimo = true;
         break;
        }
      }
       
       posicion = posicion + 1;
    }
  
    if (valprimo == true)
    {
      Console.WriteLine("El Numero es primo");
    }else{
      Console.WriteLine("El Numero no es primo");
    }

    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadKey();

  }

  public static void ProcedimientoDiagonalesMatriz()
  {
    var seed = Environment.TickCount;
    var rand = new Random(seed);

    int filas = 4, columnas = 4;

    int[,] matriz = new int [filas, columnas];

    
     for(int f = 0; f <= 3; f++)
    {
      for(int c = 0; c <= 3; c++)
      {
        matriz[f, c] = rand.Next(0, 10);
      
        Console.Write("[" + matriz[f, c] + "]");
        
      }
      Console.WriteLine("");
    }

    Console.Write("DP: ");
    
    for(int f = 0; f <= 3; f++)
    {
      for(int c = 0; c <= 3; c++)
      {
        if(f==c){
          Console.Write(matriz[f,c] + " ");
        }
       
      }
    }
  
    Console.WriteLine("");

    Console.Write("DS: ");
    
    for(int f = 0; f <= 3; f++)
    {
      for(int c = 0; c <= 3; c++)
      {
        if(f+c==3){
         Console.Write(matriz[f,c] + " ");
       }
      }
    }

    Console.WriteLine("");

    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadKey();
  }

  //Console.Clear();
  public static void Main (string[] args)
  {
    int selector = 0; //Variable general
    int loop = 0; //Control de bucle

    while(loop == 0)
    {
      Console.WriteLine("La variable global es: " + my_variable);
      Console.WriteLine("Menu de opciones");
      Console.WriteLine("1. Capturar valor");
      Console.WriteLine("2. Generar la tabla de multiplicar");
      Console.WriteLine("3. Determinar primo o no primo");
      Console.WriteLine("4. Generar matriz");
      Console.WriteLine("5. Salir del Programa");

      Console.WriteLine("Elige la opcion que deseas: ");
      selector = int.Parse(Console.ReadLine());

      switch(selector)
      {
      case 1:
            Console.Clear();
            Console.WriteLine("Dame la variable: ");
            my_variable = int.Parse(Console.ReadLine());
            break;
      case 2:
            Console.Clear();
            ProcTablaMultiplicar();
            break;
      case 3:
            Console.Clear();
            ProcMostrarEvaluacionPrimo();
            break;
      case 4:
            Console.Clear();
            Console.WriteLine("Matriz 4x4");
            ProcedimientoDiagonalesMatriz();
            break;
      case 5:
            loop = 1;
            break;
      default:
            Console.WriteLine("Su selecion es invalida");
            break;
      }
      Console.Clear();
    }

    Console.WriteLine("Fin del programa");
  }

}