namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new List<string>();
            game.Add("Animal Crossing: New Horizons");
            game.Add("Club Penguin Rewritten");
            {
                Console.WriteLine(game.Count);
                Console.ReadLine();
            }
        }
    }
}
