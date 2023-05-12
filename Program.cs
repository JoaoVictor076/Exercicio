using System;
using System.Collections.Generic;
using Exercicio;




class Program
{
    static void Main()
    {
        Impressora impressora = Impressora.pegar_instancia();

        Documento doc1 = new Documento("Relatório 1", "Conteúdo do relatório 1");
        impressora.AdicionarDocumento(doc1);

        Documento doc2 = new Documento("Carta de apresentação", "Conteúdo da carta de apresentação");
        impressora.AdicionarDocumento(doc2);

        Documento doc3 = new Documento("Relatório 1", "Conteúdo do relatório 1");
        impressora.AdicionarDocumento(doc3);

        Documento doc4 = new Documento("Relatório 1", "Conteúdo do relatório 1");
        impressora.AdicionarDocumento(doc3);


        impressora.Imprimir();
    }
}