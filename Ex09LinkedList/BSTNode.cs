using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	public class BSTNode
	{
		public object data;
		public BSTNode left;
		public BSTNode right;
		
		public void PrintData()
		{
			if(left != null)
			{
				left.PrintData();
			}
			Console.WriteLine(data.ToString());
			if(right != null)
			{
				right.PrintData();
			}
		}
	}
}
