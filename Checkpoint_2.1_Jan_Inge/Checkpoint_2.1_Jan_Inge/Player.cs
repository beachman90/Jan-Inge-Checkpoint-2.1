namespace Checkpoint_2._1_Jan_Inge
{
    public class Player
    {
        public string PlayerName { get; private set; }
        public string PlayerNumber { get; set; }

        public Player(string playerName, string playerNumber) 
        {
            PlayerName = playerName;
            PlayerNumber = playerNumber;            
        }

        //public void AddPlayer(Player player)
        //{
        //    Player.Add
        //}
        public override string ToString()
        {
            return $"{PlayerName} wears number {PlayerNumber}.";
        }

    }


}