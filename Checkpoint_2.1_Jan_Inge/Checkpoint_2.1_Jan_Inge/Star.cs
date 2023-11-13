namespace Checkpoint_2._1_Jan_Inge
{
    public class Star : Player
    {
        public string Description;
        public Star(string playerName, string playerNumber, string description) : base(playerName, playerNumber)
        {
            Description = description;
        }
        

        public override string ToString()
        {
            return $"\nOur best player is {PlayerName}, and he wears number {PlayerNumber}. \nDescription: {Description}";
        }
    }


}