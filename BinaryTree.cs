//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BinaryTrees
//{
//    public class BinaryTree
//    {
//        public BinaryTree() {
//            Root = null;
//        }

//        public TreeNode? Root { get; set; }

//        public void InOrderTraversal(TreeNode node)
//        {
//            if(node != null)
//            {
//                InOrderTraversal(node.Left);
//                Console.WriteLine(node.Value + " ");
//                InOrderTraversal(node.Right);
//            }
//        }

//        public void Insert(int value)
//        {
//            TreeNode newNode = new TreeNode(value);

//            if(Root == null)
//            {
//                Root = newNode;
//            }
//            else
//            {
//                TreeNode current = Root;
//                TreeNode parent;

//                while(true)
//                {
//                    parent = current;

//                    if(value < current.Value)
//                    {
//                        current = current.Left;

//                        if(current == null)
//                        {
//                            parent.Left = newNode;
//                            break;
//                        } 
                            
//                    }
//                    else
//                    {
//                        current = current.Right;

//                        if(current == null)
//                        {
//                            parent.Right = newNode;
//                            break;
//                        }
//                    }
//                }
//            } 
//        }
//    }
//}
