using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	public class ClubMember
	{
		public int Nr;
		public string Fname;
		public string Lname;
		public int Age;
		public override string ToString()
		{
			return $"{Nr} {Fname} {Lname} {Age}";
		}
	}
}
