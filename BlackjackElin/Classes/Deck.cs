namespace BlackjackElin.Classes
{
    internal class Deck
    {
        private List<Card> _cards;

        public Deck()
        {
            _cards = CreateDeck();
        }


        private List<Card> CreateDeck()
        {
            List<Card> cards = new List<Card>();

            string[,] suits = {{ "🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪" , "🂫", "🂭", "🂮" },
                                { "🂱", "🂲", "🂳", "🂴", "🂵", "🂶", "🂷", "🂸", "🂹", "🂺", "🂻", "🂽", "🂾" },
                                { "🃁", "🃂", "🃃", "🃄", "🃅", "🃆", "🃇", "🃈", "🃉", "🃊", "🃋", "🃍", "🃎" },
                                { "🃑", "🃒", "🃓", "🃔", "🃕", "🃖", "🃗", "🃘", "🃙", "🃚", "🃛", "🃝", "🃞" }};

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card((j + 1), suits[i, j]));
                }
            }
            return cards;
        }
        public Card GetCard(int index) { return _cards[index]; }
        //public Card GetTopcardBacksideUp () { }
        public int GetDeckLength() { return _cards.Count; }
        public void ShuffleDeck()
        {
            var random = new Random();
            Card[] arrayOfcards = _cards.ToArray();
            for (int i = 0; (i < arrayOfcards.Length); i++)
            {

            }
        }
    }
}
