using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	public class BST
	{
		public BSTNode root;

		public int count;

		public void Insert(IComparable data)
		{
			if(root == null)
			{
				root = new BSTNode();
				root.data = data;
				count = 1;
			}else
			{
				BSTNode node = root;
				while (node != null)
				{
					if (data.CompareTo(node.data) < 0)
					{
						if (node.left == null)
						{
							node.left = new BSTNode();
							node.left.data = data;
							count++;
							break;
						}
						node = node.left;
					}
					else if (data.CompareTo(node.data) > 0)
					{
						if (node.right == null)
						{
							node.right = new BSTNode();
							node.right.data = data;
							count++;
							break;
						}
						node = node.right;
					}
				}
				
			}
		}
		public void printtree()
		{
			Console.WriteLine(root.data.ToString());
			Console.WriteLine(root.left.data.ToString());
			Console.WriteLine(root.right.data.ToString());
			Console.WriteLine(root.right.right.data.ToString());
		}
	}
}
