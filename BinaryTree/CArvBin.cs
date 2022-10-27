using System;

namespace AED_ArvoreBinaria {
    class CArvBin {
        public Node root;
        public CArvBin() {
            this.root = null;
        }
        public CArvBin(bool preload) {
            Insert(34);
            Insert(77);
            Insert(62);
            Insert(51);
            Insert(42);
            Insert(73);
            Insert(46);
            Insert(45);
            Insert(55);
            Insert(49);
            Insert(89);
            Insert(70);
        }

        public void Insert(int value) {
            this.root = this.InsertInTree(value, this.root);
            if(this.root != null) {
                CalculaAlturaNos(this.root);
                CalculaProfundidadeNos(this.root, 1);
                CalculaFatorBalanceamentoNos(this.root);
            }
        }
        
        private Node InsertInTree(int value, Node node) {

            if(node == null) {
                node = new Node(value);
            }

            else if(value < node.item) node.left = InsertInTree(value, node.left);

            else if(value > node.item) node.right = InsertInTree(value, node.right);

            return node;
        }

        private Node Search(int value, Node node) {
            if(node == null) return null; // Registro não encontrado

            else if(value < node.item)
                return Search(value, node.left);

            else if(value > node.item)
                return Search(value, node.right);

            else return node;
        }

        private Node GetNode(int value) {
            return this.Search(value, this.root);
        }

        private int CalculaAlturaNos(Node currentNode) {
            if(currentNode == null) {
                return 0;
            } else {
                int alturaEsquerda = CalculaAlturaNos(currentNode.left);
                int alturaDireita = CalculaAlturaNos(currentNode.right);
                currentNode.height = 1 + Math.Max(alturaEsquerda, alturaDireita);
                return currentNode.height;
            }
        }
        private void CalculaProfundidadeNos(Node currentNode, int depthParam) {
            if(currentNode == null) {
                return;
            } else {
                currentNode.depth = depthParam;
                CalculaProfundidadeNos(currentNode.left, depthParam + 1);
                CalculaProfundidadeNos(currentNode.right, depthParam + 1);
            }
        }

        private void CalculaFatorBalanceamentoNos(Node currentNode) {
            if(currentNode == null) {
                return;
            } else {
                setBalanceFactor(currentNode);
                if(currentNode.left != null)
                    CalculaFatorBalanceamentoNos(currentNode.left);
                if(currentNode.right != null)
                    CalculaFatorBalanceamentoNos(currentNode.right);
                return;
            }
        }
        private void setBalanceFactor(Node currentNode) {
            int subTreeLeftHeight = 0;
            int subTreeRightHeight = 0;
            if(currentNode.left != null) {
                subTreeLeftHeight = currentNode.left.height;
            }
            if(currentNode.right != null) {
                subTreeRightHeight = currentNode.right.height;
            }
            currentNode.balanceFactor = subTreeLeftHeight - subTreeRightHeight;
        }

        // Letra A ===============================================================
        public int GetMaiorElemento() {
            return MaiorElemento(this.root);
        }
        private int MaiorElemento(Node currentNode) {
            if(currentNode != null && currentNode.right == null) {
                return currentNode.item;
            } else {
                return MaiorElemento(currentNode.right);
            }
        }

        public int GetMenorElemento() {
            return MenorElemento(this.root);
        }

        private int MenorElemento(Node currentNode) {
            if(currentNode != null && currentNode.left == null) {
                return currentNode.item;
            } else {
                return MenorElemento(currentNode.left);
            }
        }

        // Letra B ===============================================================
        public int GetMenorElementoDaSubArvore(int valor) {
            Node raizSubArvore = GetNode(valor);
            return MenorElemento(raizSubArvore);
        }

        public int GerMaiorElementoDaSubArvore(int valor) {
            Node raizSubArvore = GetNode(valor);
            return MaiorElemento(raizSubArvore);
        }

        // Letra C ===============================================================
        
        public int GetAlturaNo(int value) {
            return GetNodeHeight(value);
        }
        private int GetNodeHeight(int value) {
            return this.SearchAndGetHeight(value, this.root);
        }
               
        private int SearchAndGetHeight(int value, Node node) {
            if(node == null) return -1; // Registro não encontrado

            else if(value < node.item)
                return SearchAndGetHeight(value, node.left);

            else if(value > node.item)
                return SearchAndGetHeight(value, node.right);

            else  return node.height;
        }

        // Letra D ===============================================================

        public int GetProfundidadeNo(int value) {
            return GetNodeDepth(value);
        }
        private int GetNodeDepth(int value) {
            return this.SearchAndGetDepth(value, this.root);
        }
        private int SearchAndGetDepth(int value, Node node) {
            if(node == null) return -1; // Registro não encontrado

            else if(value < node.item)
                return SearchAndGetDepth(value, node.left);

            else if(value > node.item)
                return SearchAndGetDepth(value, node.right);

            else return node.depth;
        }

        // Letra E ===============================================================
        public int GetFatorBalanceamentoNo(int value) {
            return GetNodeBalanceFactor(value);
        }
        private int GetNodeBalanceFactor(int value) {
            return this.SearchAndGetBalanceFactor(value, this.root);
        }
        private int SearchAndGetBalanceFactor(int value, Node node) {
            if(node == null) return -1; // Registro não encontrado

            else if(value < node.item)
                return SearchAndGetBalanceFactor(value, node.left);

            else if(value > node.item)
                return SearchAndGetBalanceFactor(value, node.right);

            else return node.balanceFactor;
        }

