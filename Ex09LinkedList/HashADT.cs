using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	class HashADT
	{
		IComparable[] arr;
		public HashADT(int size)
		{
			arr = new IComparable[size];
		}

		public void Insert(IComparable data)
		{
			arr[data.GetHashCode()%arr.Length] = data;
		}

		public int Search(IComparable data)
		{
			if(arr[data.GetHashCode()%arr.Length] != null)
			{
				return data.GetHashCode();
			}
			return -1;
		}

		public IComparable GetElement(int index)
		{
			return arr[index];
		}

		public bool IndexInUse(int index)
		{
			return arr[index] != null;
		}
	}
}
