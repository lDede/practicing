using System.Collections.Generic;
using System.Linq;

namespace AGTesting.Graphs {
    public class Vertice {
        private char valorElemento;
        private List<Vertice> verticesAdjacentes;
        public Vertice(char novoValor) {
            valorElemento = novoValor;
            verticesAdjacentes = new List<Vertice>();
        }
        public bool CriarAdjacencia(Vertice novoVertice) {
            if(!verticesAdjacentes.Contains(novoVertice)) {
                verticesAdjacentes.Add(novoVertice);
                return true;
            }
            return false;
        }
        public bool RemoverAdjacencia(Vertice verticeARemover) {
            if(verticesAdjacentes.Contains(verticeARemover)) {
                verticesAdjacentes.Remove(verticeARemover);
                return true;
            }
            return false;
        }
        public int RemoverTodasAsAdjacencias() {
            int contaArestas = verticesAdjacentes.Count();
            return contaArestas;
        }
        public List<Vertice> ColetarVerticesAdjacentes() {
            return verticesAdjacentes;
        }
        public char ColetarValorDoVertice() {
            return valorElemento;
        }
    }
}