        // Letra F ===============================================================
        public int GetDescendentesNo(int value) {
            Node node = GetNode(value);
            return CalculaDescendentesNo(node) - 1;
        }
        public int CalculaDescendentesNo(Node currentNode) {
            int count = 0;
            if(currentNode != null) {
                count++;
                count += CalculaDescendentesNo(currentNode.left);
                count += CalculaDescendentesNo(currentNode.right);
            }
            return count;
        }

        // Letra G ===============================================================

        public int GetReferenciaParaNo(int valor) {
            Node getNodeFromTree = GetNode(valor);
            if(getNodeFromTree != null) {
                    return CalculaReferenciaParaNo(this.root, getNodeFromTree);
                
            }
            return 0;
        }

        private int CalculaReferenciaParaNo(Node currentNode, Node referencedNode) {
            if(root == referencedNode || currentNode == null) {
                return -1;
            } else {
                if(currentNode.left == referencedNode || currentNode.right == referencedNode) {
                    return currentNode.item;
                } else {
                    if(currentNode.item < referencedNode.item) {
                        return CalculaReferenciaParaNo(currentNode.right, referencedNode);
                    } else {
                        return CalculaReferenciaParaNo(currentNode.left, referencedNode);
                    }
                }
            }
        }

        // Letra H ===============================================================
        public int GetQuantidadeElementosMaiorQue(int value) {
            return CalcularQuantidadeElementosMaiorQue(this.root, value);
        }
        private int CalcularQuantidadeElementosMaiorQue(Node currentNode, int value) {
            int count = 0;
            if(currentNode != null) {
                if(currentNode.item > value) {
                    count++;
                }
                count += CalcularQuantidadeElementosMaiorQue(currentNode.left, value);
                count += CalcularQuantidadeElementosMaiorQue(currentNode.right, value);
            }
            return count;
        }

        public int GetQuantidadeElementosMenorQue(int value) {
            return CalcularQuantidadeElementosMenorQue(this.root, value);
        }

        private int CalcularQuantidadeElementosMenorQue(Node currentNode, int value) {
            int count = 0;
            if(currentNode != null) {
                if(currentNode.item < value) {
                    count++;
                }
                count += CalcularQuantidadeElementosMenorQue(currentNode.left, value);
                count += CalcularQuantidadeElementosMenorQue(currentNode.right, value);
            }
            return count;
        }

        //Letra I ===============================================================
        public void ImpressaoDecrescente() {
            Impressao(root);
        }
        private void Impressao(Node currentNode) {
            if(currentNode.right != null) {
                Impressao(currentNode.right);
            }
            Console.Write("{0}, ", currentNode.item);
            if(currentNode.left != null) {
                Impressao(currentNode.left);
            }
        }

        //Letra J ===============================================================
        public void ImpressaoInformacoes() {
            ImprimirInfos(root, null);
        }
        private void ImprimirInfos(Node currentNode, Node fatherNode) {
            Console.WriteLine();
            if(currentNode.depth == 1) {
                Console.WriteLine("          Tipo do Nó: Raíz!");
            }
            if(currentNode.height > 1 && currentNode.height < root.height) {
                Console.WriteLine("          Tipo do Nó :Nó intermediário");
            }
            if(currentNode.height == 1) {
                Console.WriteLine("          Tipo do Nó: Folha!");
            }

            Console.WriteLine("               Valor: {0}", currentNode.item);
            Console.WriteLine("              Altura: {0}", currentNode.height);
            Console.WriteLine("        Profundidade: {0}", currentNode.depth);
            Console.WriteLine("                 Pai: {0}", GetReferenciaParaNo(currentNode.item));
            if(currentNode.left == null) {
                Console.WriteLine("Valor filho esquerda: {0}", "Não existe");
            } else {
                Console.WriteLine("Valor filho esquerda: {0}", currentNode.left.item);
            }

            if(currentNode.right == null) {
                Console.WriteLine(" Valor filho direita: {0}", "Não existe");
            } else {
                Console.WriteLine("Valor filho esquerda: {0}", currentNode.right.item);
            }

            if(currentNode.left != null) {
                fatherNode = currentNode;
                ImprimirInfos(currentNode.left, fatherNode);
            }
            if(currentNode.right != null) {
                fatherNode = currentNode;
                ImprimirInfos(currentNode.right, fatherNode);
            }
        }

        // Letra K ===============================================================
        public void ImprimirOrdenado() {
            Console.Write("Pré ordem: [");
            ImprimirPreOrdem(root);
            Console.Write("]");

            Console.WriteLine();
            Console.Write("Em ordem: [");
            ImprimirOrdenado(root);
            Console.Write("]");

            Console.WriteLine();
            Console.Write("Pós ordem: [");
            ImprimirPosOrdem(root);
            Console.Write("]");
        }
        public void ImprimirPreOrdem(Node currentNode) {
            Console.Write("{0}, ", currentNode.item);
            if(currentNode.left != null) {
                ImprimirPreOrdem(currentNode.left);
            }
            if(currentNode.right != null) {
                ImprimirPreOrdem(currentNode.right);
            }
        }
        public void ImprimirOrdenado(Node currentNode) {

            if(currentNode.left != null) {
                ImprimirOrdenado(currentNode.left);
            }
            Console.Write("{0}, ", currentNode.item);
            if(currentNode.right != null) {
                ImprimirOrdenado(currentNode.right);
            }
        }
        private void ImprimirPosOrdem(Node currentNode) {

            if(currentNode.left != null) {
                ImprimirPosOrdem(currentNode.left);
            }
            if(currentNode.right != null) {
                ImprimirPosOrdem(currentNode.right);
            }
            Console.Write("{0}, ", currentNode.item);
        }
    }
}
