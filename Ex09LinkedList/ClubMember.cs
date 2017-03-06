using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	public class ClubMember : IComparable
	{
		public int Nr;
		public string Fname;
		public string Lname;
		public int Age;
		public override string ToString()
		{
			return $"{Nr} {Fname} {Lname} {Age}";
		}
		public ClubMember()
		{

		}
		public ClubMember(int nr, string fname, string lname, int age)
		{
			Nr = nr;
			Fname = fname;
			Lname = lname;
			Age = age;
		}
		public int CompareTo(object obj)
		{
			ClubMember o = (ClubMember)obj;
			return Nr.CompareTo(o.Nr);
		}

		public override bool Equals(object obj)
		{
			ClubMember o = (ClubMember)obj;
			return o.Nr == Nr && o.Fname == Fname && o.Lname == Lname && o.Age == Age;
		}

		public override int GetHashCode()
		{
			return Nr.GetHashCode()+Fname.GetHashCode()+Lname.GetHashCode()+Age.GetHashCode();
		}

	}
}
