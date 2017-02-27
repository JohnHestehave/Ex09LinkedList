using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	public class MyList
	{
		private Node Head;
		int count;
		public void Insert(object o)
		{
			Node n = new Node();
			n.Data = o;
			n.Next = Head;
			Head = n;
			count++;
		}

		public void Insert(object o, int index)
		{
			if(index == 0)
			{
				Insert(o);
				return;
			}
			Node nn = new Node();
			nn.Data = o;

			Node n = new Node();
			n.Next = Head;
			
			for(int i = 0; i < index; i++)
			{
				if(n.Next != null)
				{
					n = n.Next;
				}
			}
			nn.Next = n.Next;
			n.Next = nn;
			count++;

		}

		public void Delete()
		{
			Head = Head.Next;
			count--;
		}

		public void Delete(int index)
		{
			if(index == 0)
			{
				Delete();
				return;
			}
			Node n = Head;
			
			if (count-1 > index && count > 0)
			{
				for (int i = 0; i < index - 1; i++)
				{
					if (n.Next != null)
					{
						n = n.Next;
					}
				}
				n.Next = n.Next.Next;
				count--;
			}else
			{
				throw new IndexOutOfRangeException();
			}

		}

		public object Search(int index)
		{
			Node n = Head;
			for(int i = 0; i < index; i++)
			{
				n = n.Next;
			}
			return n.Data;
		}

		public override string ToString()
		{
			string s = "";
			Node n = Head;
			while(n != null)
			{
				s += n.Data.ToString();
				n = n.Next;
				if(n != null)
				{
					s += "\n";
				}
			}
			return s;
		}

		
	}
}
