namespace OOP_ProjectGame.Battles
{
    public class SellectBattle : Battle
    {
        private string input;

        public SellectBattle(Game game) : base(game)
        { }
        public override void Enter()
        {

        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Render()
        {
            Console.Clear();
            game.player.ShowInfo();
            Console.WriteLine("전투 상황을 고르시오");
            Console.WriteLine("1. Punch");
            Console.WriteLine("2. Hook");
            Console.WriteLine("3. UpperCut");
            Console.WriteLine("선택 : ");
        }
        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(BattleType.Punch); break;
                case "2":
                    game.ChangeScene(BattleType.Hook); break;
                case "3":
                    game.ChangeScene(BattleType.UpperCut); break;
            }
        }
        public override void Exit() { }
    }
}

