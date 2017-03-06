using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ex09LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			p.Run();
			
			Console.ReadKey();
		}
		public void Run()
		{
			#region TEST MYLIST
			/*
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

			ClubMember indextest = new ClubMember() { Nr = 123, Fname = "index", Lname = "cool", Age = 99};
			ml.Insert(indextest, 3);
			Console.WriteLine("-----");
			Console.WriteLine("indextest: "+ml.IndexOf(indextest));
			Console.WriteLine("indextest equals: "+indextest.Equals(new ClubMember() { Nr=123, Fname = "index", Lname = "cool", Age = 99}));
			*/
			#endregion

			int smallsize = 1000;
			int largesize = smallsize * 10;

			ClubMember[] smallLinear = new ClubMember[smallsize];
			ClubMember[] largeLinear = new ClubMember[largesize];

			ClubMember[] smallBinary = new ClubMember[smallsize];
			ClubMember[] largeBinary = new ClubMember[largesize];

			for (int i = 0; i < smallsize; i++)
			{
				smallLinear[i] = CMFactory.GetClubMember();
				smallBinary[i] = CMFactory.GetClubMember();
			}
			for (int i = 0; i < largesize; i++)
			{
				largeLinear[i] = CMFactory.GetClubMember();
				largeBinary[i] = CMFactory.GetClubMember();
			}

			

			long SLtime = SearchLinear(smallLinear);
			Console.WriteLine("SearcLinear(smallLinear): "+SLtime+"ms");
			long LLtime = SearchLinear(largeLinear);
			Console.WriteLine("SearcLinear(largeLinear): " + LLtime + "ms");
			


		}

		public long SearchLinear(IComparable[] arr)
		{
			Stopwatch timer = new Stopwatch();
			timer.Start();
			Random rand = new Random();
			for (int u = 0; u < 3; u++)
			{
				ClubMember cm = (ClubMember)arr[rand.Next(arr.Length)];
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i].Equals(cm))
					{
						break;
					}
				}
			}
			timer.Stop();
			return timer.ElapsedMilliseconds;
		}
		

	}
}
