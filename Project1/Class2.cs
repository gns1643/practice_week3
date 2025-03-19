using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Human
    {
        public int Hp = 100;
        public int Mp = 100;
        public int Exp = 0;
        public int Level = 1;
        public Human(int h, int m, int e, int l)
        {
            Hp = h;
            Mp = m;
            Exp = e;
            Level = l;
        }
        public Human()
        {
        }
        public void Attacked(int dmg)
        {
            Hp -= dmg;
            Console.WriteLine(dmg + "만큼의 데미지를 입었습니다.");
            if (Hp <= 0)
            {
                Console.WriteLine("캐릭터가 사망하였습니다.");
            }
        }
        public int getHp()
        {
            return Hp;
        }
    }
    public class Class2
    {
        public static void Test_Human()
        {
            Human Jihoon = new Human(200, 50, 30, 5);
            Jihoon.Attacked(100);
            Console.WriteLine($"남은 hp는 {Jihoon.getHp()} 입니다");
            Console.ReadLine();
        }
    }
}
