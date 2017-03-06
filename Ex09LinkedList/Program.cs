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

			Stopwatch sw = new Stopwatch();
			Console.Write("Populating arrays...");
			sw.Start();
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
			sw.Stop();
			Console.Write(" "+sw.ElapsedMilliseconds+"ms\n");
			Console.Write("Sorting binary arrays...");
			sw.Reset();
			sw.Start();
			smallBinary = InsertionSort<ClubMember>(smallBinary);
			largeBinary = InsertionSort<ClubMember>(largeBinary);
			sw.Stop();
			Console.Write(" "+sw.ElapsedMilliseconds+"ms\n");
			Console.Write("Running searches...\n");
			long SLtime = SearchLinear(smallLinear);
			Console.WriteLine("SearchLinear(smallLinear): "+SLtime+"ms");
			long LLtime = SearchLinear(largeLinear);
			Console.WriteLine("SearchLinear(largeLinear): " + LLtime + "ms");

			long SBtime = SearchBinary(smallBinary);
			Console.WriteLine("SearchBinary(smallBinary): " + SBtime + "ms");
			long LBtime = SearchBinary(largeBinary);
			Console.WriteLine("SearchBinary(largeBinary): " + LBtime + "ms");

			Console.WriteLine("Finished.");

		}

		public long SearchLinear(IComparable[] arr)
		{
			Stopwatch timer = new Stopwatch();
			Random rand = new Random();
			ClubMember cm1 = (ClubMember)arr[rand.Next(arr.Length)];
			ClubMember cm2 = (ClubMember)arr[rand.Next(arr.Length)];
			ClubMember cm3 = (ClubMember)arr[rand.Next(arr.Length)];
			timer.Start();
			for (int j = 0; j < 1000; j++)
			{

				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i].Equals(cm1))
					{
						break;
					}
				}
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i].Equals(cm2))
					{
						break;
					}
				}
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i].Equals(cm3))
					{
						break;
					}
				}

			}
			timer.Stop();
			return timer.ElapsedMilliseconds;
		}

		long SearchBinary(IComparable[] arr)
		{
			Stopwatch timer = new Stopwatch();
			Random rand = new Random();
			ClubMember cm1 = (ClubMember)arr[rand.Next(arr.Length)];
			ClubMember cm2 = (ClubMember)arr[rand.Next(arr.Length)];
			ClubMember cm3 = (ClubMember)arr[rand.Next(arr.Length)];
			timer.Start();
			for (int j = 0; j < 1000; j++)
			{

				Array.BinarySearch(arr, cm1);
				Array.BinarySearch(arr, cm2);
				Array.BinarySearch(arr, cm3);

			}
			timer.Stop();
			return timer.ElapsedMilliseconds;
		}

		public ClubMember[] InsertionSort<ClubMember>(ClubMember[] inputarray, Comparer<ClubMember> comparer = null)
		{
			var equalityComparer = comparer ?? Comparer<ClubMember>.Default;
			for (var counter = 0; counter < inputarray.Length - 1; counter++)
			{
				var index = counter + 1;
				while (index > 0)
				{
					if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
					{
						var temp = inputarray[index - 1];
						inputarray[index - 1] = inputarray[index];
						inputarray[index] = temp;
					}
					index--;
				}
			}
			return inputarray;
		}
	}
}
