using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Player
    {
        public int CurrentHP
        {
            get; set;
        }
    }
    class Property
    {
        public static void Test_Property()
        {
            Player player = new Player();
            player.CurrentHP = 120;
            Console.WriteLine($"플레이어의 현재 hp는{player.CurrentHP}입니다.");
            Console.ReadLine();
        }
    }
}
