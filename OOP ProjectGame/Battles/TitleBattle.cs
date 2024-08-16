using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ProjectGame.Battles
{
    public class TitleBattle : Battle
    {
        public TitleBattle(Game game) : base(game) { }
        public override void Enter()
        {

        }
        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("게임을 시작하려면 아무키를 누르시오");
        }
        public override void Update()
        {
            game.ChangeScene(BattleType.Sellect);
        }
        public override void Exit() { }
    }
}
