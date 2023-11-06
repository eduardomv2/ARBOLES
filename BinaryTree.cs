using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES
{
    internal class BinaryTree
    {
        public TreeNode Root;  // Referencia al nodo raíz del árbol.

        public BinaryTree()
        {
            Root = null;  // Inicializa el árbol como vacío (sin raíz).
        }

        // Operación de inserción
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);  // Llama a la función de inserción recursiva.
        }

        private TreeNode InsertRec(TreeNode root, int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);  // Si el nodo actual es nulo, crea un nuevo nodo con el valor.
            }
            else if (data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);  // Si el valor es menor, inserta en el subárbol izquierdo.
            }
            else if (data > root.Data)
            {
                root.Right = InsertRec(root.Right, data);  // Si el valor es mayor, inserta en el subárbol derecho.
            }
            return root;  // Devuelve el nodo modificado.
        }

        // Operación de búsqueda
        public bool Search(int data)
        {
            return SearchRec(Root, data);  // Llama a la función de búsqueda recursiva.
        }

        private bool SearchRec(TreeNode root, int data)
        {
            if (root == null)
                return false;  // Si el nodo actual es nulo, el valor no se encuentra en el árbol.

            if (root.Data == data)
                return true;  // Si el valor coincide con el nodo actual, se ha encontrado.

            if (data < root.Data)
                return SearchRec(root.Left, data);  // Si el valor es menor, busca en el subárbol izquierdo.

            return SearchRec(root.Right, data);  // Si el valor es mayor, busca en el subárbol derecho.
        }

        // Operación de eliminación
        public void Delete(int data)
        {
            Root = DeleteRec(Root, data);  // Llama a la función de eliminación recursiva.
        }

        private TreeNode DeleteRec(TreeNode root, int data)
        {
            if (root == null)
                return root;  // Si el nodo actual es nulo, no se puede eliminar nada.

            if (data < root.Data)
                root.Left = DeleteRec(root.Left, data);  // Si el valor es menor, busca en el subárbol izquierdo.
            else if (data > root.Data)
                root.Right = DeleteRec(root.Right, data);  // Si el valor es mayor, busca en el subárbol derecho.
            else
            {
                if (root.Left == null)
                    return root.Right;  // Si no hay hijo izquierdo, reemplaza con el hijo derecho.
                else if (root.Right == null)
                    return root.Left;  // Si no hay hijo derecho, reemplaza con el hijo izquierdo.

                root.Data = MinValue(root.Right);  // Encuentra el valor mínimo en el subárbol derecho.
                root.Right = DeleteRec(root.Right, root.Data);  // Elimina el valor mínimo del subárbol derecho.
            }

            return root;  // Devuelve el nodo modificado.
        }

        private int MinValue(TreeNode node)
        {
            int minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }

        // Recorrido inorden para mostrar los elementos
        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);  // Recorre el subárbol izquierdo.
                Console.Write(node.Data + " ");  // Imprime el valor del nodo actual.
                InOrderTraversal(node.Right);  // Recorre el subárbol derecho.
            }
        }
    }
}

