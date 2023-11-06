using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ARBOLES
{
    internal class TreeNode
    {
        public int Data;  // Valor almacenado en el nodo.
        public TreeNode Left;  // Referencia al hijo izquierdo.
        public TreeNode Right;  // Referencia al hijo derecho.

        public TreeNode(int data)
        {
            Data = data;  // Inicializa el nodo con un valor específico.
            Left = null;  // Inicializa el hijo izquierdo como nulo.
            Right = null;  // Inicializa el hijo derecho como nulo.
        }
    }
}
