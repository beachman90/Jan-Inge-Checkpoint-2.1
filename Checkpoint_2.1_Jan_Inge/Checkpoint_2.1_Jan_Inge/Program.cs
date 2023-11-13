using System.ComponentModel;

namespace Checkpoint_2._1_Jan_Inge
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Team myTeam = new("Hansamlingen");

            Player player = new("Han Store", "8");
            myTeam.players.Add(player);

            Player player2 = new("Han Lave", "11");
            myTeam.players.Add(player2);

            Player player3 = new("Han Sov", "5");
            myTeam.players.Add(player3);

            Player player4 = new("Han Sa", "3");
            myTeam.players.Add(player4);

            Star starPlayer = new("Han Beste", "7", "Someone has the be the best, his name is Han and he likes to blend in");
            myTeam.players.Add(starPlayer);

            myTeam.PrintTeam();

            


        }
    }


}