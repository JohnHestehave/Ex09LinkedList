using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList ml = new MyList();
			ml.Insert(new ClubMember() { Nr = 3, Fname = "Hej", Lname = "Farvel", Age = 100 });
			ml.Insert(new ClubMember() { Nr = 2, Fname = "Goddag", Lname = "Ses", Age = 85 });
			ml.Insert(new ClubMember() { Nr = 1, Fname = "Det", Lname = "Virker", Age = 40 });
			ml.Insert(new ClubMember() { Nr = 0, Fname = "Heh", Lname = "Hah", Age = 30 });
			ml.Insert(new ClubMember() { Nr = 100, Fname = "Heh", Lname = "Hah", Age = 30 }, 2);
			Console.WriteLine(ml.ToString());
			Console.WriteLine("-----");
			Console.WriteLine(ml.Search(0).ToString());
			Console.WriteLine("-----");
			ml.Delete(2);
			Console.WriteLine(ml.ToString());
			Console.ReadKey();
		}
	}
}
