namespace estruturaDeDados
{
    using System;
    public class aula
    {  
         public string Nome;

         public int Matricula;

         public aula(string nome)
         {
             
             Random matricula = new Random();
             Matricula = matricula.Next(000001, 999999);
             Nome = nome;


         }
        
    }
}