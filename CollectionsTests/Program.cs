using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTest
{
	class Program
	{
		static void Main(string[] args)
		{
			const int iterations = 100000;
			const string word = "Wyraz";
			var list = new List<Entity>();
			var set = new HashSet<Entity>();
			var dictionary = new Dictionary<int, Entity>();
			var slist = new SortedList<int, Entity>();
			var sset = new SortedSet<Entity>();
			var sdictionary = new SortedDictionary<int, Entity>();

			//Insert set
			Stopwatch swiSet = new Stopwatch();
			swiSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				set.Add(entity);
			}
			swiSet.Stop();

			//Insert list
			Stopwatch swiList = new Stopwatch();
			swiList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				list.Add(entity);
			}
			swiList.Stop();

			//Insert dictionary
			Stopwatch swiDict = new Stopwatch();
			swiDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				dictionary.Add(i, entity);
			}
			swiDict.Stop();

			//Search set
			Stopwatch swsSet = new Stopwatch();
			swsSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = set.Where(s => s.Id == 50000);
			}
			swsSet.Stop();

			//Search list
			Stopwatch swsList = new Stopwatch();
			swsList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = list.Where(s => s.Id == 50000);
			}
			swsList.Stop();

			//Search dictionary
			Stopwatch swsDict = new Stopwatch();
			swsDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = dictionary[50000];
			}
			swsDict.Stop();

			//Search non key set
			Stopwatch swsnSet = new Stopwatch();
			swsnSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = set.Where(s => s.Name == "Wyraz50000");
			}
			swsnSet.Stop();

			//Search non key list
			Stopwatch swsnList = new Stopwatch();
			swsnList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = list.Where(s => s.Name == "Wyraz50000");
			}
			swsnList.Stop();

			//Search non key dictionary
			Stopwatch swsnDict = new Stopwatch();
			swsnDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = dictionary.Where(s => s.Value.Name == "Wyraz50000");
			}
			swsnDict.Stop();


			//Search obj set
			Stopwatch swobjSet = new Stopwatch();
			swobjSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = 50000,
					Name = word + 50000
				};
				var data = set.Where(s => s == entity);
			}
			swobjSet.Stop();

			//Search obj list
			Stopwatch swobjList = new Stopwatch();
			swobjList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				var data = list.Where(s => s == entity);
			}
			swobjList.Stop();

			//Search obj dictionary
			Stopwatch swobjDict = new Stopwatch();
			swobjDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				var data = dictionary.Where(s => s.Value == entity);
			}
			swobjDict.Stop();

			//////////////////////////////////////////////////////
			// SORTOWANE
			/////////////////////////////////////////////////////

			//Insert set
			Stopwatch sswiSet = new Stopwatch();
			sswiSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				sset.Add(entity);
			}
			sswiSet.Stop();

			//Insert list
			Stopwatch sswiList = new Stopwatch();
			sswiList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				slist.Add(i, entity);
			}
			sswiList.Stop();

			//Insert dictionary
			Stopwatch sswiDict = new Stopwatch();
			sswiDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				sdictionary.Add(i, entity);
			}
			sswiDict.Stop();

			//Search set
			Stopwatch sswsSet = new Stopwatch();
			sswsSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = sset.Where(s => s.Id == 50000);
			}
			sswsSet.Stop();

			//Search list
			Stopwatch sswsList = new Stopwatch();
			sswsList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = slist.Where(s => s.Key == 50000);
			}
			sswsList.Stop();

			//Search dictionary
			Stopwatch sswsDict = new Stopwatch();
			sswsDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = sdictionary[50000];
			}
			sswsDict.Stop();

			//Search non key set
			Stopwatch sswsnSet = new Stopwatch();
			sswsnSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = sset.Where(s => s.Name == "Wyraz50000");
			}
			sswsnSet.Stop();

			//Search non key list
			Stopwatch sswsnList = new Stopwatch();
			sswsnList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = slist.Where(s => s.Value.Name == "Wyraz50000");
			}
			sswsnList.Stop();

			//Search non key dictionary
			Stopwatch sswsnDict = new Stopwatch();
			sswsnDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var data = sdictionary.Where(s => s.Value.Name == "Wyraz50000");
			}
			sswsnDict.Stop();


			//Search obj set
			Stopwatch sswobjSet = new Stopwatch();
			sswobjSet.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = 50000,
					Name = word + 50000
				};
				var data = sset.Where(s => s == entity);
			}
			sswobjSet.Stop();

			//Search obj list
			Stopwatch sswobjList = new Stopwatch();
			sswobjList.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				var data = slist.Where(s => s.Value == entity);
			}
			sswobjList.Stop();

			//Search obj dictionary
			Stopwatch sswobjDict = new Stopwatch();
			sswobjDict.Start();
			for (int i = 0; i < iterations; i++)
			{
				var entity = new Entity
				{
					Id = i,
					Name = word + i
				};

				var data = sdictionary.Where(s => s.Value == entity);
			}
			sswobjDict.Stop();

			Console.WriteLine($"Zapis Set {swiSet.ElapsedTicks} ticks");
			Console.WriteLine($"Zapis Lista {swiList.ElapsedTicks} ticks");
			Console.WriteLine($"Zapis Słownik {swiDict.ElapsedTicks} ticks");

			Console.WriteLine($"Wyszukiwanie int Set {swsSet.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie int Lista {swsList.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie int Słownik {swsDict.ElapsedTicks} ticks");

			Console.WriteLine($"Wyszukiwanie po stringu Set {swsnSet.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie po stringu Lista {swsnList.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie po stringu Słownik {swsnDict.ElapsedTicks} ticks");

			Console.WriteLine($"Wyszukiwanie całym obiekcie Set {swobjSet.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie całym obiekcie Lista {swobjList.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie całym obiekcie Słownik {swobjDict.ElapsedTicks} ticks");


			Console.WriteLine($"Zapis sSet {sswiSet.ElapsedTicks} ticks");
			Console.WriteLine($"Zapis sLista {sswiList.ElapsedTicks} ticks");
			Console.WriteLine($"Zapis sSłownik {sswiDict.ElapsedTicks} ticks");

			Console.WriteLine($"Wyszukiwanie int sSet {sswsSet.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie int sLista {sswsList.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie int sSłownik {sswsDict.ElapsedTicks} ticks");

			Console.WriteLine($"Wyszukiwanie po stringu sSet {sswsnSet.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie po stringu sLista {sswsnList.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie po stringu sSłownik {sswsnDict.ElapsedTicks} ticks");

			Console.WriteLine($"Wyszukiwanie całym obiekcie sSet {sswobjSet.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie całym obiekcie sLista {sswobjList.ElapsedTicks} ticks");
			Console.WriteLine($"Wyszukiwanie całym obiekcie sSłownik {sswobjDict.ElapsedTicks} ticks");


			Console.ReadLine();
		}
	}

	class Entity : IComparable
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public override int GetHashCode()
		{
			return Id.GetHashCode() + Name.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			var o = (Entity)obj;
			return o.Id == this.Id && o.Name == this.Name;
		}

		public int CompareTo(object obj)
		{
			var o = (Entity)obj;

			return this.Id > o.Id ? 1 : this.Id == o.Id ? 0 : -1;
		}
	}
}
