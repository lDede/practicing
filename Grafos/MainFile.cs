using System;

namespace AGTesting.Graphs {
    class MainFile {
        public void Run() {
            Grafo grafo1 = new Grafo();

            Vertice A = new Vertice('A');
            Vertice B = new Vertice('B');
            Vertice C = new Vertice('C');
            Vertice D = new Vertice('D');
            Vertice E = new Vertice('E');

            grafo1.AdicionarVerticeAoGrafo(A);
            grafo1.AdicionarVerticeAoGrafo(B);
            grafo1.AdicionarVerticeAoGrafo(C);
            grafo1.AdicionarVerticeAoGrafo(D);
            grafo1.AdicionarVerticeAoGrafo(E);

            // Testa a existência de um vértice e o impede de ser adicionado.
            grafo1.AdicionarVerticeAoGrafo(E);

            grafo1.CriarArestaEntreVerticesAB(A, B);
            grafo1.CriarArestaEntreVerticesAB(A, C);

            // Testa uma nova conexão entre dois vértices, o programa deverá verificar se ja existe.
            grafo1.CriarArestaEntreVerticesAB(A, B);


            grafo1.CriarArestaEntreVerticesAB(B, A);
            grafo1.CriarArestaEntreVerticesAB(B, D);

            grafo1.CriarArestaEntreVerticesAB(C, E);
            
            // Testa uma conexão entre um vértice e ele mesmo.
            grafo1.CriarArestaEntreVerticesAB(E, E);

            grafo1.RemoverArestaEntreVerticesAB(A, B);
            grafo1.CriarArestaEntreVerticesAB(A, B);

            Console.WriteLine();

            grafo1.VisualizarConexoesEntreVertices();
            grafo1.RemoverVerticeDoGrafo(E);

            grafo1.VisualizarConexoesEntreVertices();
            grafo1.RemoverVerticeDoGrafo(A);

            grafo1.VisualizarConexoesEntreVertices();
            Console.ReadKey();
        }
    }
}
