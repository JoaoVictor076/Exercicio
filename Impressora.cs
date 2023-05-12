using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Impressora
    {
        private static Impressora? instanciaUnica;
        private List<Documento> filaDeImpressao = new List<Documento>();

        private Impressora() { }

        public static Impressora pegar_instancia()
        {
            if (instanciaUnica == null)
            {
                instanciaUnica = new Impressora();
            }
            return instanciaUnica;
        }

        public void AdicionarDocumento(Documento documento)
        {
            foreach (Documento doc in filaDeImpressao)
            {
                if (doc.Titulo == documento.Titulo)
                {
                    Console.WriteLine("O documento já está na fila de impressão.");

                    return;
                }

            }

            filaDeImpressao.Add(documento);


        }



        public void Imprimir()
        {
            if (filaDeImpressao.Count == 0)
            {
                Console.WriteLine("Não há documentos para imprimir.");
                return;
            }

            Console.WriteLine("=== Fila de impressão ===");
            foreach (Documento doc in filaDeImpressao)
            {
                Console.WriteLine($"- {doc.Titulo}");
            }

            Console.WriteLine("=== Imprimindo ===");
            foreach (Documento doc in filaDeImpressao)
            {
                Console.WriteLine($"- {doc.Titulo}: {doc.Conteudo}");
            }

            filaDeImpressao.Clear();
        }
    }
}
