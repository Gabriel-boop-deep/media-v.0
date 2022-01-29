using System;
using System.Collections.Generic;

class Desafio
{
    static void Main()
    {
    	int c=0;
    	double nota,media,soma;
    	int res=0;
    	soma=0;
   
    	
    
    	while (res!=1 )
    	{
    		
    		Console.WriteLine("Insira a nota: ");
    		nota=double.Parse(Console.ReadLine());
    		if (nota<0.0 || nota >10.0)
    		{
    			Console.WriteLine("Nota inválida");
    		}
    		else if (nota<=10.0 && nota>=0.0)
    		{
    			c=c+1;
    			soma=soma+nota;
    		    			
    			if(res>=0 && res<=1 && c==2)
    			{
    				media=soma/c;
    	            Console.WriteLine(media.ToString("F2"));
    				Console.WriteLine("Quer parar?\n(1-sim)\n(0-não)");
    		        res=int.Parse(Console.ReadLine());
    		        c=0;
    		        soma=0;
    		        
    		        
    			}
    			
    			if (res<0 || res >1 && c==2)
    			
    			{
    				while (res<0 || res >1)
    				{
    					Console.WriteLine("Quer parar?\n(1-sim)\n(0-não)");
    		            res=int.Parse(Console.ReadLine());
    				}
    			}
    		}
    		
    	}
    	
    }
    
}
