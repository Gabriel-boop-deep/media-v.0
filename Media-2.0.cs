using System;
using System.Collections.Generic;

class Desafio
{
    static void Main()
    {
    	int c=0;
    	double nota,media,soma,a;
    	int res=0;
    	soma=0;
        a=1;
    	
    
    	while (res!=null)
    	{
    		
    		//Console.WriteLine("Insira a nota: ");
    		nota=double.Parse(Console.ReadLine());
    		if (nota<0 || nota >10)
    		{
    			Console.WriteLine("nota invalida");
    		}
    		else if (nota<=10 && nota>=0)
    		{
    			c=c+1;
    			soma=soma+nota;
    		    			
    			if(c==2)
    			{
    				media=soma/c;
    				Console.WriteLine("media = "+ Math.Round(media,2));
    				c=0;
    		        soma=0;
    		        Console.WriteLine("novo calculo (1-sim) (2-nao)");
    		        res=int.Parse(Console.ReadLine());
    		        while(res>2 || res<=0)
    		        {
    		  	
       			    Console.WriteLine("novo calculo (1-sim) (2-nao)");
    		        res=int.Parse(Console.ReadLine());
    		        
    		        }
    				if (res ==2)
    				{
    					break;
    				}
        				
    			}
    
    		}
    		
    	}
    	
    }
    
}
