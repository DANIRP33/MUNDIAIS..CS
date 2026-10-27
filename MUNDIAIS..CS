using System;
					
public class Program
{
	public static void Main()
	{
		//DECLARAÇÃO DE VARIÁVEIS
		String time1;
		String time2;
		int mundiais1;
		int mundiais2;
		
		//COLETA DE VARIÁVEIS TIME 1
		Console.WriteLine("INSIRA O NOME DO PRIMEIRO TIME");
		time1 = Console.ReadLine();
		Console.WriteLine("QUANTOS MUNDIAIS DA FIFA O " + time1 + " POSSUI? ");
		mundiais1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("INSIRA O NOME DO SEGUNDO TIME");
		time2 = Console.ReadLine();
		Console.WriteLine("QUANTOS MUNDIAIS DA FIFA O " + time2 + " POSSUI? ");
		mundiais2 = Convert.ToInt32(Console.ReadLine());
		
		
	   // COMPARAÇÃO DOS TÍTULOS
       if (mundiais1 > mundiais2) 
       { 
       Console.WriteLine("O " + time1 + " é maior que " + time2); 
       } 
      else if (mundiais2 > mundiais1) 
      { 
      Console.WriteLine("O " + time2 + " é maior que " + time1); 
      }
      else 
      { 
     Console.WriteLine("Os dois têm o mesmo número de títulos"); 
     }
			
							  
	
		}
}		
