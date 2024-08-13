namespace OOP_ProjectGame
{
    internal class Program
    {
        public interface IAttack 
        {
            public void Jap();
            public void Straight();
            public void LeftHook();
            public void RightHook();
            public void LeftUpper();
            public void RightUpper();
            public void Leftbody();
            public void Rightbody();
        }
        public interface IAvoid 
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
