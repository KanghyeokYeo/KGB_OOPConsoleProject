using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ProjectGame.Battles
{
    public class Punch : Battle
    {
        private string input1;
        private string input2;
        public Punch(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Punch가 날라옵니다");
            Console.WriteLine("회피를 하려면 1을 입력하시오");
            input1 = Console.ReadLine();
            Thread.Sleep(3000);
            if (input1 != "1")
            {
                Console.WriteLine("회피를 실패하여 10 데미지 받았습니다");
                game.player.curHp -= 10;
                game.ChangeScene(BattleType.Sellect);
            }
        }
        public override void Input()
        {
            input2 = Console.ReadLine();
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("반격할 공격을 선택하시오");
            Console.WriteLine("1. : Hook");
            Console.WriteLine("2 : BodyBlow");
            Console.WriteLine("선택  : ");
            Thread.Sleep(3000);
        }
        public override void Update()
        {
            switch (input2)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("상대에게 데미지 10을 주었습니다");
                    game.enemy.curHp -= 10;
                    game.ChangeScene((BattleType)BattleType.Sellect);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("상대에게 데미지 20을 주었습니다");
                    game.enemy.curHp -= 20;
                    game.ChangeScene((BattleType)BattleType.Sellect);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("상대가 다시 자세를 잡았습니다");
                    game.ChangeScene((BattleType)BattleType.Sellect);
                    break;
            }
        }
        public override void Exit()
        {
        }
    }
}
