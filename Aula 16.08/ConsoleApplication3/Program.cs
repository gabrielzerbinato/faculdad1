using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            const Int32 N = 10; //const - não pode ser alterado durante o código, obriga que todos os desdobramentos do código sejam constante como eu desejo // 
            Int32[] lista = new Int32[N]; //abro e fecho colchetes, estou criando uma lista INTEIRO 32 BITS de tamano N = 10 (DECLARADO LÁ EM CIMA)// 
            Random rnd = new Random(); //RANDOM - OBJETO ALEATÓRIO
            imprimirLista(lista);

            for (int i = 0; i < lista.Length; i++)
            
            {

            lista[i] = i+10; //rnd.Next(0, 100); - retirou o aleatório 

            }

            imprimirLista(lista);
            int pos = buscaSequencial(lista, 12); //valor que vc quer achar a posição 
            Console.WriteLine("Posição" + pos);
            Console.ReadLine();
        }


       /* public static int buscaSequencial (Int32[] lista, Int32 x) //int sempre que eu for usar busca sequencial// 

        {

            bool encontrou = false; //bool só pode ser v ou f 
            int pos = -1; //-1 pq é n-1 na posição 
            int i = 0;

            while (i<lista.Length && !encontrou) //e enquanto estiver dentro da lista e enquanto não encontrar, eu procuro)//
            {
                //procura 
                if (lista[i] == x)
                {
                    encontrou = true;
                    pos = i;
                }
                
                i++;

            }

            return pos;

        } */  //pouco eficiente


        public static void imprimirLista(Int32[] lista)
        {// cria a função para poder referenciar ela em outros locais no código para "economizar espaço"// 

          //  for (int i = 0; i < lista.Length; i++)

            int i = 0;
            while (i<lista.Length)
            
            {
                Console.WriteLine("indice:" + i + ":" + lista[i]);
                i++;
            }

        }
    
    }


}
