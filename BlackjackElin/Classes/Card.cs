using System.Reflection.Metadata.Ecma335;

namespace BlackjackElin.Classes
{
    public class Card
    {
        private int _value { get; }
        private string _suit;
        private string _backside = "🂠";

        public Card (int value, string suit)
        {
            _value = value;
            _suit = suit;
        }
        public override string ToString() => _suit;
    }
}
