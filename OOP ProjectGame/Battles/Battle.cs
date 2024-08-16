using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ProjectGame.Battles
{
    public abstract class Battle
    {
        protected Game game;
        public Battle(Game game)
        {
            this.game = game;
        }
        public abstract void Enter();
        public abstract void Render();
        public abstract void Update();
        public abstract void Input();
        public abstract void Exit();
    }
}
