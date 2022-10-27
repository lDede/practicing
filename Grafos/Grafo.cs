using System;
using System.Collections.Generic;

namespace AGTesting.Graphs {
    public class Grafo {
        private int numeroArestas;
        private List<Vertice> conjunto;
        public Grafo() {
            numeroArestas = 0;
            conjunto = new List<Vertice>();
        }
        public void AdicionarVerticeAoGrafo(Vertice novoVertice) {
            if(!conjunto.Contains(novoVertice)) {
                conjunto.Add(novoVertice);
                Console.WriteLine("Vértice {0} adicionado ao grafo com sucesso", novoVertice.ColetarValorDoVertice());
            } else {
                Console.WriteLine("O vértice {0} já existe no grafo.", novoVertice.ColetarValorDoVertice());
            }
        }
        public void RemoverVerticeDoGrafo(Vertice verticeOrigem) {
            if(conjunto.Contains(verticeOrigem)) {                
                numeroArestas -= verticeOrigem.RemoverTodasAsAdjacencias();
                conjunto.Remove(verticeOrigem);
                Console.WriteLine("Vértice {0} e suas conexões foram removidas do grafo com sucesso", verticeOrigem.ColetarValorDoVertice());
            } else {
                Console.WriteLine("O vértice {0} não existe no grafo.", verticeOrigem.ColetarValorDoVertice());
            }
        }
        public void VisualizarConexoesEntreVertices() {
            foreach(Vertice percorreVerticesDoGrafo in conjunto) {

                List<Vertice> listaDeVerticesAdjacentes = percorreVerticesDoGrafo.ColetarVerticesAdjacentes();
                Console.Write("O vértice {0} se conecta a(aos) vértice(s): ", percorreVerticesDoGrafo.ColetarValorDoVertice());

                foreach(Vertice valoresDoVerticesAdjacentes in listaDeVerticesAdjacentes) {
                    Console.Write(" {0}, ", valoresDoVerticesAdjacentes.ColetarValorDoVertice());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total de arestas existentes do grafo: {0}", numeroArestas);
            Console.WriteLine("========================================");
            Console.WriteLine();
        }
        public void CriarArestaEntreVerticesAB(Vertice verticeOrigem, Vertice verticeDestino) {
            Conectar(verticeOrigem, verticeDestino);
        }
        public void RemoverArestaEntreVerticesAB(Vertice verticeOrigem, Vertice verticeDestino) {
            Desconectar(verticeOrigem, verticeDestino);
        }
        private void Conectar(Vertice A, Vertice B) {
            //O vértice A = verticeOrigem
            //O vértice B = verticeDestino
            if(conjunto.Contains(A) && conjunto.Contains(B)) {
                if(A.CriarAdjacencia(B))
                    numeroArestas++;
                else
                    Console.WriteLine("Os vértices {0} e {1} já estão conectados.", A.ColetarValorDoVertice(), B.ColetarValorDoVertice());
            } else
                Console.WriteLine("Um ou ambos os vértices especificados não existem no grafo.");
        }
        private void Desconectar(Vertice A, Vertice B) {
            //O vértice A = verticeOrigem
            //O vértice B = verticeDestino
            if(conjunto.Contains(A) && conjunto.Contains(B)) {
                if(A.RemoverAdjacencia(B)) {
                    numeroArestas--;
                } else
                    Console.WriteLine("Os vértices {0} e {1} não estão relacionados.", A.ColetarValorDoVertice(), B.ColetarValorDoVertice());
            } else
                Console.WriteLine("Um ou ambos os vértices especificados não existem no grafo.");
        }
    }
}
