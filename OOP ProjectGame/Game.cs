using OOP_ProjectGame.Battles;

namespace OOP_ProjectGame
{
    public class Game
    {
        // 필드
        private bool isRunning;

        public Player player;
        public Enemy enemy;
        public Battle[] battles;
        public Battle curBattle;

        // 메서드
        public void ChangeScene(BattleType battleType)
        {
            curBattle.Exit();
            curBattle = battles[(int)battleType];
            curBattle.Enter();
        }
        public void Run()
        {
            Start();

            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }
        private void Start()
        {
            isRunning = true;

            battles = new Battle[(int)BattleType.Size];
            battles[(int)BattleType.Title] = new TitleBattle(this);
            battles[(int)BattleType.Sellect] = new SellectBattle(this);
            battles[(int)BattleType.Punch] = new Punch(this);
            battles[(int)BattleType.UpperCut] = new UpperCut(this);

            curBattle = battles[(int)BattleType.Title];
            curBattle.Enter();
        }
        private void Render()
        {
            curBattle.Render();
        }

        private void Input()
        {
            curBattle.Input();
        }
        private void Update()
        {
            curBattle.Update();
            if (enemy.curHp <= 0)
            {
                End();
            }
        }
        private void End()
        {
            curBattle.Exit();
        }
    }
}
