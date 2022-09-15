namespace DLVarejo
{
    

using System;
public class menu{

    
	    
	public static void Main(string[] args)
	{
        entrar();
        //entrada no programa
        
        
        

        }
    

    public static void entrar(){
        string nome;
        string senha;
       
        bool liberdadetotal = true;
        // variaveis
        Console.WriteLine("===========================");

        Console.WriteLine("BEM VINDO A DLVarejos!");

        Console.WriteLine("===========================");

        Console.WriteLine("DIGITE O USUARIO: ");
        nome=(Console.ReadLine());
       
        Console.WriteLine("DIGITE SUA SENHA:");
        senha=(Console.ReadLine());

         if ((nome == "USUARIO") && (senha == "123321") && (liberdadetotal == true))
        {
              
            admin(nome);
        }else{
            Console.Clear();
            Console.WriteLine("VENDAS");
            //VENDAS
            
        }
        
    }


     public static void admin(string nome){

        Console.Clear();
        Console.WriteLine("Bem vindo " + nome) ;

         double escolha;
       
        //
        Console.WriteLine("------------------");
        Console.WriteLine("Se você quiser:");
        Console.WriteLine("[1] - funcionarios ");
        Console.WriteLine("[2] - fornecedores ");
        Console.WriteLine("[3] - cliente ");
        Console.WriteLine("[4] - vendas ");
        Console.WriteLine("[5] - sair ");
         Console.WriteLine("------------------");                      
         escolha=double.Parse(Console.ReadLine());
        
        switch(escolha){

            case 1:
            // cadastro cliente
            break;

            case 2:
            // cadastro gerente
            break;

            case 3:
            // cadastrar vendedor
            break;
            
            case 4:
            // cadastrar produto
            break;

            case 5:
            Console.Clear();
            Console.WriteLine("===========================");
             Console.WriteLine("*Você saiu do programa*");
             Console.WriteLine("===========================");
            break;
            //
            
           
        }
     
     
     }
      
    
       
}
}





        