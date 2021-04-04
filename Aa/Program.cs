using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa
{
    class Program
    {
        static void Main(string[] args)
        {
            Charater a = new Charater();
            a.hp = 1000000;
            a.mhp = 1000000;
            a.atk = 200;
            a.def = 20;
            a.dc = 0;

            Charater b = new Charater();
            b.hp = 500000;
            b.mhp = 500000;
            b.atk = 500;
            b.def = 10;
            b.dc = 0;

            for(; a.hp >= 0; a.Atack(b))
			{
                b.Atack(a);
                Console.WriteLine($"b의hp = {b.hp} \n====================\n====================\na의hp = {a.hp}");
                if(a.hp <= 0)
                {
                    ++a.dc;
                    Console.WriteLine("\n====================\n\na의 패배");
                    Console.WriteLine($"\n===================\na의 죽의횟수 = {a.dc}\nb의 죽은 횟수 = {b.dc}\n\n종료.");
                    Console.ReadLine();
                    
				}
                else
				{
                    Console.WriteLine("");
				}
			}
        }
    }

    class Charater
	{
        public float hp = 0;
        public float mhp = 0;
        public float atk = 0;
        public float def = 0;
        public float dmg = 0;
        public int dc = 0;
        
        public void Atack(Charater target)
		{

            target.Hit(target, this);
		}

        public void Hit(Charater target , Charater Hitter)
		{
            if (target.def >= Hitter.atk)
            {
                Console.WriteLine("공격무효");
            }
            else
			{
                Hitter.dmg = Hitter.atk - target.def;
			}
            target.hp -= Hitter.dmg;
		}
	}
}