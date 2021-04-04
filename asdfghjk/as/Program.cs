using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
	class Program
	{
		static void Main(string[] args)
		{
			World world = new World();
			world.Init();

			foreach (Creature target in world.creatures)
			{
				if (target is iSwimmable)
				{
					(target as iSwimmable).Swim();
				}
				if (target is iWalkable)
				{
					(target as iWalkable).Walk();
				}
				if (target is iFlayable)
				{
					(target as iFlayable).Fly();
				}
			}
		}
	}

	interface iSwimmable
	{
		void Swim();
	}

	interface iWalkable
	{
		void Walk();
	}

	interface iFlayable
	{
		void Fly();
	}

	class World
	{
		public List<Creature> creatures = new List<Creature>();
		public void Init()
		{
			for (int i = 0; i < 3; i++)
			{
				creatures.Add(new Monkey());
			}

			creatures.Add(new Monkey());
			creatures.Add(new Monkey());
			creatures.Add(new Monkey());

			creatures.Add(new Whale());
			creatures.Add(new Whale());
			creatures.Add(new Whale());

			creatures.Add(new Dolphin());
			creatures.Add(new Dolphin());
			creatures.Add(new Dolphin());

			creatures.Add(new Eagle());
			creatures.Add(new Eagle());
			creatures.Add(new Eagle());

			creatures.Add(new Sparrow());
			creatures.Add(new Sparrow());
			creatures.Add(new Sparrow());

			creatures.Add(new Pigeon());
			creatures.Add(new Pigeon());
			creatures.Add(new Pigeon());

			creatures.Add(new Penguin());
			creatures.Add(new Penguin());
			creatures.Add(new Penguin());

			creatures.Add(new GoldFish());
			creatures.Add(new GoldFish());
			creatures.Add(new GoldFish());

			creatures.Add(new Eel());
			creatures.Add(new Eel());
			creatures.Add(new Eel());
		}
	}


	abstract class Creature //생성 불가능한 추상화 클래스
	{
	}

	abstract class Mammal : Creature //포유류
	{
	}

	abstract class Birds : Creature //조류
	{
	}

	abstract class Fish : Creature //어류
	{
	}



	class Monkey : Mammal, iWalkable
	{
		public void Walk()
		{
			Console.WriteLine("[Monkey] 걷는중 . . .");
		}
	}

	class Whale : Mammal, iSwimmable
	{
		public void Swim()
		{
			Console.WriteLine("[Whale] 수영하는중 . . .");
		}
	}

	class Dolphin : Mammal, iSwimmable
	{
		public void Swim()
		{
			Console.WriteLine("[Dolphin] 수영하는중 . . .");
		}
	}

	class Eagle : Birds, iFlayable
	{
		public void Fly()
		{
			Console.WriteLine("[Eagle] 나는중 . . .");
		}
	}

	class Sparrow : Birds, iFlayable
	{
		public void Fly()
		{
			Console.WriteLine("[Sparrow] 나는중 . . .");
		}
	}

	class Pigeon : Birds, iFlayable
	{
		public void Fly()
		{
			Console.WriteLine("[Pigeon] 나는중 . . .");
		}
	}

	class Penguin : Birds, iSwimmable
	{
		public void Swim()
		{
			Console.WriteLine("[Penguin] 수영하는중 . . .");
		}
	}

	class GoldFish : Fish, iSwimmable
	{
		public void Swim()
		{
			Console.WriteLine("[GoldFish] 수영하는중 . . .");
		}
	}
	class Eel : Fish, iSwimmable
	{
		public void Swim()
		{
			Console.WriteLine("[Eel] 수영하는중 . . .");
		}
	}
}