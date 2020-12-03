using System;

namespace ConsoleApp24
{
	class Program
	{
		static void Main(string[] args)
		{
			RealSpawner rs = new RealSpawner(Neprijatelji.Creep);
			rs.DajNesto();
		}
	}
	public class RealSpawner
	{
		private readonly EnemySpawner es;

		public RealSpawner(Neprijatelji n)
		{
			switch(n)
			{
				case Neprijatelji.Creep:
					es = new NestoDrugo();
					break;
			}
		}

		public Neprijatelj DajNesto()
			=> es.Spawn();
	}


	//Cocrete Producer
	public class NestoDrugo : EnemySpawner
	{
		public override Neprijatelj Spawn()
		{
			return new Novi();
		}
	}

	public enum Neprijatelji
	{
		Creep,
		NestoDrug
	}

	//Producer
	public abstract class EnemySpawner
	{
		public abstract Neprijatelj Spawn();
	}


	//Concrete Product
	public class Novi : Neprijatelj
	{
		public override void OstetiIgraca()
		{
			throw new NotImplementedException();
		}
	}
	public class Melee : Neprijatelj
	{
		public string mac;
		public int jacina;
		public override void OstetiIgraca()
		{
			throw new NotImplementedException();
		}
	}
	public class Puca : Neprijatelj
	{
		public string Oruzje;
		public int Domet;
		public override void OstetiIgraca()
		{
			throw new NotImplementedException();
		}
	}

	//Product
	public abstract class Neprijatelj
	{
		public int hp;
		public abstract void OstetiIgraca();
	}
}
