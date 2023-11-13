using Checkpoint_2._1_Jan_Inge;

namespace Checkpoint_2._1_UnitTest_Jan_Inge
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddToList_ReturnListContent()
        {
            Team myTeam = new("Gutta");
            myTeam.AddPlayer(new("Dude", "7"));
            myTeam.AddPlayer(new("Miss", "11"));
            myTeam.AddPlayer(new("Mr Buttons", "16"));

            int expected = myTeam.players.Count();
            int actual = 3;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CheckValue_ObjectInList()
        {
            Team myTeam = new("Gutta");
            myTeam.AddPlayer(new("Dude", "7"));
            
            string expected = myTeam.players[0].PlayerName;
            string actual = "Dude";

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
