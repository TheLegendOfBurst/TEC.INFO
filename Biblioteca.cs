/* using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Biblioteca
    {
        private List<Livro> acervo = new List<Livro>();
        
        public void AdicionarLivro(Livro l)
        {
            acervo.Add(l);
        }
        
        public void RemoverLivro(Livro l)
        {
            if(acervo.Contains(l))
            {
                acervo.Remove(l);                
            }
        }
        
        public void ListarLivros()
        {
            Console.WriteLine("Acervo de Livros:");
            foreach(Livro l in acervo)
            {
                Console.WriteLine($"{l.Titulo}, {l.Autor}, {l.Ano}");
            }
        }
    }
} */