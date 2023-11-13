namespace Checkpoint_2._1_Jan_Inge
{
    public class Team
    {
        public List<Player> players = new();
        public string TeamName { get; private set; }

        public Team(string teamName)
        {
             TeamName = teamName;           
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public override string ToString()
        {
            return $"Team is called {TeamName}.";
        }

        public void PrintTeam()
        {
            Console.WriteLine($"Team name: {TeamName}\n");
            foreach (Player player in players)
            {
                Console.WriteLine(player.ToString());
            }
        }

    }


}