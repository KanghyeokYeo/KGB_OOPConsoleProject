using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ProjectGame
{
    public class Enemy
    {
        public int maxHp=100;
        public int curHp=100;

        public void ShowInfo()
        {
            Console.WriteLine($"체력 : {curHp}/{maxHp}");
        }
    }
}
